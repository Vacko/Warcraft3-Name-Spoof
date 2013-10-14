using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Warcraft3_Name_Spoof.Configuration;
using Warcraft3_Name_Spoof.Contracts;
using Warcraft3_Name_Spoof.Infrastructure;

namespace Warcraft3_Name_Spoof
{
    public class GameMemory : IMemory
    {
        #region Fields

        private readonly IProcess m_process;
        private IntPtr m_hProcess = IntPtr.Zero;
        private Process m_readProcess;

        #endregion

        #region Constructors

        public GameMemory(IProcess process) => m_process = process;

        #endregion

        #region Implementation of IMemory

        public string ReadMemory(uint valueToRead, int address) => ReadFromMemory(valueToRead, address);

        public string ReadMemory(uint valueToRead, int address, string dll) =>
            ReadFromMemory(valueToRead, address, dll: dll);

        public string ReadMemory(uint valueToRead, int address, int[] offsets) =>
            ReadFromMemory(valueToRead, address, offsets);

        public string ReadMemory(uint valueToRead, int address, int[] offsets, string dll) =>
            ReadFromMemory(valueToRead, address, offsets, dll);

        public void WriteMemory(string value, int address) => WriteToMemory(value + '\0', address);

        public void WriteMemory(string value, int address, int[] offsets) =>
            WriteToMemory(value + '\0', address, offsets);

        public void WriteMemory(string value, int address, string dll) =>
            WriteToMemory(value + '\0', address, dll: dll);

        public void WriteMemory(string value, int address, int[] offsets, string dll) =>
            WriteToMemory(value + '\0', address, offsets, dll);

        #endregion

        #region Private Methods

        private void CloseHandle()
        {
            int iRetValue = MemoryApi.CloseHandle(m_hProcess);
            if (iRetValue == 0) throw new Exception("CloseHandle Failed");
        }

        private int GetDllAddress(string dll)
        {
            int baseAddress = 0;

            ProcessModuleCollection modules = m_readProcess.Modules;
            foreach (ProcessModule module in modules)
                if (module.ModuleName == dll)
                    baseAddress = module.BaseAddress.ToInt32();

            return baseAddress;
        }

        private string GetString(byte[] bytes)
        {
            string sReturn = string.Empty;
            foreach (byte t in bytes)
                sReturn += (char) t;

            return sReturn;
        }

        private string Make(byte[] buffer)
        {
            string sTemp = "";

            foreach (byte t in buffer)
                if (Convert.ToInt16(t) < 10)
                    sTemp = "0" + ToHex(t) + sTemp;
                else
                    sTemp = ToHex(t) + sTemp;

            return sTemp;
        }

        private void Open()
        {
            if (m_readProcess == null && m_process.IsProcessRunning())
                m_readProcess = m_process.GetProcess();

            MemoryApi.ProcessAccessType access = MemoryApi.ProcessAccessType.ProcessVmRead
                                                 | MemoryApi.ProcessAccessType.ProcessVmWrite
                                                 | MemoryApi.ProcessAccessType.ProcessVmOperation;
            m_hProcess = MemoryApi.OpenProcess((uint) access, 1, (uint) m_readProcess.Id);
        }

        private byte[] PointerRead(IntPtr memoryAddress, uint bytesToRead, int[] offset, out int bytesRead)
        {
            int iPointerCount = offset.Length - 1;
            IntPtr ptrBytesRead;
            bytesRead = 0;
            byte[] buffer = new byte[4];
            int tempAddress = 0;

            if (iPointerCount == 0)
            {
                MemoryApi.ReadProcessMemory(m_hProcess, memoryAddress, buffer, 4, out ptrBytesRead);
                tempAddress = ToDec(Make(buffer)) + offset[0];

                buffer = new byte[bytesToRead];
                MemoryApi.ReadProcessMemory(m_hProcess, (IntPtr) tempAddress, buffer, bytesToRead, out ptrBytesRead);

                bytesRead = ptrBytesRead.ToInt32();

                return buffer;
            }

            for (int i = 0; i <= iPointerCount; i++)
                if (i == iPointerCount)
                {
                    MemoryApi.ReadProcessMemory(m_hProcess, (IntPtr) tempAddress, buffer, 4, out ptrBytesRead);
                    tempAddress = ToDec(Make(buffer)) + offset[i];

                    buffer = new byte[bytesToRead];
                    MemoryApi.ReadProcessMemory(m_hProcess, (IntPtr) tempAddress, buffer, bytesToRead,
                        out ptrBytesRead);

                    bytesRead = ptrBytesRead.ToInt32();
                    return buffer;
                }
                else if (i == 0)
                {
                    MemoryApi.ReadProcessMemory(m_hProcess, memoryAddress, buffer, 4, out ptrBytesRead);
                    tempAddress = ToDec(Make(buffer)) + offset[1];
                }
                else
                {
                    MemoryApi.ReadProcessMemory(m_hProcess, (IntPtr) tempAddress, buffer, 4, out ptrBytesRead);
                    tempAddress = ToDec(Make(buffer)) + offset[i];
                }

            return buffer;
        }

