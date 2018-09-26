namespace Bank
{
    partial class AddTagForm
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
            this.AddTag_Cancel_Button = new System.Windows.Forms.Button();
            this.AddTag_Tag_Label = new System.Windows.Forms.Label();
            this.AddTag_TagName_TextBox = new System.Windows.Forms.TextBox();
            this.AddTag_Okay_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddTag_Cancel_Button
            // 
            this.AddTag_Cancel_Button.Location = new System.Drawing.Point(90, 38);
            this.AddTag_Cancel_Button.Name = "AddTag_Cancel_Button";
            this.AddTag_Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.AddTag_Cancel_Button.TabIndex = 11;
            this.AddTag_Cancel_Button.Text = "Cancel";
            this.AddTag_Cancel_Button.UseVisualStyleBackColor = true;
            this.AddTag_Cancel_Button.Click += new System.EventHandler(this.AddTag_Cancel_Button_Click);
            // 
            // AddTag_Tag_Label
            // 
            this.AddTag_Tag_Label.AutoSize = true;
            this.AddTag_Tag_Label.Location = new System.Drawing.Point(9, 15);
            this.AddTag_Tag_Label.Name = "AddTag_Tag_Label";
            this.AddTag_Tag_Label.Size = new System.Drawing.Size(29, 13);
            this.AddTag_Tag_Label.TabIndex = 9;
            this.AddTag_Tag_Label.Text = "Tag:";
            // 
            // AddTag_TagName_TextBox
            // 
            this.AddTag_TagName_TextBox.Location = new System.Drawing.Point(50, 12);
            this.AddTag_TagName_TextBox.Name = "AddTag_TagName_TextBox";
            this.AddTag_TagName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.AddTag_TagName_TextBox.TabIndex = 8;
            // 
            // AddTag_Okay_Button
            // 
            this.AddTag_Okay_Button.Location = new System.Drawing.Point(9, 38);
            this.AddTag_Okay_Button.Name = "AddTag_Okay_Button";
            this.AddTag_Okay_Button.Size = new System.Drawing.Size(75, 23);
            this.AddTag_Okay_Button.TabIndex = 10;
            this.AddTag_Okay_Button.Text = "Okay";
            this.AddTag_Okay_Button.UseVisualStyleBackColor = true;
            this.AddTag_Okay_Button.Click += new System.EventHandler(this.AddTag_Okay_Button_Click);
            // 
            // AddTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(180, 76);
            this.Controls.Add(this.AddTag_Cancel_Button);
            this.Controls.Add(this.AddTag_Tag_Label);
            this.Controls.Add(this.AddTag_TagName_TextBox);
            this.Controls.Add(this.AddTag_Okay_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTagForm";
            this.Text = "AddTag";
            this.Load += new System.EventHandler(this.AddTagForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTag_Cancel_Button;
        private System.Windows.Forms.Label AddTag_Tag_Label;
        private System.Windows.Forms.TextBox AddTag_TagName_TextBox;
        private System.Windows.Forms.Button AddTag_Okay_Button;
    }
}