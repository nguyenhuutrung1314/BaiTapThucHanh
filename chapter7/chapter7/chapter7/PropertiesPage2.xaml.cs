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
    public partial class PropertiesPage2 : ContentPage
    {
        public int Data { get; set; }
        public PropertiesPage2()
        {
            InitializeComponent();
            Data = (int)Application.Current.Properties["id"];

            this.BindingContext = this;
        }
    }
}