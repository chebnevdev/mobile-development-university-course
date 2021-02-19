using System;
using Tabbed.Carousel;
using Tabbed.CheckBox;
using Tabbed.MasterDetail;
using Tabbed.RadioButton;
using Tabbed.Stepper;
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

            Device.SetFlags(new string[] { "RadioButton_Experimental" });

            //MainPage = new MainPageMDP();
            //MainPage = new TabbedMainPage();
            //MainPage = new CarouselMainPage();
            //MainPage = new ThemeMainPage();
            //MainPage = new CheckBoxMainPage();
            //MainPage = new RadioButtonMainPage();
            MainPage = new StepperMainPage();
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
