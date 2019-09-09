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
	public partial class OrderPage : ContentPage
	{
		public OrderPage ()
		{
            dateSelect.MinimumDate = DateTime.Now;
            dateSelect.MaximumDate = DateTime.Now;
            InitializeComponent ();
        }

        public void closePage(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            
        }

    }
}