using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewContextAction
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewContextAction : ContentPage
    {
        public ListViewContextAction()
        {
            InitializeComponent();
            MainListView.ItemsSource = new List<string>
            {
                "mot", "hai", "ba"
            };
        }
        private void Add_Onclicked(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                string name = menuItem.BindingContext as string;
                DisplayAlert("Alert", "add" + name, "Ok");
            }

        }
        private void Minus_Onclicked(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                string name = menuItem.BindingContext as string;
                DisplayAlert("Alert", "minus" + name, "Ok");
            }

        }
        private void Delete_Onclicked(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                string name = menuItem.BindingContext as string;
                DisplayAlert("Alert", "delete" + name, "Ok");
            }

        }
    }
}