using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
        }
        private void Cmdmot_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Behaviors());

        }

        private void Cmdhai_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controls());

        }
        private void Cmdba_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagThemLoaiHoa());

        }
        private void Cmdbon_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagThemLoaiHoa());

        }
    }
}
