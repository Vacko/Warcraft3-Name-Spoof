using System.Diagnostics;
using Warcraft3_Name_Spoof.Configuration;
using Warcraft3_Name_Spoof.Infrastructure;

namespace Warcraft3_Name_Spoof.Services
{
    public class GameProcess : IProcess
    {
        #region Implementation of IProcess

        public Process GetProcess() => ReadGameProcess().Length != 0 ? ReadGameProcess()[0] : null;

        public bool IsProcessRunning() => ReadGameProcess().Length != 0 ? true : false;

        #endregion

        #region Private Methods

        private Process[] ReadGameProcess() => Process.GetProcessesByName(Config.Name);

        #endregion
    }
}