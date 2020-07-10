using System;
using System.Windows.Forms;

namespace ToothMap
{
    public partial class ToothPropertiesForm : Form
    {
        private readonly Tooth tooth;

        public ToothPropertiesForm(Tooth tooth) : base()
        {
            this.tooth = tooth;

            InitializeComponent();
            Text = "Tooth properties for " + tooth.Number.ToString() + " Tooth";
            LoadToothProperties();
        }

        private void LoadToothProperties()
        {
            ToothReplacedCheckBox.Checked = tooth.IsReplaced;
            ToothCariesCheckBox.Checked = tooth.IsCaries;
            CommentsTextBox.Text = tooth.Comments;
            ToothNumber.Text = "Position of Tooth is " + tooth.Number.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            tooth.IsReplaced = ToothReplacedCheckBox.Checked;
            tooth.IsCaries = ToothCariesCheckBox.Checked;
            tooth.Comments = CommentsTextBox.Text;
            Close();
        }

        private void ToothPropertiesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ToothReplacedCheckBox.Checked != tooth.IsReplaced || ToothCariesCheckBox.Checked != tooth.IsCaries || CommentsTextBox.Text != tooth.Comments)
            {
                var result = MessageBox.Show("Discard changes?", "Closing", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
