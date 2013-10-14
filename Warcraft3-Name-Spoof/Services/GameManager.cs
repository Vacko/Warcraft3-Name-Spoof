using Warcraft3_Name_Spoof.Configuration;
using Warcraft3_Name_Spoof.Contracts;
using Warcraft3_Name_Spoof.Infrastructure;

namespace Warcraft3_Name_Spoof.Services
{
    public class GameManager : IManager
    {
        #region Fields

        private readonly Offsets m_currentVersion;

        private readonly IMemory m_memory;

        #endregion

        #region Constructors

        public GameManager(IMemory memory, IVersion version)
        {
            m_memory = memory;
            m_currentVersion = version.GetVersion();
        }

        #endregion

        #region Implementation of IManager

        public string ReadBuild() => m_currentVersion != default(Offsets)
            ? m_memory.ReadMemory(8, m_currentVersion.BuildAddress, Config.Game)
            : string.Empty;

        public string ReadName() => m_currentVersion != default(Offsets)
            ? m_memory.ReadMemory(20, m_currentVersion.NameAddress, m_currentVersion.NameOffsets, Config.Game)
            : string.Empty;

        public void WriteName(string gameName)
        {
            if (m_currentVersion != default(Offsets))
                m_memory.WriteMemory(gameName, m_currentVersion.NameAddress, m_currentVersion.NameOffsets, Config.Game);
        }

        #endregion
    }
}