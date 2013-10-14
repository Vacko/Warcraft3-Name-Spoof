namespace Warcraft3_Name_Spoof.Infrastructure
{
    public interface IMemory
    {
        #region Public Methods

        string ReadMemory(uint valueToRead, int address);

        string ReadMemory(uint valueToRead, int address, string dll);

        string ReadMemory(uint valueToRead, int address, int[] offsets);

        string ReadMemory(uint valueToRead, int address, int[] offsets, string dll);

        void WriteMemory(string value, int address);

        void WriteMemory(string value, int address, int[] offsets);

        void WriteMemory(string value, int address, string dll);

        void WriteMemory(string value, int address, int[] offsets, string dll);

        #endregion
    }
}