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
    public partial class EditDataEntryForm : Form
    {
        UserInfo userInfo;
        public EditDataEntryForm(UserInfo _userInfo, ref DataEntry _dataEntry)
        {
            DataEntry dataEntry = _dataEntry;
            InitializeComponent();
            userInfo = _userInfo;
            FillWithEntryInfo(_dataEntry);
            InitializeValue();
            InitializeOkayCancel(dataEntry);
        }

        private void FillWithEntryInfo(DataEntry dataEntry)
        {
            Value.Text = System.Convert.ToString(dataEntry.Value);
            Description.Text = dataEntry.Description;
            Date.Text = dataEntry.TimeStamp;
            if (userInfo.GetTagsArray() != null)
            {
                TagsCheckBoxes.Items.AddRange(userInfo.GetTagsArray());
            }
        }

        private void Okay_Button_Click(object sender, EventArgs e, DataEntry dataEntry)
        {
            EditAndClose(dataEntry);
        }

        private void ValueLostFocus(object sender, EventArgs e)
        {
            if (Value.Text == String.Empty) Value.Text = "0.00";
        }

        private void InitializeValue()
        {
            Value.LostFocus += new EventHandler(ValueLostFocus);
        }

        private void InitializeOkayCancel(DataEntry dataEntry)
        {
            Okay_Button.Click += (sender, e) => Okay_Button_Click(sender, e, dataEntry);
            Okay_Button.KeyDown += new KeyEventHandler(Okay_ButtonKeyDown);
        }

        private void Okay_ButtonKeyDown(object sender, KeyEventArgs e) //I need to add paramater passing data entry
        {
            if (e.KeyCode == Keys.Enter)
            {
                //EditAndClose();
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditAndClose(DataEntry data)
        {           
            List<int> keyTags = new List<int>();
            foreach (Object item in TagsCheckBoxes.CheckedItems)
            {
                keyTags.Add(userInfo.GetKey(item.ToString()));
            }
            data.Value = System.Convert.ToDouble(Value.Text);
            data.Description = Description.Text;
            data.TimeStamp = Date.Text;
            data.TagKeys = keyTags;

            this.Dispose();
        }


    }
}
