using System;
using System.Collections;
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
    /// Interaction logic for VsDarkThemeComboBox.xaml
    /// </summary>
    public partial class VsDarkThemeComboBox : UserControl
    {
        public VsDarkThemeComboBox()
        {
            InitializeComponent();
            LayoutRoot.DataContext = this;
        }

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public object SelectedItem
        {
            get { return GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }


        private static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(VsDarkThemeComboBox));

        private static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(VsDarkThemeComboBox));

        private static readonly DependencyProperty SelectedItemProperty =
    DependencyProperty.Register("SelectedItem", typeof(object), typeof(VsDarkThemeComboBox));
    }
}
