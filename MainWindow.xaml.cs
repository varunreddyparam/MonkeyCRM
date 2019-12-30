using MaterialDesignThemes.Wpf;
using MonkeyCRM.View.ViewModel.MainMenu;
using MonkeyCRM.View;
using MonkeyCRM.View.ViewModel.SubMenu;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace MonkeyCRM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //ConstructMenu();
            //ConstructSubMenuBarItem();
            //ButtonCloseMenu.Visibility = Visibility.Visible;
            //ButtonOpenMenu.Visibility = Visibility.Collapsed;
            GridMenu.Width = 220;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationFrame.NavigationService.Navigate(new DashBoard());
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridTopMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        //private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        //{
        //    ButtonOpenMenu.Visibility = Visibility.Visible;
        //    ButtonCloseMenu.Visibility = Visibility.Collapsed;
        //    ColumnPageContainer.Width = new GridLength(1, GridUnitType.Star);
        //}

        //private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        //{
        //    ButtonCloseMenu.Visibility = Visibility.Visible;
        //    ButtonOpenMenu.Visibility = Visibility.Collapsed;
        //}

        private RootMenu Deserializexml()
        {
            RootMenu rootMenu = new RootMenu();
            using (var stream =
               new FileStream("MenuItem.xml", FileMode.Open, FileAccess.Read))
            {
                string path = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                path = System.IO.Path.Combine(path, "MenuItem.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(RootMenu));

                StreamReader reader = new StreamReader(path);
                rootMenu = (RootMenu)serializer.Deserialize(reader);
                reader.Close();
            }
            return rootMenu;
        }

        private void ConstructMenu()
        {
            List<SubItem> subItems = new List<SubItem>();
            var item0 = new ItemMenu("Home", new UserControl());
            MenuUserControl.Children.Add(new UserControlMenuItem(item0));
            var rootMenu = Deserializexml();
            foreach (var item in rootMenu.ItemMenus)
            {
                foreach (var subitem in item.SubItems)
                {
                    subItems.Add(new SubItem(subitem.Name, (PackIconKind)Convert.ToInt32(subitem.PackIconKind)));
                }
                var menuItem = new ItemMenu(item.Header, subItems);
                MenuUserControl.Children.Add(new UserControlMenuItem(menuItem));
            }
        }


        //private SubMenu ConstructSubMenuDeserialize()
        //{
        //    SubMenu subMenu = new SubMenu();
        //    using (var stream =
        //       new FileStream("SubMenuItem.xml", FileMode.Open, FileAccess.Read))
        //    {
        //        string path = System.Environment.GetFolderPath(
        //            System.Environment.SpecialFolder.Personal);
        //        path = System.IO.Path.Combine(path, "SubMenuItem.xml");

        //        XmlSerializer serializer = new XmlSerializer(typeof(SubMenu));

        //        StreamReader reader = new StreamReader(path);
        //        subMenu = (SubMenu)serializer.Deserialize(reader);
        //        reader.Close();
        //    }
        //    return subMenu;
        //}

        //private void ConstructSubMenuBarItem()
        //{
        //    var subMenu = ConstructSubMenuDeserialize();
        //    foreach (var subitem in subMenu.SubMenuItems)
        //    {
        //        UserControlToolBar.Children.Add(new EditMenuUserControl(new SubMenuButton(subitem.Name, (PackIconKind)Convert.ToInt32(subitem.PackIconKind))));
        //    }
        //}
    }
}
