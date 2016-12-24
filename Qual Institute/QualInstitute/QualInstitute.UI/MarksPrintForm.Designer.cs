namespace QualInstitute
{
    partial class MarksPrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarksPrintForm));
            this.PrintButton = new System.Windows.Forms.Button();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printMarksPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printMarks = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(71, 138);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 22);
            this.PrintButton.TabIndex = 0;
            this.PrintButton.Text = "Друк";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(48, 101);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.GroupComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оберіть групу";
            // 
            // printMarksPreviewDialog
            // 
            this.printMarksPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printMarksPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printMarksPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printMarksPreviewDialog.Document = this.printMarks;
            this.printMarksPreviewDialog.Enabled = true;
            this.printMarksPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printMarksPreviewDialog.Icon")));
            this.printMarksPreviewDialog.Name = "printMarksPreviewDialog";
            this.printMarksPreviewDialog.Visible = false;
            // 
            // printMarks
            // 
            this.printMarks.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printMarks_PrintPage_1);
            // 
            // MarksPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.PrintButton);
            this.Name = "MarksPrintForm";
            this.Text = "MarksPrintForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printMarksPreviewDialog;
        private System.Drawing.Printing.PrintDocument printMarks;
    }
}