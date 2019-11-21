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
    public partial class PropertiesPage1 : ContentPage
    {
        public PropertiesPage1()
        {
            InitializeComponent();
            Application.Current.Properties["id"] = 12345;
        }
        protected async void Navigate(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PropertiesPage2());
        }
    }
}