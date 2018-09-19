using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class AddTagForm : Form
    {
        UserInfo userInfo;
        public AddTagForm(ref UserInfo _userInfo)
        {
            InitializeComponent();
            userInfo = _userInfo;
            AddTag_TagName_TextBox.KeyUp += new KeyEventHandler(AddTagFormKeyUp);
        }

        private void AddTag_Okay_Button_Click(object sender, EventArgs e)
        {
            
            AddAndClose();
        }

        private void AddTag_Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddTagFormKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddAndClose();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void AddAndClose()
        {
            userInfo.AddTag(AddTag_TagName_TextBox.Text);
            this.Dispose();
        }
    }
}
