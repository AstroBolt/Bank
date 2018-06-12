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
    public partial class DataEntryForm : Form
    {
        UserInfo userInfo;
        public DataEntryForm(ref UserInfo _userInfo)
        {
            InitializeComponent();
            userInfo = _userInfo;
            InitializeValue();
            InitializeOkayCancel();
        }

        private void DataEntryForm_Load(object sender, EventArgs e)
        {
            if (userInfo.GetTagsArray() != null)
            {
                TagsCheckBoxes.Items.AddRange(userInfo.GetTagsArray());
            }
        }

        private void Okay_Button_Click(object sender, EventArgs e)
        {
            AddAndClose();
        }

        private void TagsCheckBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ValueLostFocus(object sender, EventArgs e)
        {
            if (Value.Text == String.Empty) Value.Text = "0.00";
        }

        private void InitializeValue()
        {
            Value.LostFocus += new EventHandler(ValueLostFocus);
            Value.Text = "0.00";
        }

        private void InitializeOkayCancel()
        {
            Okay_Button.KeyDown += new KeyEventHandler(Okay_ButtonKeyDown);
        }

        private void Okay_ButtonKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                AddAndClose();
            }   
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAndClose()
        {
            List<int> keyTags = new List<int>();
            foreach (Object item in TagsCheckBoxes.CheckedItems)
            {
                keyTags.Add(userInfo.GetKey(item.ToString()));
            }
            DataEntry dataEntry = new DataEntry(System.Convert.ToDouble(Value.Text), Date.Text, Description.Text, keyTags);
            dataEntry.Value = System.Convert.ToDouble(Value.Text);
            dataEntry.TimeStamp = Date.Text;
            Console.WriteLine(Date.Value);
            dataEntry.Description = Description.Text;
            dataEntry.TagKeys = keyTags;
            userInfo.AddDataEntry(dataEntry);
            this.Close();
        }
    }
}
