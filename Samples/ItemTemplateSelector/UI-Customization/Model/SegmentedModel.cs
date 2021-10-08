using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Customization
{
    public class SegmentedModel : INotifyPropertyChanged
    {
        private string name;


        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }


        private string icon;
        public string Icon
        {
            get { return icon; }
            set { icon = value; OnPropertyChanged("Icon"); }
        }

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
