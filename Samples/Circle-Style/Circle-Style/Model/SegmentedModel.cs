using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Style
{
    public class SegmentedModel : INotifyPropertyChanged
    {
        private Brush background;

        public Brush Background
        {
            get { return background; }
            set { background = value; OnPropertyChanged("Background"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string parameter)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(parameter));
        }
    }
}
