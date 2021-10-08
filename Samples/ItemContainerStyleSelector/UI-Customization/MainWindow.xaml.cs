using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SelectionStyle;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace UI_Customization
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }
    }

    public class RatingStyleSelector : StyleSelector
    {
        public Style AverageRatingStyle { get; set; }
        public Style DefaultStyle { get; set; }
        protected override Style SelectStyleCore(object item, DependencyObject container)
        {
            if (item == null)
                return null;
            if ((item as SegmentedModel).Rating == "Poor")
                return AverageRatingStyle;
            else
                return DefaultStyle;
        }
    }
}
