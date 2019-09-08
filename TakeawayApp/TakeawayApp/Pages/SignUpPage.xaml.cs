using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeawayApp.AppSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TakeawayApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private async void signUpClicked(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txt_Email.Text) & !String.IsNullOrEmpty(txt_Password.Text) & !String.IsNullOrEmpty(txt_FirstName.Text)
                       & !String.IsNullOrEmpty(txt_LastName.Text) & !String.IsNullOrEmpty(txt_PostCode.Text) & txt_Password.Text == txt_PasswordConfirm.Text)
                {
                    var order = new OrderPage();
                    await Navigation.PushAsync(order, false);
                }
                else
                {
                    await DisplayAlert("Register", "Please ensure all required fields are complete and try again", "Ok");
                }
            }
            catch (Exception)
            {

            }
        }
    }
       
}