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
            InitializeAddTagTextBox();
            InsertTags();
        }

        private void DataEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void AddAndClose()
        {
            List<string> tags = new List<string>();
            foreach (Object item in TagsCheckBoxes.CheckedItems)
            {
                tags.Add(item.ToString());
            }
            DataEntry dataEntry = new DataEntry(System.Convert.ToDouble(Value.Text), Date.Text, Description.Text, tags);
            dataEntry.Value = System.Convert.ToDouble(Value.Text);
            dataEntry.Date = Date.Text;
            Console.WriteLine(Date.Value);
            dataEntry.Description = Description.Text;
            dataEntry.Tags = tags;
            userInfo.AddDataEntry(dataEntry);
            this.Dispose();
        }

        private void AddTag()
        {
            List<string> checkedTags = new List<string>();
            if (AddTag_TextBox.Text == string.Empty) return;
            {
                checkedTags = GetSelectedTags();
                checkedTags.Add(AddTag_TextBox.Text);
                TagsCheckBoxes.Items.Clear();
                userInfo.AddTag(AddTag_TextBox.Text);
                InsertTags();
                if (checkedTags.Count != 0)
                {
                    CheckTags(checkedTags);
                }
            }
        }

        private void AddTag_Button_Click(object sender, EventArgs e)
        {
            AddTag();
        }

        private void AddTag_TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddTag();
                AddTag_TextBox.Text = string.Empty;
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CheckTags(List<string> tags)
        {
            if (tags.Count != 0 && TagsCheckBoxes.Items.Count != 0)
            {
                for (int i = 0; i < TagsCheckBoxes.Items.Count; i++)
                {
                    foreach (string s in tags)
                    {
                        if (TagsCheckBoxes.Items[i].ToString() == s)
                        {
                            TagsCheckBoxes.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private List<string> GetSelectedTags()
        {
            List<string> strings = new List<string>();
            if (TagsCheckBoxes.CheckedItems.Count != 0)
            {
                foreach (Object checkBox in TagsCheckBoxes.CheckedItems)
                {
                    strings.Add(checkBox.ToString());
                }
                String s = string.Empty;
                foreach (string str in strings)
                {
                    s += str;
                }
                return strings;
            }
            return strings;
        }

        private void InitializeAddTagTextBox()
        {
            AddTag_TextBox.KeyUp += new KeyEventHandler(AddTag_TextBox_KeyUp);
        }

        private void InitializeOkayCancel()
        {
            Okay_Button.KeyDown += new KeyEventHandler(Okay_Button_KeyDown);
        }

        private void InitializeValue()
        {
            Value.LostFocus += new EventHandler(ValueLostFocus);
            Value.Text = "0.00";
        }

        private void InsertTags()
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

        private void Okay_Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddAndClose();
            }
        }

        private void ValueLostFocus(object sender, EventArgs e)
        {
            if (Value.Text == String.Empty) Value.Text = "0.00";
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
