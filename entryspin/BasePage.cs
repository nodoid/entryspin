using Xamarin.Forms;

namespace entryspin
{
    public class BasePage : ContentPage
    {
        public BasePage()
        {
            if (Device.RuntimePlatform == Device.iOS)
                Padding = new Thickness(0, 20);
            BackgroundColor = Color.White;
        }
    }
}


