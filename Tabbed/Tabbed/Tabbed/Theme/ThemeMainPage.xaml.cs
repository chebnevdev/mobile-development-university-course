using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabbed.Theme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemeMainPage : HeaderFooterPage
    {
        Label TemLabel;
        public ThemeMainPage()
        {
            InitializeComponent();
        }
        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            TemLabel = (Label)GetTemplateChild("ChangeThemeLabel");
            TemLabel.Text = OriginalTemplate ? "Orange Theme" : "Green Theme";
        }
    }
}