using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TakeawayApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartUpPage : ContentPage
	{
		public StartUpPage ()
		{
			InitializeComponent ();
		}

        public async void loginBtnClicked(object sender, EventArgs e)
        {
            var loginPage = new Pages.LoginPage();
            await Navigation.PushAsync(loginPage, false);
        }

        public async void signUpBtnClicked(object sender, EventArgs e)
        {
            var signupPage = new Pages.SignUpPage();
            await Navigation.PushAsync(signupPage, false);
        }

        public async void guestBtnClicked(object sender, EventArgs e)
        {
            var orderasguestPage = new Pages.OrderAsGuestPage();
            await Navigation.PushAsync(orderasguestPage, false);
        }
    }
}