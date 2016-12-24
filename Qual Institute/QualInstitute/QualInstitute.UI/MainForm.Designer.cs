namespace QualInstitute.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.планРоботиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.викладачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оцінкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформуватиВідомістьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переглядОцінокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.групиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спеціальностіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.друкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.планаРоботиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарплатноїВідомостіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.екзаменаційноїВідомостіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розкладуГрупиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPlan = new System.Drawing.Printing.PrintDocument();
            this.printPlanPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printSalary = new System.Drawing.Printing.PrintDocument();
            this.printSalaryPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.SecondFilterComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGrid.Location = new System.Drawing.Point(0, 24);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(558, 264);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellValueChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(133, 305);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(23, 305);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Видалити";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицяToolStripMenuItem,
            this.друкToolStripMenuItem,
            this.змінитиКористувачаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицяToolStripMenuItem
            // 
            this.таблицяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.розкладToolStripMenuItem,
            this.планРоботиToolStripMenuItem,
            this.предметиToolStripMenuItem,
            this.викладачіToolStripMenuItem,
            this.оцінкиToolStripMenuItem,
            this.студентиToolStripMenuItem,
            this.групиToolStripMenuItem,
            this.спеціальностіToolStripMenuItem});
            this.таблицяToolStripMenuItem.Name = "таблицяToolStripMenuItem";
            this.таблицяToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.таблицяToolStripMenuItem.Text = "Таблиця";
            // 
            // розкладToolStripMenuItem
            // 
            this.розкладToolStripMenuItem.Name = "розкладToolStripMenuItem";
            this.розкладToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.розкладToolStripMenuItem.Text = "Розклад";
            this.розкладToolStripMenuItem.Click += new System.EventHandler(this.розкладToolStripMenuItem_Click);
            // 
            // планРоботиToolStripMenuItem
            // 
            this.планРоботиToolStripMenuItem.Name = "планРоботиToolStripMenuItem";
            this.планРоботиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.планРоботиToolStripMenuItem.Text = "Місячний звіт";
            this.планРоботиToolStripMenuItem.Click += new System.EventHandler(this.планРоботиToolStripMenuItem_Click);
            // 
            // предметиToolStripMenuItem
            // 
            this.предметиToolStripMenuItem.Name = "предметиToolStripMenuItem";
            this.предметиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.предметиToolStripMenuItem.Text = "Предмети";
            this.предметиToolStripMenuItem.Click += new System.EventHandler(this.предметиToolStripMenuItem_Click);
            // 
            // викладачіToolStripMenuItem
            // 
            this.викладачіToolStripMenuItem.Name = "викладачіToolStripMenuItem";
            this.викладачіToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.викладачіToolStripMenuItem.Text = "Викладачі";
            this.викладачіToolStripMenuItem.Click += new System.EventHandler(this.викладачіToolStripMenuItem_Click);
            // 
            // оцінкиToolStripMenuItem
            // 
            this.оцінкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сформуватиВідомістьToolStripMenuItem,
            this.переглядОцінокToolStripMenuItem});
            this.оцінкиToolStripMenuItem.Name = "оцінкиToolStripMenuItem";
            this.оцінкиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оцінкиToolStripMenuItem.Text = "Оцінки";
            // 
            // сформуватиВідомістьToolStripMenuItem
            // 
            this.сформуватиВідомістьToolStripMenuItem.Name = "сформуватиВідомістьToolStripMenuItem";
            this.сформуватиВідомістьToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.сформуватиВідомістьToolStripMenuItem.Text = "Сформувати відомість";
            this.сформуватиВідомістьToolStripMenuItem.Click += new System.EventHandler(this.сформуватиВідомістьToolStripMenuItem_Click);
            // 
            // переглядОцінокToolStripMenuItem
            // 
            this.переглядОцінокToolStripMenuItem.Name = "переглядОцінокToolStripMenuItem";
            this.переглядОцінокToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.переглядОцінокToolStripMenuItem.Text = "Перегляд оцінок";
            this.переглядОцінокToolStripMenuItem.Click += new System.EventHandler(this.переглядОцінокToolStripMenuItem_Click);
            // 
            // студентиToolStripMenuItem
            // 
            this.студентиToolStripMenuItem.Name = "студентиToolStripMenuItem";
            this.студентиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.студентиToolStripMenuItem.Text = "Студенти";
            this.студентиToolStripMenuItem.Click += new System.EventHandler(this.студентиToolStripMenuItem_Click);
            // 
            // групиToolStripMenuItem
            // 
            this.групиToolStripMenuItem.Name = "групиToolStripMenuItem";
            this.групиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.групиToolStripMenuItem.Text = "Групи";
            this.групиToolStripMenuItem.Click += new System.EventHandler(this.групиToolStripMenuItem_Click);
            // 
            // спеціальностіToolStripMenuItem
            // 
            this.спеціальностіToolStripMenuItem.Name = "спеціальностіToolStripMenuItem";
            this.спеціальностіToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.спеціальностіToolStripMenuItem.Text = "Спеціальності";
            this.спеціальностіToolStripMenuItem.Click += new System.EventHandler(this.спеціальностіToolStripMenuItem_Click);
            // 
            // друкToolStripMenuItem
            // 
            this.друкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.планаРоботиToolStripMenuItem,
            this.зарплатноїВідомостіToolStripMenuItem,
            this.екзаменаційноїВідомостіToolStripMenuItem,
            this.розкладуГрупиToolStripMenuItem});
            this.друкToolStripMenuItem.Name = "друкToolStripMenuItem";
            this.друкToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.друкToolStripMenuItem.Text = "Друк";
            // 
            // планаРоботиToolStripMenuItem
            // 
            this.планаРоботиToolStripMenuItem.Name = "планаРоботиToolStripMenuItem";
            this.планаРоботиToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.планаРоботиToolStripMenuItem.Text = "Плана роботи ІПК";
            this.планаРоботиToolStripMenuItem.Click += new System.EventHandler(this.планаРоботиToolStripMenuItem_Click);
            // 
            // зарплатноїВідомостіToolStripMenuItem
            // 
            this.зарплатноїВідомостіToolStripMenuItem.Name = "зарплатноїВідомостіToolStripMenuItem";
            this.зарплатноїВідомостіToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.зарплатноїВідомостіToolStripMenuItem.Text = "Зарплатної відомості";
            this.зарплатноїВідомостіToolStripMenuItem.Click += new System.EventHandler(this.зарплатноїВідомостіToolStripMenuItem_Click);
            // 
            // екзаменаційноїВідомостіToolStripMenuItem
            // 
            this.екзаменаційноїВідомостіToolStripMenuItem.Name = "екзаменаційноїВідомостіToolStripMenuItem";
            this.екзаменаційноїВідомостіToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.екзаменаційноїВідомостіToolStripMenuItem.Text = "Екзаменаційної відомості";
            this.екзаменаційноїВідомостіToolStripMenuItem.Click += new System.EventHandler(this.екзаменаційноїВідомостіToolStripMenuItem_Click);
            // 
            // розкладуГрупиToolStripMenuItem
            // 
            this.розкладуГрупиToolStripMenuItem.Name = "розкладуГрупиToolStripMenuItem";
            this.розкладуГрупиToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.розкладуГрупиToolStripMenuItem.Text = "Розкладу групи";
            this.розкладуГрупиToolStripMenuItem.Click += new System.EventHandler(this.розкладуГрупиToolStripMenuItem_Click);
            // 
            // змінитиКористувачаToolStripMenuItem
            // 
            this.змінитиКористувачаToolStripMenuItem.Name = "змінитиКористувачаToolStripMenuItem";
            this.змінитиКористувачаToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.змінитиКористувачаToolStripMenuItem.Text = "Змінити користувача";
            this.змінитиКористувачаToolStripMenuItem.Click += new System.EventHandler(this.змінитиКористувачаToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 48);
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.додатиToolStripMenuItem.Text = "Додати...";
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            // 
            // printPlan
            // 
            this.printPlan.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printPlan_PrintPage);
            // 
            // printPlanPreviewDialog
            // 
            this.printPlanPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPlanPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPlanPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPlanPreviewDialog.Document = this.printPlan;
            this.printPlanPreviewDialog.Enabled = true;
            this.printPlanPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPlanPreviewDialog.Icon")));
            this.printPlanPreviewDialog.Name = "printPlanPreviewDialog";
            this.printPlanPreviewDialog.Visible = false;
            // 
            // printSalary
            // 
            this.printSalary.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printSalary_PrintPage);
            // 
            // printSalaryPreviewDialog
            // 
            this.printSalaryPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printSalaryPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printSalaryPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printSalaryPreviewDialog.Document = this.printSalary;
            this.printSalaryPreviewDialog.Enabled = true;
            this.printSalaryPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printSalaryPreviewDialog.Icon")));
            this.printSalaryPreviewDialog.Name = "printSalaryPreviewDialog";
            this.printSalaryPreviewDialog.Visible = false;
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(268, 307);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(101, 21);
            this.FilterComboBox.TabIndex = 3;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // SecondFilterComboBox
            // 
            this.SecondFilterComboBox.FormattingEnabled = true;
            this.SecondFilterComboBox.Location = new System.Drawing.Point(405, 307);
            this.SecondFilterComboBox.Name = "SecondFilterComboBox";
            this.SecondFilterComboBox.Size = new System.Drawing.Size(101, 21);
            this.SecondFilterComboBox.TabIndex = 4;
            this.SecondFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.SecondFilterComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(558, 339);
            this.Controls.Add(this.SecondFilterComboBox);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ІПК";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem змінитиКористувачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem друкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планаРоботиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зарплатноїВідомостіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem екзаменаційноїВідомостіToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розкладToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планРоботиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem викладачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оцінкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спеціальностіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem групиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розкладуГрупиToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printPlan;
        private System.Windows.Forms.PrintPreviewDialog printPlanPreviewDialog;
        private System.Drawing.Printing.PrintDocument printSalary;
        private System.Windows.Forms.PrintPreviewDialog printSalaryPreviewDialog;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.ComboBox SecondFilterComboBox;
        private System.Windows.Forms.ToolStripMenuItem сформуватиВідомістьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переглядОцінокToolStripMenuItem;
    }
}