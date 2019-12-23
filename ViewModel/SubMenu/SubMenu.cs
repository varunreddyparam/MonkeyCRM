using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MonkeyCRM.View.ViewModel.SubMenu
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("SubMenu")]
    public class SubMenu
    {
        [XmlElement(ElementName = "SubMenuItem")]
        public List<SubMenuItem> SubMenuItems { get; set; }
    }

    public class SubMenuItem
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "packiconkind")]
        public string PackIconKind { get; set; }
    }
}
