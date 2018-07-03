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
            InitializeAddTagTextBox();
        }

        private void AddTag()
        {
            List<string> checkedTags = new List<string>();
            if (AddTag_TextBox.Text != string.Empty)
            {
                checkedTags = GetSelectedTags();
                checkedTags.Add(AddTag_TextBox.Text);
                TagsCheckBoxes.Items.Clear();
                userInfo.AddTag(AddTag_TextBox.Text);
                InsertTags();
                if (checkedTags.Count != 0)
                {
                    CheckPrevTags(checkedTags);
                }
            }
        }

        private void AddTag_Button_Click(object sender, EventArgs e)
        {
            AddTag();
        }

        private void AddTag_TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTag();
                AddTag_TextBox.Text = string.Empty;
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CheckPrevTags(List<string> tags)
        {
            if (tags.Count == 0 || TagsCheckBoxes.Items.Count == 0) return;
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

        private void CheckEntryTags(DataEntry dataEntry)
        {
            if (dataEntry.Tags.Count != 0 && TagsCheckBoxes.Items.Count != 0)
            {
                foreach (string s in dataEntry.Tags)
                {
                    for (int i = 0; i < TagsCheckBoxes.Items.Count; i++)
                    {
                        if (s == TagsCheckBoxes.Items[i].ToString())
                        {
                            TagsCheckBoxes.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void EditAndClose(DataEntry data)
        {
            List<string> tags = new List<string>();
            foreach (Object item in TagsCheckBoxes.CheckedItems)
            {
                tags.Add(item.ToString());
            }
            data.Value = System.Convert.ToDecimal(Value.Text);
            data.Description = Description.Text;
            data.Date = Date.Text;
            data.Tags = tags;

            this.Dispose();
        }

        private void FillWithEntryInfo(DataEntry dataEntry)
        {
            Value.Text = System.Convert.ToString(dataEntry.Value);
            Description.Text = dataEntry.Description;
            Date.Text = dataEntry.Date;
            if (userInfo.GetTagsArray() != null)
            {
                TagsCheckBoxes.Items.AddRange(userInfo.GetTagsArray());
            }
            CheckEntryTags(dataEntry);
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

        private void InitializeOkayCancel(DataEntry dataEntry)
        {
            Okay_Button.Click += (sender, e) => Okay_Button_Click(sender, e, dataEntry);
            Okay_Button.KeyDown += new KeyEventHandler(Okay_Button_KeyDown);
        }

        private void InitializeValue()
        {
            Value.LostFocus += new EventHandler(ValueLostFocus);
        }

        private void InsertTags()
        {
            if (userInfo.GetTagsArray() != null)
            {
                TagsCheckBoxes.Items.AddRange(userInfo.GetTagsArray());
            }
        }

        private void Okay_Button_Click(object sender, EventArgs e, DataEntry dataEntry)
        {
            EditAndClose(dataEntry);
        }

        private void Okay_Button_KeyDown(object sender, KeyEventArgs e) //I need to add paramater passing data entry
        {
            if (e.KeyCode == Keys.Enter)
            {
                //EditAndClose();
            }
        }

        private void ValueLostFocus(object sender, EventArgs e)
        {
            if (Value.Text == String.Empty) Value.Text = "0.00";
        }
    }
}
