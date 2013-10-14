using Warcraft3_Name_Spoof.Contracts;

namespace Warcraft3_Name_Spoof.Infrastructure
{
    public interface IVersion
    {
        #region Public Methods

        Offsets GetVersion();

        #endregion
    }
}