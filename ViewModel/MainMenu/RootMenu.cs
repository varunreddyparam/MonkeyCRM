using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MonkeyCRM.View.ViewModel.MainMenu
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("RootMenu")]
    public class RootMenu
    {
        [XmlElement(ElementName = "itemmenu")]
        public List<ItemMenus> ItemMenus { get; set; }
    }

    [XmlRoot(ElementName = "subItem")]
    public class SubItems
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "screen")]
        public string Screen { get; set; }
        [XmlElement(ElementName = "packiconkind")]
        public string PackIconKind { get; set; }
    }

    [XmlRoot(ElementName = "itemmenu")]
    public class ItemMenus
    {
        [XmlElement(ElementName = "header")]
        public string Header { get; set; }
        [XmlElement(ElementName = "screen")]
        public string Screen { get; set; }
        [XmlElement(ElementName = "subitem")]
        public List<SubItems> SubItems { get; set; }
    }
}
