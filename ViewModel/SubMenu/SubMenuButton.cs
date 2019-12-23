using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;

namespace MonkeyCRM.View.ViewModel.SubMenu
{
    public class SubMenuButton
    {
        public SubMenuButton(string name, PackIconKind icon ,UserControl screen = null)
        {
            Name = name;
            Icon = icon;
            Screen = screen;
        }
        public string Name { get; private set; }

        public PackIconKind Icon { get; private set; }
        public UserControl Screen { get; private set; }
    }
}
