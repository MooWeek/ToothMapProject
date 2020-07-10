using System.Drawing;
using System.Xml.Serialization;

namespace ToothMap
{
    public class Tooth
    {
        [XmlAttribute]
        public int IdInOda { get; set; }
        [XmlAttribute]
        public string Position { get; set; }
        [XmlAttribute]
        public int Number { get; set; }
        [XmlAttribute]
        public bool IsReplaced { get; set; }
        [XmlAttribute]
        public bool IsCaries { get; set; }
        [XmlAttribute]
        public string Comments { get; set; }
        public Bitmap Normal { get; set; }
        public Bitmap NormalHovered { get; set; }
        public Bitmap Replaced { get; set; }
        public Bitmap ReplacedHovered { get; set; }
    }
}
