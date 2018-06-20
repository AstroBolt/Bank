namespace Bank
{
    partial class DataEntryForm
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
            this.Value = new System.Windows.Forms.TextBox();
            this.TagsCheckBoxes = new System.Windows.Forms.CheckedListBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Value_Label = new System.Windows.Forms.Label();
            this.Description_Label = new System.Windows.Forms.Label();
            this.TagsCheckBoxes_Label = new System.Windows.Forms.Label();
            this.Date_Label = new System.Windows.Forms.Label();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Okay_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.AddTag_TextBox = new System.Windows.Forms.TextBox();
            this.AddTag_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(86, 51);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(100, 20);
            this.Value.TabIndex = 0;
            this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // TagsCheckBoxes
            // 
            this.TagsCheckBoxes.CheckOnClick = true;
            this.TagsCheckBoxes.FormattingEnabled = true;
            this.TagsCheckBoxes.Location = new System.Drawing.Point(452, 43);
            this.TagsCheckBoxes.Name = "TagsCheckBoxes";
            this.TagsCheckBoxes.Size = new System.Drawing.Size(120, 244);
            this.TagsCheckBoxes.TabIndex = 3;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(86, 265);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 2;
            // 
            // Value_Label
            // 
            this.Value_Label.AutoSize = true;
            this.Value_Label.Location = new System.Drawing.Point(20, 54);
            this.Value_Label.Name = "Value_Label";
            this.Value_Label.Size = new System.Drawing.Size(52, 13);
            this.Value_Label.TabIndex = 4;
            this.Value_Label.Text = "Value ($):";
            // 
            // Description_Label
            // 
            this.Description_Label.AutoSize = true;
            this.Description_Label.Location = new System.Drawing.Point(20, 110);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.Size = new System.Drawing.Size(63, 13);
            this.Description_Label.TabIndex = 5;
            this.Description_Label.Text = "Description:";
            // 
            // TagsCheckBoxes_Label
            // 
            this.TagsCheckBoxes_Label.AutoSize = true;
            this.TagsCheckBoxes_Label.Location = new System.Drawing.Point(389, 43);
            this.TagsCheckBoxes_Label.Name = "TagsCheckBoxes_Label";
            this.TagsCheckBoxes_Label.Size = new System.Drawing.Size(34, 13);
            this.TagsCheckBoxes_Label.TabIndex = 6;
            this.TagsCheckBoxes_Label.Text = "Tags:";
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(20, 271);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(33, 13);
            this.Date_Label.TabIndex = 7;
            this.Date_Label.Text = "Date:";
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Location = new System.Drawing.Point(23, 9);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(66, 13);
            this.Title_Label.TabIndex = 8;
            this.Title_Label.Text = "Entry Details";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(86, 107);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(265, 140);
            this.Description.TabIndex = 1;
            this.Description.Text = "";
            // 
            // Okay_Button
            // 
            this.Okay_Button.Location = new System.Drawing.Point(86, 293);
            this.Okay_Button.Name = "Okay_Button";
            this.Okay_Button.Size = new System.Drawing.Size(75, 23);
            this.Okay_Button.TabIndex = 4;
            this.Okay_Button.Text = "Okay";
            this.Okay_Button.UseVisualStyleBackColor = true;
            this.Okay_Button.Click += new System.EventHandler(this.Okay_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(167, 293);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 5;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // AddTag_TextBox
            // 
            this.AddTag_TextBox.Location = new System.Drawing.Point(452, 293);
            this.AddTag_TextBox.Name = "AddTag_TextBox";
            this.AddTag_TextBox.Size = new System.Drawing.Size(120, 20);
            this.AddTag_TextBox.TabIndex = 9;
            // 
            // AddTag_Button
            // 
            this.AddTag_Button.Location = new System.Drawing.Point(478, 319);
            this.AddTag_Button.Name = "AddTag_Button";
            this.AddTag_Button.Size = new System.Drawing.Size(75, 23);
            this.AddTag_Button.TabIndex = 10;
            this.AddTag_Button.Text = "Add Tag";
            this.AddTag_Button.UseVisualStyleBackColor = true;
            this.AddTag_Button.Click += new System.EventHandler(this.AddTag_Button_Click);
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.AddTag_Button);
            this.Controls.Add(this.AddTag_TextBox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Okay_Button);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Title_Label);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.TagsCheckBoxes_Label);
            this.Controls.Add(this.Description_Label);
            this.Controls.Add(this.Value_Label);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.TagsCheckBoxes);
            this.Controls.Add(this.Value);
            this.Name = "DataEntryForm";
            this.Text = "DataEntryForm";
            this.Load += new System.EventHandler(this.DataEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.CheckedListBox TagsCheckBoxes;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label Value_Label;
        private System.Windows.Forms.Label Description_Label;
        private System.Windows.Forms.Label TagsCheckBoxes_Label;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Button Okay_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.TextBox AddTag_TextBox;
        private System.Windows.Forms.Button AddTag_Button;
    }
}