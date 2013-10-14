using System;
using System.Reflection;
using System.Windows.Forms;
using Ninject;

namespace Warcraft3_Name_Spoof
{
    internal static class Program
    {
        #region Fields

        private static IKernel m_kernel;

        #endregion

        #region Static Methods

        private static void Bootstrap()
        {
            m_kernel = new StandardKernel();
            m_kernel.Load(Assembly.GetExecutingAssembly());
        }

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(m_kernel.Get<MainForm>());
        }

        #endregion
    }
}