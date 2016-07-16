using System.Threading.Tasks;
using Org.Json;
using System.Net;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plugin.DeviceInfo;

using Xamarin.Forms;

namespace formLogin
{
    public class App : Application
    {
        public App()
        {
            MainPage =new NavigationPage( new Page2());


            //MainPage = new ContentPage
            //{
            //    Content = new ScrollView
            //    {
            //        Content = new StackLayout
            //    {

            //        Padding = 50,
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //             new Label{ Text = "Generated AppId: " + CrossDeviceInfo.Current.GenerateAppId()},
            //  new Label{ Text = "Generated AppId: " + CrossDeviceInfo.Current.GenerateAppId(true)},
            //  new Label{ Text = "Generated AppId: " + CrossDeviceInfo.Current.GenerateAppId(true, "hello")},
            //  new Label{ Text = "Generated AppId: " + CrossDeviceInfo.Current.GenerateAppId(true, "hello", "world")},
            //  new Label{ Text = "Id: " + CrossDeviceInfo.Current.Id},
            //  new Label{ Text = "Model: " + CrossDeviceInfo.Current.Model},
            //  new Label{ Text = "Platform: " + CrossDeviceInfo.Current.Platform},
            //  new Label{ Text = "Version: " + CrossDeviceInfo.Current.Version},
            //        }
            //    }
            //}
            //};


            // The root page of your application
            //MainPage = new ContentPage
            //{
            //    Content = new ScrollView
            //    {
            //        Content = new StackLayout
            //        {
            //            Padding = 50,
            //            VerticalOptions = LayoutOptions.Start,
            //            Children = {
            //            mEmail,
            //            mPassword,
            //            btnLogin,
            //            listedhere
            //        }
            //        }
            //    }
            //};
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
