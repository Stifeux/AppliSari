using SignaturePad.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    class PickerDemoPage : ContentPage
    {
        // Dictionary to get Color from color name.
        Dictionary<string, string> delaiToValue = new Dictionary<string, string>
        {
            { "4h ou moins", "<=4" }, { "Plus de 4h", ">4" },
            { "1 jour ou plus", "1j" }
        };

        public PickerDemoPage()
        {
            Picker picker = new Picker
            {
                Title = "Delai",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            foreach (string delai in delaiToValue.Keys)
            {
                picker.Items.Add(delai);
            }

            picker.SelectedIndexChanged += (sender, args) =>
            {
                System.Diagnostics.Debug.WriteLine(picker.SelectedItem);
            };

            SignaturePadView signatureView = new SignaturePadView()
            {
                StrokeWidth = 3f,
                StrokeColor = Color.Black,
                BackgroundColor = Color.White
            };

            // Build the page.

            this.Content = new StackLayout
            {
                Children =
                {
                    picker,
                    signatureView
                }
            };

        }
    }

    class gridTest : ContentPage
    {
        public gridTest()
        {
            var grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var topLeft = new Label { Text = "Top Left" };
            var topRight = new Label { Text = "Top Right" };
            var bottomLeft = new Label { Text = "Bottom Left" };
            var bottomRight = new Label { Text = "Bottom Right" };

            grid.Children.Add(topLeft, 0, 0);
            grid.Children.Add(topRight, 1, 0);
            grid.Children.Add(bottomLeft, 0, 1);
            grid.Children.Add(bottomRight, 1, 1);
        }
    }
}
