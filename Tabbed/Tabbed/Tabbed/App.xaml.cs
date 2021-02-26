using System;
using Tabbed.Carousel;
using Tabbed.CheckBox;
using Tabbed.ControllerView;
using Tabbed.ImagesDemo;
using Tabbed.MasterDetail;
using Tabbed.RadioButton;
using Tabbed.Stepper;
using Tabbed.Tabbed;
using Tabbed.Theme;
using Tabbed.DatePicker;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tabbed.LabelNS;
using Tabbed.Expander;

namespace Tabbed
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new string[] { "RadioButton_Experimental", "Expander_Experimental" });

            // TASK #4
            //MainPage = new MainPageMDP();
            //MainPage = new TabbedMainPage();
            //MainPage = new CarouselMainPage();
            //MainPage = new ThemeMainPage();

            // TASK #5
            //MainPage = new CheckBoxMainPage();

            // TASK #6
            //MainPage = new RadioButtonMainPage();
            //MainPage = new StepperMainPage();

            // TASK #7
            //MainPage = new MainPageCV();

            // TASK #8
            //MainPage = InitializeTask8();

            // TASK #9
            //MainPage = new MainPageDP();

            // TASK #10
            //MainPage = new LabelPage();
            MainPage = new ExpanderPage();
        }

        private static TabbedPage InitializeTask8()
        {
            var xamlTab = new TabbedPage();

            xamlTab.Children.Add(new LocalImages { Title = "Local" });
            xamlTab.Children.Add(new DownloadImages { Title = "Downloaded" });
            xamlTab.Children.Add(new EmbImages { Title = "Embedded" });
            xamlTab.Children.Add(new GIFImages { Title = "GIF Files" });
            return xamlTab;
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
