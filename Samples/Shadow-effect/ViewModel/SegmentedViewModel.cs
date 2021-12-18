using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow_effect
{
    public class SegmentedViewModel
    {
        public SegmentedViewModel()
        {
            ShirtModels = new List<SegmentedModel>();
            ShirtModels.Add(new SegmentedModel() { Name = "Formals" });
            ShirtModels.Add(new SegmentedModel() { Name = "Casuals" });
            ShirtModels.Add(new SegmentedModel() { Name = "Trendy" });
        }

        public List<SegmentedModel> ShirtModels
        {
            get; set;
        }
    }
}
