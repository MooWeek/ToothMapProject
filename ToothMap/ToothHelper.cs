using oda;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ToothMap
{
    public class ToothHelper
    {
        public static List<PictureBox> PictureBoxes { get; set; }

        private static xmlDocument toothMapdoc = null;

        public static List<Tooth> teethList = new List<Tooth>();

        static public void LoadTeethInfo(xmlDocument targetObjectDoc)
        {
            toothMapdoc = targetObjectDoc;

            FillToothList();
        }

        private static void FillToothList()
        {
            //foreach (xmlNode node in toothMapdoc.Root.ChildElements)
            //{
            //    using (TextReader sr = new StringReader(node.ToString()))
            //    {
            //        XmlSerializer deserializer = new XmlSerializer(typeof(Tooth), new XmlRootAttribute("Tooth"));

            //        Tooth tooth = (Tooth)deserializer.Deserialize(sr);
            //        teethList.Add(tooth);
            //    }
            //}
            teethList.Add(new Tooth() { Number = 1, Comments = "None", IsCaries = false, IsReplaced = true, Position = "Tooth1" });
            teethList.Add(new Tooth() { Number = 2, Comments = "None", IsCaries = true, IsReplaced = true, Position = "Tooth2" });
            teethList.Add(new Tooth() { Number = 3, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth3" });
            teethList.Add(new Tooth() { Number = 30, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth30" });
            teethList.Add(new Tooth() { Number = 31, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth31" });
            teethList.Add(new Tooth() { Number = 32, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth32" });
        }
    }
}
