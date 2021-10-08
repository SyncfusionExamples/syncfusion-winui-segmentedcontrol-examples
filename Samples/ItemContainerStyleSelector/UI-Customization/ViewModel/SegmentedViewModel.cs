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
            Days.Add(new SegmentedModel() { Name = "Day",Rating="Poor" });
            Days.Add(new SegmentedModel() { Name = "Week" , Rating = "Avarage" });
            Days.Add(new SegmentedModel() { Name = "Month", Rating = "Good" });
            Days.Add(new SegmentedModel() { Name = "Year", Rating = "Poor" });
        }

        public List<SegmentedModel> Days
        {
            get; set;
        }
    }
}
