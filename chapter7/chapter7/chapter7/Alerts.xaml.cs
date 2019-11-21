using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace chapter7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alerts : ContentPage
    {
        public Alerts()
        {
            InitializeComponent();
        }
        protected async void ShowAlert(object sender, EventArgs args)
        {
            await DisplayAlert("Hey", "You really should know about this.", "OK");
        }
    }
}