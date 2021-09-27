using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
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

            StringCollection = new List<string>();
            StringCollection.Add("Day");
            StringCollection.Add("Week");
            StringCollection.Add("Month");
            StringCollection.Add("Year");
        }

        public List<SegmentedModel> Days
        {
            get; set;
        }

        public List<string> StringCollection
        {
            get; set;
        }
    }
}