        private string PointerWrite(IntPtr memoryAddress, byte[] bytesToWrite, int[] offset, out int bytesWritten)
        {
            int iPointerCount = offset.Length - 1;
            IntPtr ptrBytesWritten;
            bytesWritten = 0;
            byte[] buffer = new byte[4];
            int tempAddress = 0;

            if (iPointerCount == 0)
            {
                MemoryApi.ReadProcessMemory(m_hProcess, memoryAddress, buffer, 4, out ptrBytesWritten);
                tempAddress = ToDec(Make(buffer)) + offset[0];
                MemoryApi.WriteProcessMemory(m_hProcess, (IntPtr) tempAddress, bytesToWrite, (uint) bytesToWrite.Length,
                    out ptrBytesWritten);

                bytesWritten = ptrBytesWritten.ToInt32();
                return ToHex(tempAddress);
            }

            for (int i = 0; i <= iPointerCount; i++)
                if (i == iPointerCount)
                {
                    MemoryApi.ReadProcessMemory(m_hProcess, (IntPtr) tempAddress, buffer, 4, out ptrBytesWritten);
                    tempAddress = ToDec(Make(buffer)) + offset[i];
                    MemoryApi.WriteProcessMemory(m_hProcess, (IntPtr) tempAddress, bytesToWrite,
                        (uint) bytesToWrite.Length, out ptrBytesWritten);

                    bytesWritten = ptrBytesWritten.ToInt32();
                    return ToHex(tempAddress);
                }
                else if (i == 0)
                {
                    MemoryApi.ReadProcessMemory(m_hProcess, memoryAddress, buffer, 4, out ptrBytesWritten);
                    tempAddress = ToDec(Make(buffer)) + offset[i];
                }
                else
                {
                    MemoryApi.ReadProcessMemory(m_hProcess, (IntPtr) tempAddress, buffer, 4, out ptrBytesWritten);
                    tempAddress = ToDec(Make(buffer)) + offset[i];
                }

            return ToHex(tempAddress);
        }

        private byte[] Read(IntPtr memoryAddress, uint bytesToRead, out int bytesRead)
        {
            byte[] buffer = new byte[bytesToRead];
            MemoryApi.ReadProcessMemory(m_hProcess, memoryAddress, buffer, bytesToRead, out IntPtr ptrBytesRead);
            bytesRead = ptrBytesRead.ToInt32();
            return buffer;
        }

        private string ReadFromMemory(uint valueToRead, int address, int[] offsets = null, string dll = null)
        {
            int memoryAddress = 0;
            byte[] getBytes = null;

            Open();

            if (dll == null)
                memoryAddress = address;
            else
                memoryAddress = GetDllAddress(dll) + address;

            if (offsets == null)
                getBytes = Read((IntPtr) memoryAddress, valueToRead, out int _);
            else
                getBytes = PointerRead((IntPtr) memoryAddress, valueToRead, offsets, out int _);

            CloseHandle();

            return GetString(getBytes);
        }

        private Process[] ReadGameProcess() => Process.GetProcessesByName(Config.Name);

        private int ToDec(string hex) => int.Parse(hex, NumberStyles.HexNumber);

        private string ToHex(int Decimal) => Decimal.ToString("X");

        private void Write(IntPtr memoryAddress, byte[] bytesToWrite, out int bytesWritten)
        {
            MemoryApi.WriteProcessMemory(m_hProcess, memoryAddress, bytesToWrite, (uint) bytesToWrite.Length,
                out IntPtr ptrBytesWritten);
            bytesWritten = ptrBytesWritten.ToInt32();
        }

        private void WriteToMemory(string value, int address, int[] offsets = null, string dll = null)
        {
            int memoryAddress = 0;

            Open();

            if (dll == null)
                memoryAddress = address;
            else
                memoryAddress = GetDllAddress(dll) + address;

            if (offsets == null)
                Write((IntPtr) memoryAddress, Encoding.ASCII.GetBytes(value), out int _);
            else
                PointerWrite((IntPtr) memoryAddress, Encoding.ASCII.GetBytes(value), offsets, out int _);

            CloseHandle();
        }

        #endregion
    }
}