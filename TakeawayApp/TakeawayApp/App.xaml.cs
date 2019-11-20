using Firebase.Database;
using System;
using System.Threading.Tasks;
using TakeawayApp.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TakeawayApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var auth = "npzqMqmacXosF2j9IGZzeRzT1QFI2jbQiT4pQJL7"; // your app secret
            var firebaseClient = new FirebaseClient(
              "https://takeawayapp-53254.firebaseio.com/",
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(auth)
              });

            MainPage = new NavigationPage(new LoginPage());
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
