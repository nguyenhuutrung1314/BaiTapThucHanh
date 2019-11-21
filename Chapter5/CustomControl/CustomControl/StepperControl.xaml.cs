using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControl
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StepperControl : ContentView
	{
        // BindableProperty.Create (ten bien, kieu du lieu, trong file nao, gia tri mac dinh, kieu truy xuat du lieu, su kien thay gia tri)
        public static readonly BindableProperty NumericProperty = BindableProperty.Create("Numeric",
                                                                        typeof(double),
                                                                        typeof(StepperControl),
                                                                        0.0,
                                                                        BindingMode.TwoWay,
                                                                        propertyChanged: NumericValueChanged);
        public static readonly BindableProperty MaxValueProperty = BindableProperty.Create("MaxValue",
                                                                        typeof(double),
                                                                        typeof(StepperControl),
                                                                        0.0,
                                                                        BindingMode.TwoWay,
                                                                        propertyChanged: MaxValueChanged);
        // nut click thi bien numeric duoc xu li
        void ButtonMinus_Clicked(object o, System.EventArgs e)
        {
            if (Numeric > 0)
            {
                Numeric -= 1;
            }
        }

        void ButtonPlus_Clicked(object o, System.EventArgs e)
        {
            if (Numeric < MaxValue)
            {
                Numeric += 1;
            }
        }
        public StepperControl()
        {
            InitializeComponent();
        }

        public double Numeric
        {
            get { return (double)GetValue(NumericProperty); }
            set { SetValue(NumericProperty, value); }
        }
        public double MaxValue
        {
            get { return (double)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }
        private static void NumericValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as StepperControl).NumericLabel.Text = Convert.ToString(newValue);
        }

        private static void MaxValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
        }
    }
}