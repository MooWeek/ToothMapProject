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
            teethList.Add(new Tooth() { Number = 1, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth1" });
            teethList.Add(new Tooth() { Number = 2, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth2" });
            teethList.Add(new Tooth() { Number = 3, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth3" });
            teethList.Add(new Tooth() { Number = 4, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth4" });
            teethList.Add(new Tooth() { Number = 5, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth5" });
            teethList.Add(new Tooth() { Number = 6, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth6" });
            teethList.Add(new Tooth() { Number = 7, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth7" });
            teethList.Add(new Tooth() { Number = 8, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth8" });
            teethList.Add(new Tooth() { Number = 9, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth9" });
            teethList.Add(new Tooth() { Number = 10, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth10" });
            teethList.Add(new Tooth() { Number = 11, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth11" });
            teethList.Add(new Tooth() { Number = 12, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth12" });
            teethList.Add(new Tooth() { Number = 13, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth13" });
            teethList.Add(new Tooth() { Number = 14, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth14" });
            teethList.Add(new Tooth() { Number = 15, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth15" });
            teethList.Add(new Tooth() { Number = 16, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth16" });
            teethList.Add(new Tooth() { Number = 17, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth17" });
            teethList.Add(new Tooth() { Number = 18, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth18" });
            teethList.Add(new Tooth() { Number = 19, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth19" });
            teethList.Add(new Tooth() { Number = 20, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth20" });
            teethList.Add(new Tooth() { Number = 21, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth21" });
            teethList.Add(new Tooth() { Number = 22, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth22" });
            teethList.Add(new Tooth() { Number = 23, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth23" });
            teethList.Add(new Tooth() { Number = 24, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth24" });
            teethList.Add(new Tooth() { Number = 25, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth25" });
            teethList.Add(new Tooth() { Number = 26, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth26" });
            teethList.Add(new Tooth() { Number = 27, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth27" });
            teethList.Add(new Tooth() { Number = 28, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth28" });
            teethList.Add(new Tooth() { Number = 29, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth29" });
            teethList.Add(new Tooth() { Number = 30, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth30" });
            teethList.Add(new Tooth() { Number = 31, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth31" });
            teethList.Add(new Tooth() { Number = 32, Comments = "None", IsCaries = false, IsReplaced = false, Position = "Tooth32" });
        }
    }
}
