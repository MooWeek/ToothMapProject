using oda;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ToothMap
{
    public partial class Form1 : Form
    {
        private static readonly Dictionary<PictureBox, Tooth> keyValuePairs = new Dictionary<PictureBox, Tooth>();


        private static readonly xmlDocument xmlDoc = null;
        //private xmlElement xmlElement;

        //private oda.Class cls = null;

        public Form1()
        {

            ToothHelper.LoadTeethInfo(xmlDoc);

            InitializeComponent();

            FillPictureBoxes();

            FillToothMap();
        }

        private void FillToothMap()
        {
            foreach(var tooth in keyValuePairs)
            {
                if (tooth.Value.IsReplaced)
                    tooth.Key.Image = Properties.Resources._1Replaced;
                else
                    tooth.Key.Image = Properties.Resources._1Normal;
            }
        }

        private void FillPictureBoxes()
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>() {
                Tooth1,
                Tooth2,
                Tooth3,
                Tooth4,
                Tooth5,
                Tooth6,
                Tooth7,
                Tooth8,
                Tooth9,
                Tooth10,
                Tooth11,
                Tooth12,
                Tooth13,
                Tooth14,
                Tooth15,
                Tooth16,
                Tooth17,
                Tooth18,
                Tooth19,
                Tooth20,
                Tooth21,
                Tooth22,
                Tooth23,
                Tooth24,
                Tooth25,
                Tooth26,
                Tooth27,
                Tooth28,
                Tooth29,
                Tooth30,
                Tooth31,
                Tooth32
            };

            foreach(var box in pictureBoxes)
            {
                foreach (var tooth in ToothHelper.teethList)
                {
                    if(box.Name == tooth.Position)
                    {
                        if (tooth.Number > 16) 
                        {
                            tooth.Normal = RotateBitmap(Properties.Resources._1Normal);
                            tooth.NormalHovered = RotateBitmap(Properties.Resources._1Hover);
                            tooth.Replaced = RotateBitmap(Properties.Resources._1Replaced);
                            tooth.ReplacedHovered = RotateBitmap(Properties.Resources._1ReplacedHover);
                        }
                        else
                        {
                            tooth.Normal = Properties.Resources._1Normal;
                            tooth.NormalHovered = Properties.Resources._1Hover;
                            tooth.Replaced = Properties.Resources._1Replaced;
                            tooth.ReplacedHovered = Properties.Resources._1ReplacedHover;
                        }
                        keyValuePairs.Add(box, tooth);
                    }
                }
            }
        }

        private Bitmap RotateBitmap(Bitmap bitmap)
        {
            Bitmap bmp = new Bitmap(bitmap.Width, bitmap.Height);

            Graphics gfx = Graphics.FromImage(bmp);

            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            gfx.RotateTransform(180);
            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(bitmap, new Point(0, 0));

            return bmp;
        }

        #region Tooth Events


        #region Tooth1
        private void Tooth1_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth1);
        }
        private void Tooth1_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth1);
        }
        private void Tooth1_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth1);
        }
        #endregion

        #region Tooth2
        private void Tooth2_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth2);
        }
        private void Tooth2_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth2);
        }
        private void Tooth2_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth2);
        }
        #endregion

        #region Tooth3
        private void Tooth3_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth3);
        }
        private void Tooth3_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth3);
        }
        private void Tooth3_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth3);
        }
        #endregion

        #region Tooth4
        private void Tooth4_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth4);
        }
        private void Tooth4_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth4);
        }
        private void Tooth4_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth4);
        }
        #endregion

        #region Tooth5
        private void Tooth5_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth5);
        }
        private void Tooth5_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth5);
        }
        private void Tooth5_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth5);
        }
        #endregion

        #region Tooth6
        private void Tooth6_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth6);
        }
        private void Tooth6_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth6);
        }
        private void Tooth6_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth6);
        }
        #endregion

        #region Tooth7
        private void Tooth7_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth7);
        }
        private void Tooth7_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth7);
        }
        private void Tooth7_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth7);
        }
        #endregion

        #region Tooth8
        private void Tooth8_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth8);
        }
        private void Tooth8_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth8);
        }
        private void Tooth8_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth8);
        }
        #endregion

        #region Tooth9
        private void Tooth9_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth9);
        }
        private void Tooth9_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth9);
        }
        private void Tooth9_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth9);
        }
        #endregion

        #region Tooth10
        private void Tooth10_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth10);
        }
        private void Tooth10_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth10);
        }
        private void Tooth10_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth10);
        }
        #endregion

        #region Tooth11
        private void Tooth11_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth11);
        }
        private void Tooth11_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth11);
        }
        private void Tooth11_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth11);
        }
        #endregion

        #region Tooth12
        private void Tooth12_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth12);
        }
        private void Tooth12_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth12);
        }
        private void Tooth12_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth12);
        }
        #endregion

        #region Tooth13
        private void Tooth13_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth13);
        }
        private void Tooth13_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth13);
        }
        private void Tooth13_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth13);
        }
        #endregion

        #region Tooth14
        private void Tooth14_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth14);
        }
        private void Tooth14_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth14);
        }
        private void Tooth14_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth14);
        }
        #endregion

        #region Tooth15
        private void Tooth15_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth15);
        }
        private void Tooth15_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth15);
        }
        private void Tooth15_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth15);
        }
        #endregion

        #region Tooth16
        private void Tooth16_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth16);
        }
        private void Tooth16_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth16);
        }
        private void Tooth16_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth16);
        }
        #endregion

        #region Tooth17
        private void Tooth17_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth17);
        }
        private void Tooth17_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth17);
        }
        private void Tooth17_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth17);
        }
        #endregion

        #region Tooth18
        private void Tooth18_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth18);
        }
        private void Tooth18_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth18);
        }
        private void Tooth18_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth18);
        }
        #endregion

        #region Tooth19
        private void Tooth19_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth19);
        }
        private void Tooth19_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth19);
        }
        private void Tooth19_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth19);
        }
        #endregion

        #region Tooth20
        private void Tooth20_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth20);
        }
        private void Tooth20_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth20);
        }
        private void Tooth20_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth20);
        }
        #endregion 

        #region Tooth21
        private void Tooth21_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth21);
        }
        private void Tooth21_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth21);
        }
        private void Tooth21_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth21);
        }
        #endregion

        #region Tooth22
        private void Tooth22_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth22);
        }
        private void Tooth22_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth22);
        }
        private void Tooth22_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth22);
        }
        #endregion

        #region Tooth23
        private void Tooth23_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth23);
        }
        private void Tooth23_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth23);
        }
        private void Tooth23_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth23);
        }
        #endregion

        #region Tooth24
        private void Tooth24_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth24);
        }
        private void Tooth24_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth24);
        }
        private void Tooth24_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth24);
        }
        #endregion

        #region Tooth25
        private void Tooth25_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth25);
        }
        private void Tooth25_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth25);
        }
        private void Tooth25_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth25);
        }
        #endregion

        #region Tooth26
        private void Tooth26_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth26);
        }
        private void Tooth26_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth26);
        }
        private void Tooth26_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth26);
        }
        #endregion

        #region Tooth27
        private void Tooth27_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth27);
        }
        private void Tooth27_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth27);
        }
        private void Tooth27_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth27);
        }
        #endregion

        #region Tooth28
        private void Tooth28_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth28);
        }
        private void Tooth28_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth28);
        }
        private void Tooth28_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth28);
        }
        #endregion

        #region Tooth29
        private void Tooth29_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth29);
        }
        private void Tooth29_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth29);
        }
        private void Tooth29_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth29);
        }
        #endregion

        #region Tooth30
        private void Tooth30_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth32);
        }
        private void Tooth30_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth32);
        }
        private void Tooth30_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth32);
        }
        #endregion

        #region Tooth31
        private void Tooth31_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth31);
        }
        private void Tooth31_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth31);
        }
        private void Tooth31_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth31);
        }
        #endregion

        #region Tooth32
        private void Tooth32_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth30);
        }
        private void Tooth32_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth30);
        }
        private void Tooth32_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth30);
        }
        #endregion


        #endregion


        #region General Tooth Events


        private void ChangeImageOnMouseEnter(PictureBox tooth)
        {
            if (keyValuePairs[tooth].IsReplaced)
                tooth.Image = keyValuePairs[tooth].ReplacedHovered;
            else
                tooth.Image = keyValuePairs[tooth].NormalHovered;
        }

        private void ChangeImageOnMouseLeave(PictureBox tooth)
        {
            if (keyValuePairs[tooth].IsReplaced)
                tooth.Image = keyValuePairs[tooth].Replaced;
            else
                tooth.Image = keyValuePairs[tooth].Normal;
        }

        private void ShowPripertyWindow(PictureBox tooth)
        {
            ToothPropertiesForm toothPropertiesForm = new ToothPropertiesForm(keyValuePairs[tooth]);
            toothPropertiesForm.ShowDialog();
            
        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var tooth in keyValuePairs)
            {
                ChangeImageOnMouseLeave(tooth.Key);
            }
        }
    }
}
