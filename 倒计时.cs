using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDimension.NanUI;
using NetDimension.NanUI.HostWindow;

namespace Seewo_Lamp
{
    class 倒计时 : Formium
    {

        // 指定启动 Url
#if DEBUG
    public override string StartUrl { get; } = "http://localhost:9001/root/index.html"; // 如果在 Debug 模式，那么请自行使用静态服务器来运行页面。
                                                                                        // 我使用的live-server，启动方法：
                                                                                        // live-server --port=9001
#else
        public override string StartUrl { get; } = "https://jar-wei.github.io/Seewo_Lamp_Service/index.html"; // 如果是 Release 那么就自动把页面作为内嵌资源打包进程序集。
                                                                            // 打包进程序集的资源不需要起 http 服务。
#endif
        public override HostWindowType WindowType => HostWindowType.Layered;
        public 倒计时()
        {
            // 在此处设置窗口样式
            Size = new System.Drawing.Size(800, 150);
            var style = UseExtendedStyles<LayeredWindowStyle>();






        }

        protected override void OnReady()
        {




            // 在此处进行浏览器相关操作

            //ShowDevTools();
            //ExecuteJavaScript("alert('Hello NanUI')");
        }
    }
}
