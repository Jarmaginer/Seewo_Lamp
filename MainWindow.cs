
using NetDimension.NanUI;
using NetDimension.NanUI.HostWindow;
using System.Runtime.InteropServices;
using Microsoft.Win32;
namespace Seewo_Lamp;

public partial class MainWindow : Form
{
    [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
    public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var win = new 倒计时();
        win.Show(this);
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
        var win = new 课程表();
        win.Show(this);
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
        var win = new Clock();
        win.Show(this);
    }

    private void button4_Click(object sender, EventArgs e)
    {
        OpenFiles openFiles = new OpenFiles();
        string fileName = openFiles.OpenFileDialogs();
        fileName = Path.GetFullPath(fileName);
        var nResult = SystemParametersInfo(20, 1, fileName, 0x1 | 0x2); //更换壁纸

        RegistryKey hk = Registry.CurrentUser;
        RegistryKey run = hk.CreateSubKey(@"Control Panel\Desktop\");
        run.SetValue("Wallpaper", fileName);
    }
}
