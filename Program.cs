using NetDimension.NanUI;

namespace Seewo_Lamp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            ApplicationConfiguration.Initialize();
            WinFormium.CreateRuntimeBuilder(app => {
                app.UseMainWindow(ctx => {
                    ctx.MainForm = new MainWindow();
                    return null;
                }
                );
            }).Build().Run();

        }
    }
}