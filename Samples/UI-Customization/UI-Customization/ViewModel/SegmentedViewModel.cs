using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Customization
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

            ShirtModels = new List<SegmentedModel>();
            ShirtModels.Add(new SegmentedModel() { Name = "Formals" });
            ShirtModels.Add(new SegmentedModel() { Name = "Casuals" });
            ShirtModels.Add(new SegmentedModel() { Name = "Trendy" });
        }

        public List<SegmentedModel> Days
        {
            get; set;
        }

        public List<SegmentedModel> ShirtModels
        {
            get; set;
        }
    }
}
