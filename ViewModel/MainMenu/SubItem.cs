using MaterialDesignThemes.Wpf;
using System.Windows.Controls;

namespace MonkeyCRM.View.ViewModel.MainMenu
{
    public class SubItem
    {
        public SubItem(string name, PackIconKind icon,UserControl screen = null)
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