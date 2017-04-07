using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Win32;
using Warcraft3_Name_Spoof.Configuration;
using Warcraft3_Name_Spoof.Contracts;
using Warcraft3_Name_Spoof.Infrastructure;

namespace Warcraft3_Name_Spoof.Services
{
    internal class GameVersion : IVersion
    {
        #region Fields

        private readonly List<Offsets> m_listOfVersions = new List<Offsets>();

        private string m_installPath = String.Empty;

        #endregion

        #region Constructors

        public GameVersion() => AddVersions();

        #endregion

        #region Implementation of IVersion

        public Offsets GetVersion() => m_listOfVersions.FirstOrDefault(s => ReadVersion(s.GameVersion));

        #endregion

        #region Private Methods

        private void AddVersions()
        {
            m_listOfVersions.Add(new Offsets
            {
                GameVersion = "1.26.0",
                BuildAddress = 0x4C0245,
                NameAddress = 0x00ACCE80,
                NameOffsets = new[] {0x21C}
            });
            m_listOfVersions.Add(new Offsets
            {
                GameVersion = "1.27.0",
                BuildAddress = 0x3DE4A5,
                NameAddress = 0x00A155A0,
                NameOffsets = new[] {0x21C}
            });
            m_listOfVersions.Add(new Offsets
            {
                GameVersion = "1.27.1",
                BuildAddress = 0x4A5C10,
                NameAddress = 0x00A2BC40,
                NameOffsets = new[] {0x21C}
            });
            m_listOfVersions.Add(new Offsets
            {
                GameVersion = "1.28.0",
                BuildAddress = 0x3B4A00,
                NameAddress = 0x00A3CC60,
                NameOffsets = new[] {0x21C}
            });
        }

        private string GetInstallPath()
        {
            if (m_installPath != String.Empty)
                return m_installPath;

            RegistryKey keyRegedit = Registry.CurrentUser.OpenSubKey(Config.RegistryPath);

            return keyRegedit != null ? m_installPath = keyRegedit.GetValue("InstallPath").ToString() : string.Empty;
        }

        private bool ReadVersion(string version) => GetInstallPath() != string.Empty &&
                                                    File.ReadAllText(m_installPath + @"\.product.db").Contains(version);

        #endregion
    }
}