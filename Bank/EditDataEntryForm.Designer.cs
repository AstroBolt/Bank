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
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(167, 331);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Okay_Button
            // 
            this.Okay_Button.Location = new System.Drawing.Point(86, 331);
            this.Okay_Button.Name = "Okay_Button";
            this.Okay_Button.Size = new System.Drawing.Size(75, 23);
            this.Okay_Button.TabIndex = 13;
            this.Okay_Button.Text = "Okay";
            this.Okay_Button.UseVisualStyleBackColor = true;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(86, 121);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(265, 140);
            this.Description.TabIndex = 10;
            this.Description.Text = "";
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Location = new System.Drawing.Point(20, 6);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(66, 13);
            this.Title_Label.TabIndex = 19;
            this.Title_Label.Text = "Entry Details";
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(20, 285);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(33, 13);
            this.Date_Label.TabIndex = 18;
            this.Date_Label.Text = "Date:";
            // 
            // TagsCheckBoxes_Label
            // 
            this.TagsCheckBoxes_Label.AutoSize = true;
            this.TagsCheckBoxes_Label.Location = new System.Drawing.Point(382, 65);
            this.TagsCheckBoxes_Label.Name = "TagsCheckBoxes_Label";
            this.TagsCheckBoxes_Label.Size = new System.Drawing.Size(34, 13);
            this.TagsCheckBoxes_Label.TabIndex = 17;
            this.TagsCheckBoxes_Label.Text = "Tags:";
            // 
            // Description_Label
            // 
            this.Description_Label.AutoSize = true;
            this.Description_Label.Location = new System.Drawing.Point(20, 124);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.Size = new System.Drawing.Size(63, 13);
            this.Description_Label.TabIndex = 16;
            this.Description_Label.Text = "Description:";
            // 
            // Value_Label
            // 
            this.Value_Label.AutoSize = true;
            this.Value_Label.Location = new System.Drawing.Point(20, 68);
            this.Value_Label.Name = "Value_Label";
            this.Value_Label.Size = new System.Drawing.Size(52, 13);
            this.Value_Label.TabIndex = 14;
            this.Value_Label.Text = "Value ($):";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(86, 279);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 11;
            // 
            // TagsCheckBoxes
            // 
            this.TagsCheckBoxes.CheckOnClick = true;
            this.TagsCheckBoxes.FormattingEnabled = true;
            this.TagsCheckBoxes.Location = new System.Drawing.Point(445, 65);
            this.TagsCheckBoxes.Name = "TagsCheckBoxes";
            this.TagsCheckBoxes.Size = new System.Drawing.Size(120, 244);
            this.TagsCheckBoxes.TabIndex = 12;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(86, 65);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(100, 20);
            this.Value.TabIndex = 9;
            // 
            // EditDataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
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