using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disable_Items
{
    public class SegmentedModel : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string parameter)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(parameter));
        }
    }
}
