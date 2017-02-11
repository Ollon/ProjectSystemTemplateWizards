using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Microsoft.VisualStudio.ProjectSystem.Controls
{
    /// <summary>
    /// Interaction logic for VsDarkThemeTextBox.xaml
    /// </summary>
    public partial class VsDarkThemeTextBox : UserControl
    {
        public VsDarkThemeTextBox()
        {
            InitializeComponent();
            LayoutRoot.DataContext = this;
        }

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        private static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(VsDarkThemeTextBox));

        private static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string), typeof(VsDarkThemeTextBox));
    }
}
