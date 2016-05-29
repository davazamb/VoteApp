using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoteApp.Classes;
using Xamarin.Forms;

namespace VoteApp.Pages
{
    public partial class HomePage : ContentPage
    {
        private UserPassword user;
        public HomePage(UserPassword user)
        {
            InitializeComponent();

            this.user = user;
            this.Padding = Device.OnPlatform(
                new Thickness(10, 20, 10, 10),
                new Thickness(10),
                new Thickness(10));

            userNameLabel.Text = user.FullName;
            if (!string.IsNullOrEmpty(user.Photo))
            {
                photoImage.Source = string.Format("http://votar.somee.com/{0}", user.Photo.Substring(1));
            }
            photoImage.HeightRequest = 280;
            photoImage.WidthRequest = 280;

            mySettingsButton.Clicked += MySettingsButton_Clicked;
        }

        private async void MySettingsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MySettingsPage(this.user));
        }


    }
}
