using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStyle
{
    public class SegmentedViewModel
    {
        public SegmentedViewModel()
        {
            Days = new List<SegmentedModel>();
            Days.Add(new SegmentedModel() { Name = "Day" });
            Days.Add(new SegmentedModel() { Name = "Week" });
            Days.Add(new SegmentedModel() { Name = "Month" });
            Days.Add(new SegmentedModel() { Name = "Year" });
        }

        public List<SegmentedModel> Days
        {
            get; set;
        }
    }
}
