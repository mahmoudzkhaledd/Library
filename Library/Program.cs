using Library.Logic.Presenters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Library
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            LoginPresenter presenter = new LoginPresenter(null);
            int id = presenter.CheckLoginByUserPassword(Properties.Settings.Default.userName, Properties.Settings.Default.Password);
            if (Properties.Settings.Default.LoginRemember && id != -1)
                Application.Run(new Library.View.Frm_Main(id));
            else
                Application.Run(new Library.View.Frm_Login());
        }
    }
}