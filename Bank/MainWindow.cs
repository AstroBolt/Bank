using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security;
using System.IO;


/*
 * To do:
 *  Update filter tags whenever tags are added.
 *  Improve file I/O operations
 *  Tag deletion
 *  Reformat entries
 *  Entry deletion
 *      Little x's top right corner of entries that only appear as you hover over the entry
 */



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
        private string sortType = "date";
        private bool SortInReverse = true;
        private string userInfoFile = string.Empty;
        private bool changesMade = true;
        private TagSearch tagSearch;

        private void Form1_Load(object sender, EventArgs e)
        {
            MainTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tagSearch = new TagSearch(ref userInfo);//does this need to be a ref?
            tagSearch.GetApplyButton().Click += (se, ev) =>
            {
                tagSearch.SaveCheckedTags();
                DisplayEntries(); //Calls GetEntries() which calls for filtering
            };
            MainTable.Controls.Add(tagSearch.GetMainTable(), 2, 2);

            //Start sorting tool bar with date sorting
            sortType = "date";
            dateToolStripMenuItem.Checked = true;
            sortByToolStripMenuItem.Text = "Date";

            //Start sorting reversal button as up
            EntryListSortingButton.Image = Properties.Resources.Up_Arrows;
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

        private void DateAddedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortType = "dateCreated";
            UncheckSortByMenuItems();
            dateAddedToolStripMenuItem.Checked = true;
            sortByToolStripMenuItem.Text = "Date added";
            DisplayEntries();
        }

        private void DateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortType = "date";
            UncheckSortByMenuItems();
            dateToolStripMenuItem.Checked = true;
            sortByToolStripMenuItem.Text = "Date";
            DisplayEntries();
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

        private void EntryListSortingButton_Click(object sender, EventArgs e)
        {
            if (SortInReverse)
            {
                EntryListSortingButton.Image = Properties.Resources.Down_Arrows;
            }
            else
            {
                EntryListSortingButton.Image = Properties.Resources.Up_Arrows;
            }
            SortInReverse = !SortInReverse;

            DisplayEntries();
        }

        public List<Button> GetEntryList()
        {
            List<Button> buttons = new List<Button>();
            List<DataEntry> dataEntries = new List<DataEntry>();

            if (userInfo.GetDataEntryCount() == 0) dataEntries = userInfo.GetDataEntryList("date");
            else dataEntries = userInfo.GetDataEntryList(sortType);
            if (!SortInReverse)
            {
                for (int i = 0; i < dataEntries.Count; i++) //Looping through normally
                {
                    buttons.Add(CreateButtonFromDataEntry(dataEntries[i]));
                }
            }
            else
            {
                for (int i = dataEntries.Count - 1; i >= 0; i--) //Looping through reversed
                {
                    buttons.Add(CreateButtonFromDataEntry(dataEntries[i]));
                }
            }
            return buttons;
        }

        private Button CreateButtonFromDataEntry(DataEntry d)
        {
            string s = d.Id + "| " + "$" + String.Format(d.Value % 1 == 0 ? "{0:F0}" : "{0:F2}", d.Value) + "\r\n" + d.Date + "\r\n" + d.Description + "\r\n" + d.TagsToString(d.Tags);
            Button b = new Button();
            b.Text = s;
            b.Click += (sender, e) => EntryButton_Click(sender, e, d);
            return b;
        }

        private void MainWindowActivated(object sender, EventArgs e)
        {
            Console.WriteLine(userInfo.GetDataEntryCount());
            DisplayEntries();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
               {
                    userInfo.LoadUserInfo(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            DisplayEntries();
            tagSearch.UpdateFilterTags();
            userInfoFile = openFileDialog1.FileName;
        }

        private void ValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortType = "value";
            UncheckSortByMenuItems();
            valueStripMenuItem.Checked = true;
            sortByToolStripMenuItem.Text = "Value";
            DisplayEntries();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userInfo.SaveUserInfo(userInfoFile);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void UncheckSortByMenuItems()
        {
            dateAddedToolStripMenuItem.Checked = false; //I need to figure out an iterative way to do this
            valueStripMenuItem.Checked = false;
            dateToolStripMenuItem.Checked = false;
        }

        private void SaveAs()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    userInfoFile = saveFileDialog1.FileName;
                    myStream.Close();
                    userInfo.SaveUserInfo(userInfoFile);
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(changesMade)
            {
                PromptToSave();
            }
        }

        private void ChangesMade()
        {
            changesMade = true;
        }

        private void PromptToSave()
        {
            SaveAs();
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
