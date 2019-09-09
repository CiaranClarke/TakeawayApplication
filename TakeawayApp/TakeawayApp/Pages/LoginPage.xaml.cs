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
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
            NavigationPage.SetHasNavigationBar(this, true);
            InitializeComponent ();

            txt_Email.Completed += (s, e) => txt_Password.Focus();
            txt_Password.Completed += (s, e) => loginBtnClicked(null, null);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            txt_Email.Text = "";
            txt_Password.Text = "";
        }

        public async void loginBtnClicked(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(txt_Email.Text) & !String.IsNullOrEmpty(txt_Password.Text))
                {
                    var order = new OrderPage();
                    await Navigation.PushAsync(order, false);
                }
                else
                {
                    await DisplayAlert("Login", "Email address or password are not valid, please try again.", "Ok");
                }
            }
            catch(Exception)
            {

            }
        }

        public void OnPasswordRecoveryTapped(object sender, EventArgs e)
        {

        }

    }
}