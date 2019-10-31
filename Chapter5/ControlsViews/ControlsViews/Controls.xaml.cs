using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlsViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Controls : ContentPage
    {
        void PickerSelectedIndexChanged(object sender, EventArgs e)
        {
            PageValue.Text = (string)ThePicker.ItemsSource[ThePicker.SelectedIndex];
        }
        void DatePickerDateSelected(object sender, DateChangedEventArgs e)
        {
            EventValue.Text = e.NewDate.ToString();
            PageValue.Text = TheDatePicker.Date.ToString();
        }
        void TimePickerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                PageValue.Text = TheTimePicker.Time.ToString();
            }
        }
        void StepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            EventValue.Text = String.Format("Stepper value is {0:F1}", e.NewValue);
            PageValue.Text = TheStepper.Value.ToString();
        }
        void SliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            EventValue.Text = String.Format("Slider value is {0:F1}",
           e.NewValue);
            PageValue.Text = TheSlider.Value.ToString();
        }
        void SwitchToggled(object sender, ToggledEventArgs e)
        {
            EventValue.Text = String.Format("Switch is now {0}", e.Value ?
           "On" : "Off");
            PageValue.Text = TheSwitch.IsToggled.ToString();
        }
        public Controls()
        {
            InitializeComponent();
        }
    }
}