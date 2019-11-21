using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewsScroll
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViews_Scroll : ContentPage
    {
        public ListViews_Scroll()
        {
            InitializeComponent();
            List<string> Items = new List<string>
             {
             "First",
             "Second",
             "Third",
             "Fourth",
            "Fifth",
             "Sixth", 
             "Seventh", 
            "Eighth",
              "Ninth", 
              "Tenth", 
              "Eleventh", 
             "Twelfth", 
              "Thirteenth", 
             "Fourteenth", 
            "Fifteenth", 
             "Sixteenth", 
            "Seventeenth", 
            "Eighteenth"
            };
            BindingContext = Items;
        }
        async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            string item = (string)e.Item;
            await DisplayAlert("Tapped", item + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }
        async void ListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string item = (string)e.SelectedItem;
            await DisplayAlert("Selected", item + " was selected.", "OK");
        }
    }
}