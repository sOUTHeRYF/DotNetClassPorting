using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍
using System.Net.Sockets;
using System.Net;
namespace TestApp
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private System.Net.Sockets.Socket my;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            my   = new System.Net.Sockets.Socket(SocketType.Stream, ProtocolType.Tcp);
            my.Bind(new IPEndPoint(IPAddress.Any, 22112));
            my.Listen(3);
            SocketAsyncEventArgs myy = new SocketAsyncEventArgs();
            myy.Completed += Myy_Completed;
            my.AcceptAsync(myy);
        }

        private void Myy_Completed(object sender, SocketAsyncEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
