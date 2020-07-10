namespace ToothMap
{
    partial class ToothPropertiesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveButton = new System.Windows.Forms.Button();
            this.ToothReplacedLabel = new System.Windows.Forms.Label();
            this.ToothReplacedCheckBox = new System.Windows.Forms.CheckBox();
            this.ToothCariesCheckBox = new System.Windows.Forms.CheckBox();
            this.ToothCariesLabel = new System.Windows.Forms.Label();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.CommentsTextBox = new System.Windows.Forms.TextBox();
            this.ToothNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(326, 26);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(132, 45);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save and Exit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ToothReplacedLabel
            // 
            this.ToothReplacedLabel.AutoSize = true;
            this.ToothReplacedLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToothReplacedLabel.Location = new System.Drawing.Point(12, 58);
            this.ToothReplacedLabel.Name = "ToothReplacedLabel";
            this.ToothReplacedLabel.Size = new System.Drawing.Size(153, 26);
            this.ToothReplacedLabel.TabIndex = 1;
            this.ToothReplacedLabel.Text = "Tooth Replaced";
            // 
            // ToothReplacedCheckBox
            // 
            this.ToothReplacedCheckBox.AutoSize = true;
            this.ToothReplacedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ToothReplacedCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToothReplacedCheckBox.Location = new System.Drawing.Point(171, 59);
            this.ToothReplacedCheckBox.Name = "ToothReplacedCheckBox";
            this.ToothReplacedCheckBox.Size = new System.Drawing.Size(60, 27);
            this.ToothReplacedCheckBox.TabIndex = 2;
            this.ToothReplacedCheckBox.Text = "Yes";
            this.ToothReplacedCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToothCariesCheckBox
            // 
            this.ToothCariesCheckBox.AutoSize = true;
            this.ToothCariesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ToothCariesCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToothCariesCheckBox.Location = new System.Drawing.Point(171, 98);
            this.ToothCariesCheckBox.Name = "ToothCariesCheckBox";
            this.ToothCariesCheckBox.Size = new System.Drawing.Size(60, 27);
            this.ToothCariesCheckBox.TabIndex = 4;
            this.ToothCariesCheckBox.Text = "Yes";
            this.ToothCariesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToothCariesLabel
            // 
            this.ToothCariesLabel.AutoSize = true;
            this.ToothCariesLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToothCariesLabel.Location = new System.Drawing.Point(12, 97);
            this.ToothCariesLabel.Name = "ToothCariesLabel";
            this.ToothCariesLabel.Size = new System.Drawing.Size(127, 26);
            this.ToothCariesLabel.TabIndex = 3;
            this.ToothCariesLabel.Text = "Tooth Caries";
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentsLabel.Location = new System.Drawing.Point(346, 108);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(110, 26);
            this.CommentsLabel.TabIndex = 5;
            this.CommentsLabel.Text = "Comments";
            // 
            // CommentsTextBox
            // 
            this.CommentsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.CommentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentsTextBox.Location = new System.Drawing.Point(17, 137);
            this.CommentsTextBox.Multiline = true;
            this.CommentsTextBox.Name = "CommentsTextBox";
            this.CommentsTextBox.Size = new System.Drawing.Size(441, 162);
            this.CommentsTextBox.TabIndex = 6;
            // 
            // ToothNumber
            // 
            this.ToothNumber.AutoSize = true;
            this.ToothNumber.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToothNumber.Location = new System.Drawing.Point(12, 9);
            this.ToothNumber.Name = "ToothNumber";
            this.ToothNumber.Size = new System.Drawing.Size(208, 28);
            this.ToothNumber.TabIndex = 7;
            this.ToothNumber.Text = "Position of Tooth is ";
            // 
            // ToothPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(468, 311);
            this.Controls.Add(this.ToothNumber);
            this.Controls.Add(this.CommentsTextBox);
            this.Controls.Add(this.CommentsLabel);
            this.Controls.Add(this.ToothCariesCheckBox);
            this.Controls.Add(this.ToothCariesLabel);
            this.Controls.Add(this.ToothReplacedCheckBox);
            this.Controls.Add(this.ToothReplacedLabel);
            this.Controls.Add(this.SaveButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToothPropertiesForm";
            this.ShowIcon = false;
            this.Text = "Tooth properties for";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToothPropertiesForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label ToothReplacedLabel;
        private System.Windows.Forms.CheckBox ToothReplacedCheckBox;
        private System.Windows.Forms.CheckBox ToothCariesCheckBox;
        private System.Windows.Forms.Label ToothCariesLabel;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.TextBox CommentsTextBox;
        private System.Windows.Forms.Label ToothNumber;
    }
}