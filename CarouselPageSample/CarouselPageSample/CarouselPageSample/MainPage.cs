using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselPageSample
{
    public class MainPage : CarouselPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage" /> class
        /// </summary>
        public MainPage()
        {
            this.LoadLayout();
        }

        private void LoadLayout()
        {
            this.BackgroundImage = "background_image.png";

            for (int i = 0; i < 10; i++)
            {
                ContentPage page = new ContentPage()
                {
                    BackgroundColor = Color.Transparent
                };

                Grid grid = new Grid()
                {
                    BackgroundColor = Color.Black,
                    Opacity = 0.3,
                    VerticalOptions = new LayoutOptions(LayoutAlignment.Fill, true),
                    HorizontalOptions = new LayoutOptions(LayoutAlignment.Fill, true),
                    Margin = new Thickness(20, 25, 20, 50)
                };

                Label label = new Label()
                {
                    Text = i.ToString(),
                    VerticalOptions = new LayoutOptions(LayoutAlignment.Fill, true),
                    HorizontalOptions = new LayoutOptions(LayoutAlignment.Fill, true),
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    TextColor = Color.White,
                    FontSize = 32,
                    FontAttributes = FontAttributes.Bold
                };

                grid.Children.Add(label);
                page.Content = grid;

                this.Children.Add(page);
            }
        }
    }
}
