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
            Items = new List<SegmentedModel>();
            Items.Add(new SegmentedModel() { Name = "Backlight On" });
            Items.Add(new SegmentedModel() { Name = "Backlight Off" });
        }

        public List<SegmentedModel> Items
        {
            get; set;
        }
    }
}
