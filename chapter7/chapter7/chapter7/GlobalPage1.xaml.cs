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
    public partial class GlobalPage1 : ContentPage
    {
        public GlobalPage1()
        {
            InitializeComponent();
            Global.Instance.myData = "12345";
        }
        protected async void Navigate(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GlobalPage2());
        }
    }
}