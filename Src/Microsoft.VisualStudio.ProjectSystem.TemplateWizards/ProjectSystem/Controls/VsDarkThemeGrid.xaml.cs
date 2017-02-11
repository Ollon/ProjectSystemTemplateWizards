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
    /// Interaction logic for VsDarkThemeGrid.xaml
    /// </summary>
    public partial class VsDarkThemeGrid : UserControl
    {
        public VsDarkThemeGrid()
        {
            InitializeComponent();
            LayoutRoot.DataContext = this;
        }


        public string Title
        {
            get { return (string) GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        private static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(VsDarkThemeGrid));

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close(false);
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Close(true);
        }


        private void Close(bool dialogResult)
        {
            Window parentWindow = Window.GetWindow(this);
            parentWindow.DialogResult = dialogResult;
            parentWindow.Close();
        }
    }
}
