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
    public partial class DropdownMenu : ContentPage
    {
        public DropdownMenu()
        {
            InitializeComponent();
        }
        protected async void Navigate(object sender, EventArgs args)
        {

            string type = (string)((ToolbarItem)sender).CommandParameter;
            Type pageType = Type.GetType("chapter7." + type + ", chapter7");
            Page page = (Page)Activator.CreateInstance(pageType);
            await this.Navigation.PushAsync(page);

        }
    }
}