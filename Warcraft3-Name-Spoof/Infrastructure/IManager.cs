namespace Warcraft3_Name_Spoof.Infrastructure
{
    public interface IManager
    {
        #region Public Methods

        string ReadBuild();

        string ReadName();

        void WriteName(string gameName);

        #endregion
    }
}