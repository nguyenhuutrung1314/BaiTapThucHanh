using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using chapter8.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("chapter8")]
[assembly: ExportEffect(typeof(DroidTextValidatorEffect),"TextValidatorEffect")]
namespace chapter8.Droid
{
    public class DroidTextValidatorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Validate();
        }
        protected override void OnDetached() { }
        protected override void
        OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            if (args.PropertyName == "Text") Validate();
        }
        private void Validate()
        {
            var entry = Element as Entry;
            var view = Control as EditText;
            var effect = (TextValidatorEffect)Element.Effects.FirstOrDefault(
            e => e is TextValidatorEffect);
            if (entry.Text.Length > effect.MaxLength)
            {
                view.SetBackgroundColor(Color.Maroon.ToAndroid());
            }
            else
            {
                view.SetBackgroundColor(Color.Lime.ToAndroid());
            }
        }
    }
}