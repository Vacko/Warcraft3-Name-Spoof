using System.Diagnostics;

namespace Warcraft3_Name_Spoof.Infrastructure
{
    public interface IProcess
    {
        #region Public Methods

        Process GetProcess();

        bool IsProcessRunning();

        #endregion
    }
}