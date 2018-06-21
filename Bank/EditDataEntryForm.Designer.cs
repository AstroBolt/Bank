namespace Bank
{
    partial class EditDataEntryForm
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
            this.AddTag_Button = new System.Windows.Forms.Button();
            this.AddTag_TextBox = new System.Windows.Forms.TextBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Okay_Button = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Date_Label = new System.Windows.Forms.Label();
            this.TagsCheckBoxes_Label = new System.Windows.Forms.Label();
            this.Description_Label = new System.Windows.Forms.Label();
            this.Value_Label = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.TagsCheckBoxes = new System.Windows.Forms.CheckedListBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddTag_Button
            // 
            this.AddTag_Button.Location = new System.Drawing.Point(474, 324);
            this.AddTag_Button.Name = "AddTag_Button";
            this.AddTag_Button.Size = new System.Drawing.Size(75, 23);
            this.AddTag_Button.TabIndex = 23;
            this.AddTag_Button.Text = "Add Tag";
            this.AddTag_Button.UseVisualStyleBackColor = true;
            this.AddTag_Button.Click += new System.EventHandler(this.AddTag_Button_Click);
            // 
            // AddTag_TextBox
            // 
            this.AddTag_TextBox.Location = new System.Drawing.Point(448, 298);
            this.AddTag_TextBox.Name = "AddTag_TextBox";
            this.AddTag_TextBox.Size = new System.Drawing.Size(120, 20);
            this.AddTag_TextBox.TabIndex = 22;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(163, 298);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 17;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Okay_Button
            // 
            this.Okay_Button.Location = new System.Drawing.Point(82, 298);
            this.Okay_Button.Name = "Okay_Button";
            this.Okay_Button.Size = new System.Drawing.Size(75, 23);
            this.Okay_Button.TabIndex = 15;
            this.Okay_Button.Text = "Okay";
            this.Okay_Button.UseVisualStyleBackColor = true;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(82, 112);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(265, 140);
            this.Description.TabIndex = 12;
            this.Description.Text = "";
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Location = new System.Drawing.Point(19, 14);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(66, 13);
            this.Title_Label.TabIndex = 21;
            this.Title_Label.Text = "Entry Details";
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(16, 276);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(33, 13);
            this.Date_Label.TabIndex = 20;
            this.Date_Label.Text = "Date:";
            // 
            // TagsCheckBoxes_Label
            // 
            this.TagsCheckBoxes_Label.AutoSize = true;
            this.TagsCheckBoxes_Label.Location = new System.Drawing.Point(385, 48);
            this.TagsCheckBoxes_Label.Name = "TagsCheckBoxes_Label";
            this.TagsCheckBoxes_Label.Size = new System.Drawing.Size(34, 13);
            this.TagsCheckBoxes_Label.TabIndex = 19;
            this.TagsCheckBoxes_Label.Text = "Tags:";
            // 
            // Description_Label
            // 
            this.Description_Label.AutoSize = true;
            this.Description_Label.Location = new System.Drawing.Point(16, 115);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.Size = new System.Drawing.Size(63, 13);
            this.Description_Label.TabIndex = 18;
            this.Description_Label.Text = "Description:";
            // 
            // Value_Label
            // 
            this.Value_Label.AutoSize = true;
            this.Value_Label.Location = new System.Drawing.Point(16, 59);
            this.Value_Label.Name = "Value_Label";
            this.Value_Label.Size = new System.Drawing.Size(52, 13);
            this.Value_Label.TabIndex = 16;
            this.Value_Label.Text = "Value ($):";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(82, 270);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 13;
            // 
            // TagsCheckBoxes
            // 
            this.TagsCheckBoxes.CheckOnClick = true;
            this.TagsCheckBoxes.FormattingEnabled = true;
            this.TagsCheckBoxes.Location = new System.Drawing.Point(448, 48);
            this.TagsCheckBoxes.Name = "TagsCheckBoxes";
            this.TagsCheckBoxes.Size = new System.Drawing.Size(120, 244);
            this.TagsCheckBoxes.TabIndex = 14;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(82, 56);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(100, 20);
            this.Value.TabIndex = 11;
            // 
            // EditDataEntryForm
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
            this.Name = "EditDataEntryForm";
            this.Text = "EditDataEntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTag_Button;
        private System.Windows.Forms.TextBox AddTag_TextBox;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Okay_Button;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Label TagsCheckBoxes_Label;
        private System.Windows.Forms.Label Description_Label;
        private System.Windows.Forms.Label Value_Label;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.CheckedListBox TagsCheckBoxes;
        private System.Windows.Forms.TextBox Value;
    }
}