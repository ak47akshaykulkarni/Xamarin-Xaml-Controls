using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Connectivity;
using Plugin.DeviceInfo;

using Xamarin.Forms;

namespace formLogin
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            Title = "XAML Views Inside Scroll View";
            bool sad = Plugin.Connectivity.CrossConnectivity.Current.IsConnected;
            var platform = Device.OS.ToString();
            Title = platform;
        }
    }
}
