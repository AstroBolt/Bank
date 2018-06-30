namespace Bank
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.Main_Buttons_Group = new System.Windows.Forms.GroupBox();
            this.Add_Tag_Button = new System.Windows.Forms.Button();
            this.Add_Entry_Button = new System.Windows.Forms.Button();
            this.EntryDisplayTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valueStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntryListSortingButton = new System.Windows.Forms.Button();
            this.MainMenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTable.SuspendLayout();
            this.Main_Buttons_Group.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MainMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.AccessibleName = "MainTable";
            this.MainTable.ColumnCount = 3;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTable.Controls.Add(this.Main_Buttons_Group, 0, 2);
            this.MainTable.Controls.Add(this.EntryDisplayTable, 1, 2);
            this.MainTable.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.MainTable.Controls.Add(this.MainMenuBar, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 4;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainTable.Size = new System.Drawing.Size(800, 450);
            this.MainTable.TabIndex = 0;
            // 
            // Main_Buttons_Group
            // 
            this.Main_Buttons_Group.Controls.Add(this.Add_Tag_Button);
            this.Main_Buttons_Group.Controls.Add(this.Add_Entry_Button);
            this.Main_Buttons_Group.Location = new System.Drawing.Point(3, 93);
            this.Main_Buttons_Group.Name = "Main_Buttons_Group";
            this.Main_Buttons_Group.Size = new System.Drawing.Size(194, 127);
            this.Main_Buttons_Group.TabIndex = 4;
            this.Main_Buttons_Group.TabStop = false;
            this.Main_Buttons_Group.Text = "Actions";
            // 
            // Add_Tag_Button
            // 
            this.Add_Tag_Button.Location = new System.Drawing.Point(9, 48);
            this.Add_Tag_Button.Name = "Add_Tag_Button";
            this.Add_Tag_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Tag_Button.TabIndex = 3;
            this.Add_Tag_Button.Text = "Add Tag";
            this.Add_Tag_Button.UseVisualStyleBackColor = true;
            this.Add_Tag_Button.Click += new System.EventHandler(this.Add_Tag_Button_Click);
            // 
            // Add_Entry_Button
            // 
            this.Add_Entry_Button.Location = new System.Drawing.Point(9, 19);
            this.Add_Entry_Button.Name = "Add_Entry_Button";
            this.Add_Entry_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Entry_Button.TabIndex = 2;
            this.Add_Entry_Button.Text = "Add Entry";
            this.Add_Entry_Button.UseVisualStyleBackColor = true;
            this.Add_Entry_Button.Click += new System.EventHandler(this.Add_Entry_Button_Click);
            // 
            // EntryDisplayTable
            // 
            this.EntryDisplayTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryDisplayTable.AutoScroll = true;
            this.EntryDisplayTable.ColumnCount = 1;
            this.EntryDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EntryDisplayTable.Location = new System.Drawing.Point(203, 93);
            this.EntryDisplayTable.Name = "EntryDisplayTable";
            this.EntryDisplayTable.RowCount = 1;
            this.EntryDisplayTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EntryDisplayTable.Size = new System.Drawing.Size(394, 309);
            this.EntryDisplayTable.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EntryListSortingButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(203, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 39);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 15);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(197, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valueStripMenuItem,
            this.dateToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sortByToolStripMenuItem.Text = "Sort By";
            // 
            // valueStripMenuItem
            // 
            this.valueStripMenuItem.Name = "valueStripMenuItem";
            this.valueStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.valueStripMenuItem.Text = "Value";
            this.valueStripMenuItem.Click += new System.EventHandler(this.valueToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // EntryListSortingButton
            // 
            this.EntryListSortingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EntryListSortingButton.BackColor = System.Drawing.SystemColors.Control;
            this.EntryListSortingButton.FlatAppearance.BorderSize = 0;
            this.EntryListSortingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntryListSortingButton.Image = ((System.Drawing.Image)(resources.GetObject("EntryListSortingButton.Image")));
            this.EntryListSortingButton.Location = new System.Drawing.Point(200, 16);
            this.EntryListSortingButton.Name = "EntryListSortingButton";
            this.EntryListSortingButton.Size = new System.Drawing.Size(20, 20);
            this.EntryListSortingButton.TabIndex = 8;
            this.EntryListSortingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EntryListSortingButton.UseVisualStyleBackColor = false;
            this.EntryListSortingButton.Click += new System.EventHandler(this.EntryListSortingButton_Click);
            // 
            // MainMenuBar
            // 
            this.MainTable.SetColumnSpan(this.MainMenuBar, 3);
            this.MainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenuBar.Location = new System.Drawing.Point(0, 0);
            this.MainMenuBar.Name = "MainMenuBar";
            this.MainMenuBar.Size = new System.Drawing.Size(800, 24);
            this.MainMenuBar.TabIndex = 7;
            this.MainMenuBar.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTable);
            this.MainMenuStrip = this.MainMenuBar;
            this.Name = "MainWindow";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.Main_Buttons_Group.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainMenuBar.ResumeLayout(false);
            this.MainMenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.GroupBox Main_Buttons_Group;
        private System.Windows.Forms.Button Add_Tag_Button;
        private System.Windows.Forms.Button Add_Entry_Button;
        private System.Windows.Forms.TableLayoutPanel EntryDisplayTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valueStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.Button EntryListSortingButton;
        private System.Windows.Forms.MenuStrip MainMenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

