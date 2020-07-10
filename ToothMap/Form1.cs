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

        #region Tooth30
        private void Tooth30_Click(object sender, EventArgs e)
        {
            ShowPripertyWindow(Tooth30);
        }
        private void Tooth30_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth30);
        }
        private void Tooth30_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth30);
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
            ShowPripertyWindow(Tooth32);
        }
        private void Tooth32_MouseEnter(object sender, EventArgs e)
        {
            ChangeImageOnMouseEnter(Tooth32);
        }
        private void Tooth32_MouseLeave(object sender, EventArgs e)
        {
            ChangeImageOnMouseLeave(Tooth32);
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
            toothPropertiesForm.Show();
        }


        #endregion
    }
}
