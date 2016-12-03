namespace QualInstitute.UI
{
    partial class AddSpeciality
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxStudyingTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTimesAtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxHostel = new System.Windows.Forms.CheckBox();
            this.buttonAddSpec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва спеціальності";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(129, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 134);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // textBoxStudyingTime
            // 
            this.textBoxStudyingTime.Location = new System.Drawing.Point(129, 58);
            this.textBoxStudyingTime.Name = "textBoxStudyingTime";
            this.textBoxStudyingTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudyingTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Срок навчання";
            // 
            // textBoxTimesAtYear
            // 
            this.textBoxTimesAtYear.Location = new System.Drawing.Point(129, 84);
            this.textBoxTimesAtYear.Name = "textBoxTimesAtYear";
            this.textBoxTimesAtYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimesAtYear.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "К-сть за рік";
            // 
            // checkBoxHostel
            // 
            this.checkBoxHostel.AutoSize = true;
            this.checkBoxHostel.Location = new System.Drawing.Point(129, 108);
            this.checkBoxHostel.Name = "checkBoxHostel";
            this.checkBoxHostel.Size = new System.Drawing.Size(85, 17);
            this.checkBoxHostel.TabIndex = 8;
            this.checkBoxHostel.Text = "Гуртожиток";
            this.checkBoxHostel.UseVisualStyleBackColor = true;
            // 
            // buttonAddSpec
            // 
            this.buttonAddSpec.Location = new System.Drawing.Point(154, 134);
            this.buttonAddSpec.Name = "buttonAddSpec";
            this.buttonAddSpec.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSpec.TabIndex = 2;
            this.buttonAddSpec.Text = "Додати";
            this.buttonAddSpec.UseVisualStyleBackColor = true;
            // 
            // AddSpeciality
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(244, 175);
            this.Controls.Add(this.checkBoxHostel);
            this.Controls.Add(this.textBoxTimesAtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStudyingTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddSpec);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddSpeciality";
            this.Text = "Додання спеціальності";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxStudyingTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTimesAtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxHostel;
        private System.Windows.Forms.Button buttonAddSpec;
    }
}