
using NetDimension.NanUI;
using NetDimension.NanUI.HostWindow;
namespace Seewo_Lamp;

public partial class MainWindow : Form
{
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
}
