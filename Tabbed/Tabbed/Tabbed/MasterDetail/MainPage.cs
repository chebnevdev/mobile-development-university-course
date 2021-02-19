using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Tabbed.MasterDetail
{
    public class MainPageMDP : MasterDetailPage
    {
        public MainPageMDP()
        {
            Title = "MasterDetailPage Demo";

            Label header = new Label
            {
                Text = "MasterDetailPage",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            NamedColor[] namedColors =
            {
                new NamedColor("Aqua", Color.Aqua),
                new NamedColor("Black", Color.Black),
                new NamedColor("Blue", Color.Blue),
                new NamedColor("Fuchsia", Color.Fuchsia),
                new NamedColor("Gray", Color.Gray),
                new NamedColor("Green", Color.Green),
                new NamedColor("Lime", Color.Lime),
                new NamedColor("Maroon", Color.Maroon),
                new NamedColor("Navy", Color.Navy),
                new NamedColor("Olive", Color.Olive),
                new NamedColor("Purple", Color.Purple),
                new NamedColor("Red", Color.Red),
                new NamedColor("Silver", Color.Silver),
                new NamedColor("Teal", Color.Teal),
                new NamedColor("White", Color.White),
                new NamedColor("Yellow", Color.Yellow)
            };

            ListView listView = new ListView
            {
                ItemsSource = namedColors,
                Margin = new Thickness(10, 0),
                BackgroundColor = Color.Black
            };

            Master = new ContentPage
            {
                Title = "Color List",
                Content = new StackLayout
                {
                    Children =
                    {
                        header,
                        listView
                    }
                }
            };

            NamedColorPage detailPage = new NamedColorPage();
            Detail = detailPage;

            listView.ItemSelected += (sender, args) =>
            {
                Detail.BindingContext = args.SelectedItem;

                IsPresented = true;
            };

            listView.SelectedItem = namedColors[5];
            MasterBehavior = MasterBehavior.Popover;
        }
    }
}
