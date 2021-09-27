using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellipse_Style
{
    public class SegmentedViewModel
    {
        public SegmentedViewModel()
        {
            Backlight = new List<SegmentedModel>();
            Backlight.Add(new SegmentedModel() { Name = "Backlight On" });
            Backlight.Add(new SegmentedModel() { Name = "Backlight Off" });
        }

        public List<SegmentedModel> Backlight
        {
            get; set;
        }
    }
}
