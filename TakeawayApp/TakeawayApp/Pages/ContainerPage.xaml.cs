using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;


namespace TakeawayApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContainerPage : Xamarin.Forms.TabbedPage
    {
		public ContainerPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            this.On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);
            var homePage = new NavigationPage(new HomePage());
            homePage.IconImageSource = "homeIcon.png";

            var menuPage = new NavigationPage(new MenuPage());
            menuPage.IconImageSource = "menuIcon.png";

            var settingsPage = new NavigationPage(new SettingsPage());
            settingsPage.IconImageSource = "settingsIcon.png";


            Children.Add(homePage);
            Children.Add(menuPage);
            Children.Add(settingsPage);

            InitializeComponent ();

		}
	}
}