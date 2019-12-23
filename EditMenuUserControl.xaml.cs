using MonkeyCRM.View.ViewModel.SubMenu;
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

namespace MonkeyCRM
{
    /// <summary>
    /// Interaction logic for EditMenuUserControl.xaml
    /// </summary>
    public partial class EditMenuUserControl : UserControl
    {
        public EditMenuUserControl(SubMenuButton subMenuButton)
        {
            InitializeComponent();
            this.DataContext = subMenuButton;
        }

        private void CRMToolBarTray_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)e.OriginalSource;
        }
    }
}
