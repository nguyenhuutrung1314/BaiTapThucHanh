using System;
using System.Collections.Generic;
using System.Text;
using PropertyChanged;
namespace CustomControl
{
    public class MainViewModel
    {
        public double Age { get; set; } = 0;

        public double MaximumAge { get; set; } = 10;

        public MainViewModel()
        {
        }
    }
}
