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
    public partial class Springboard : ContentPage
    {
        public Springboard()
        {
            InitializeComponent();
            var tapFirst = new TapGestureRecognizer();
            tapFirst.Tapped += async (s, e) =>
            {
                await this.Navigation.PushAsync(new FirstPage());
            };
            FirstImage.GestureRecognizers.Add(tapFirst);

            var tapSecond = new TapGestureRecognizer();
            tapSecond.Tapped += async (s, e) =>
            {
                await this.Navigation.PushAsync(new SecondPage());
            };
            SecondImage.GestureRecognizers.Add(tapSecond);

            var tapThird = new TapGestureRecognizer();
            tapThird.Tapped += async (s, e) =>
            {
                await this.Navigation.PushAsync(new ThirdPage());
            };
            ThirdImage.GestureRecognizers.Add(tapThird);
        }
    }
}