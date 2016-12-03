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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.планРоботиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.викладачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оцінкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.dataGrid.Size = new System.Drawing.Size(1070, 264);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(263, 305);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(163, 305);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Видалити";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(12, 305);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 1;
            this.buttonQuit.Text = "Вихід";
            this.buttonQuit.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицяToolStripMenuItem,
            this.друкToolStripMenuItem,
            this.змінитиКористувачаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
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
            this.розкладToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.розкладToolStripMenuItem.Text = "Розклад";
            // 
            // планРоботиToolStripMenuItem
            // 
            this.планРоботиToolStripMenuItem.Name = "планРоботиToolStripMenuItem";
            this.планРоботиToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.планРоботиToolStripMenuItem.Text = "Навчальний план";
            // 
            // предметиToolStripMenuItem
            // 
            this.предметиToolStripMenuItem.Name = "предметиToolStripMenuItem";
            this.предметиToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.предметиToolStripMenuItem.Text = "Предмети";
            // 
            // викладачіToolStripMenuItem
            // 
            this.викладачіToolStripMenuItem.Name = "викладачіToolStripMenuItem";
            this.викладачіToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.викладачіToolStripMenuItem.Text = "Викладачі";
            // 
            // оцінкиToolStripMenuItem
            // 
            this.оцінкиToolStripMenuItem.Name = "оцінкиToolStripMenuItem";
            this.оцінкиToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.оцінкиToolStripMenuItem.Text = "Оцінки";
            // 
            // студентиToolStripMenuItem
            // 
            this.студентиToolStripMenuItem.Name = "студентиToolStripMenuItem";
            this.студентиToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.студентиToolStripMenuItem.Text = "Студенти";
            this.студентиToolStripMenuItem.Click += new System.EventHandler(this.студентиToolStripMenuItem_Click);
            // 
            // групиToolStripMenuItem
            // 
            this.групиToolStripMenuItem.Name = "групиToolStripMenuItem";
            this.групиToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.групиToolStripMenuItem.Text = "Групи";
            // 
            // спеціальностіToolStripMenuItem
            // 
            this.спеціальностіToolStripMenuItem.Name = "спеціальностіToolStripMenuItem";
            this.спеціальностіToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.спеціальностіToolStripMenuItem.Text = "Спеціальності";
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
            // 
            // зарплатноїВідомостіToolStripMenuItem
            // 
            this.зарплатноїВідомостіToolStripMenuItem.Name = "зарплатноїВідомостіToolStripMenuItem";
            this.зарплатноїВідомостіToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.зарплатноїВідомостіToolStripMenuItem.Text = "Зарплатної відомості";
            // 
            // екзаменаційноїВідомостіToolStripMenuItem
            // 
            this.екзаменаційноїВідомостіToolStripMenuItem.Name = "екзаменаційноїВідомостіToolStripMenuItem";
            this.екзаменаційноїВідомостіToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.екзаменаційноїВідомостіToolStripMenuItem.Text = "Екзаменаційної відомості";
            // 
            // розкладуГрупиToolStripMenuItem
            // 
            this.розкладуГрупиToolStripMenuItem.Name = "розкладуГрупиToolStripMenuItem";
            this.розкладуГрупиToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.розкладуГрупиToolStripMenuItem.Text = "Розкладу групи";
            // 
            // змінитиКористувачаToolStripMenuItem
            // 
            this.змінитиКористувачаToolStripMenuItem.Name = "змінитиКористувачаToolStripMenuItem";
            this.змінитиКористувачаToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.змінитиКористувачаToolStripMenuItem.Text = "Змінити користувача";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1070, 339);
            this.Controls.Add(this.buttonQuit);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonQuit;
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

    }
}