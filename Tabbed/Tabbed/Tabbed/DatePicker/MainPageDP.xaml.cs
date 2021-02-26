using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabbed.DatePicker

{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageDP : ContentPage
    {
        public MainPageDP()
        {
            InitializeComponent();
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            Recalculate();
        }

        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            Recalculate();
        }

        void Recalculate()
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date + (includeSwitch.IsToggled ? TimeSpan.FromDays(1) : TimeSpan.Zero);

            resultLabel.Text = string.Format("{0}", timeSpan.Days);
        }
    }
}
