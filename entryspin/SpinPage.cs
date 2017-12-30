using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace entryspin
{
    public class SpinPage : BasePage
    {
        public SpinPage()
        {
            var entryText = new Entry
            {
                WidthRequest = 200,
                TextColor = Color.Black,
                Placeholder = "Enter text",
                PlaceholderColor = Color.Gray
            };

            var imgTriangle = new Image
            {
                WidthRequest = 32,
                HeightRequest = 32,
                Source = "triangle.png"
            };

            var spinSpin = new Picker
            {
                TextColor = Color.Black
            };

            var text = new List<string> { "Hello", "From", "Me" };
            foreach (var t in text)
                spinSpin.Items.Add(t);

            var horizStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { entryText, imgTriangle }
            };

            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(12),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { horizStack }
            };

            var imgTap = new TapGestureRecognizer
            {
                NumberOfTapsRequired = 1,
                Command = new Command(() =>
                {
                    stack.Children.Add(spinSpin);
                })
            };
            imgTriangle.GestureRecognizers.Add(imgTap);

            spinSpin.SelectedIndexChanged += (sender, e) =>
            {
                entryText.Text = text[spinSpin.SelectedIndex];
            };

            Content = stack;
        }
    }
}


