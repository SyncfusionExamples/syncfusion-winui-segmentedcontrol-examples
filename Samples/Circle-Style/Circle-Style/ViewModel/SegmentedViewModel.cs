using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Style
{
    public class SegmentedViewModel
    {
        public SegmentedViewModel()
        {
            Colors = new List<SegmentedModel>();
            Colors.Add(new SegmentedModel() { Background = new SolidColorBrush(Microsoft.UI.Colors.LightGreen) });
            Colors.Add(new SegmentedModel() { Background = new SolidColorBrush(Microsoft.UI.Colors.Red) });
            Colors.Add(new SegmentedModel() { Background = new SolidColorBrush(Microsoft.UI.Colors.OrangeRed) });
            Colors.Add(new SegmentedModel() { Background = new SolidColorBrush(Microsoft.UI.Colors.DarkGreen) });
            Colors.Add(new SegmentedModel() { Background = new SolidColorBrush(Microsoft.UI.Colors.DarkBlue) });
            Colors.Add(new SegmentedModel() { Background = new SolidColorBrush(Microsoft.UI.Colors.Maroon) });
            Colors.Add(new SegmentedModel() { Background = new SolidColorBrush(Microsoft.UI.Colors.DeepSkyBlue) });
        }

        public List<SegmentedModel> Colors
        {
            get; set;
        }
    }
}
