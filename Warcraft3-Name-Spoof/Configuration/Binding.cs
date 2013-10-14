using Ninject.Modules;
using Warcraft3_Name_Spoof.Infrastructure;
using Warcraft3_Name_Spoof.Services;

namespace Warcraft3_Name_Spoof
{
    public class Bindings : NinjectModule
    {
        #region Override of NinjectModule

        public override void Load()
        {
            Bind<IProcess>().To<GameProcess>();
            Bind<IVersion>().To<GameVersion>();
            Bind<IMemory>().To<GameMemory>();
            Bind<IManager>().To<GameManager>();
            Bind<MainForm>().ToSelf();
        }

        #endregion
    }
}