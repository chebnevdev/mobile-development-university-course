using System;
using Tabbed.Carousel;
using Tabbed.MasterDetail;
using Tabbed.Tabbed;
using Tabbed.Theme;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabbed
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPageMDP();
            //MainPage = new TabbedMainPage();
            //MainPage = new CarouselMainPage();
            MainPage = new ThemeMainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
