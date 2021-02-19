using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabbed.RadioButton
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RadioButtonMainPage : ContentPage
    {
        public RadioButtonMainPage()
        {
            InitializeComponent();
        }

        void OnColorChanged(object sender, CheckedChangedEventArgs e)
        {
            Xamarin.Forms.RadioButton button = sender as Xamarin.Forms.RadioButton;
            colorLabel.Text = $"Ваш любимый цвет: {button.Content}";
        }

        void OnFruitChanged(object sender, CheckedChangedEventArgs e)
        {
            Xamarin.Forms.RadioButton button = sender as Xamarin.Forms.RadioButton;
            fruitLabel.Text = $"Ваш любимый фрукт: {button.Content}";
        }
    }
}