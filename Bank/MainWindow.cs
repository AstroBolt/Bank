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
    public partial class MainWindow : Form
    {
        public UserInfo userInfo = new UserInfo();
        public MainWindow()
        {
            InitializeComponent();
            this.Activated += new EventHandler(MainWindowActivated);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Entry_Button_Click(object sender, EventArgs e)
        {
            DataEntryForm DEForm = new DataEntryForm(ref userInfo);
            DEForm.ShowDialog();
        }

        private void Add_Tag_Button_Click(object sender, EventArgs e)
        {
            AddTagForm ATForm = new AddTagForm(ref userInfo);
            ATForm.ShowDialog();
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DisplayEntries()
        {
            List<Button> buttons = GetEntryList();
            for (int i = EntryDisplayTable.Controls.Count - 1; i >= 0; i--)
            {
                Control b = EntryDisplayTable.Controls[i];
                EntryDisplayTable.Controls.Remove(b);
                b.Dispose();
            }
            foreach (Button b in buttons)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.Dock = DockStyle.Top;
                b.TextAlign = ContentAlignment.TopLeft;
                b.MinimumSize = new System.Drawing.Size(80, 80);
                EntryDisplayTable.Controls.Add(b);
            }
        }

        private void EntryButton_Click(object sender, EventArgs e, DataEntry dataEntry)
        {
            EditDataEntryForm EDEForm = new EditDataEntryForm(userInfo, ref dataEntry);
            EDEForm.ShowDialog();
        }

        private void Entry_Click(object sender, EventArgs e)
        {

        }

        private void EntryListSortingButton_Click(object sender, EventArgs e)
        {

        }

        public List<Button> GetEntryList()
        {
            List<Button> buttons = new List<Button>();
            foreach(DataEntry d in userInfo.GetDataEntryListByDate())
            { 
                string s = d.Id + "| " + "$" + d.Value + "\r\n" + d.Date + "\r\n" + d.Description + "\r\n" + d.TagsToString(d.Tags);
                Button b = new Button();
                b.Text = s;
                b.Click += (sender, e) => EntryButton_Click(sender, e, d);
                buttons.Add(b);
            }
            return buttons;
        }

        private void MainWindowActivated(object sender, EventArgs e)
        {
            MainWindowUpdate();
        }

        private void MainWindowUpdate()
        {
            DisplayEntries();
        }

        private void SortingButton_Click(object sender, EventArgs e)
        {

        }

        private void tagToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void valueStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void valueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }



}

//To be used later.....

/*
void TagEntry_inputBoxGotFocus(object sender, EventArgs e)
{
    TextBox textBox = sender as TextBox;
    textBox.Text = "";
}

void TagEntry_inputBoxLostFocus(object sender, EventArgs e)
{
    TextBox textBox = sender as TextBox;
    textBox.Text = "Enter Tag Name";
}

TextBox tagEntry_inputBox = new TextBox();
        tagEntry_inputBox.LostFocus += new System.EventHandler(TagEntry_inputBoxLostFocus);
        tagEntry_inputBox.GotFocus += new System.EventHandler(TagEntry_inputBoxGotFocus);
        tagEntry_inputBox.ForeColor = Color.Gray;
        tagEntry_inputBox.Text = "Enter Tag Name";
        Main_Buttons_Group.Controls.Add(tagEntry_inputBox);
        tagEntry_inputBox.Top = Add_Tag_Button.Bottom + 5;
        tagEntry_inputBox.Left = Add_Tag_Button.Left;
*/
