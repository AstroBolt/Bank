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
        private bool SortInReverse = false;
        private string userInfoFile = string.Empty;
        private bool changesMade = true;
        private int currentTileIndex = 0;

        private List<TagSearchTypeTile> TagSearchTypeTileList = new List<TagSearchTypeTile>();

        private void Form1_Load(object sender, EventArgs e)
        {
            TagSearchTypeTileList.Add(new MustHaveTile(ref Tag_Search_checkedListBox));
            TagSearchTypeTileList.Add(new MustHaveNotTile(ref Tag_Search_checkedListBox));
            FilterTypeComboBox.SelectedIndex = 0;
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

        private void dateAddedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortType = "dateCreated";
            UncheckSortByMenuItems();
            dateAddedToolStripMenuItem.Checked = true;
            sortByToolStripMenuItem.Text = "Date added";
            DisplayEntries();
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ResetFilterTags()
        {
            Tag_Search_checkedListBox.Items.AddRange(userInfo.GetTagsArray());
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
            if (sortType == "date")
            {
                dataEntries = userInfo.GetDataEntryListByDate();
            }
            else if (sortType == "value")
            {
                dataEntries = userInfo.GetDataEntryListByValue();
            }
            else if (sortType == "dateCreated")
            {
                dataEntries = userInfo.GetDataEntryListByDateCreated();
            }
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

            //Filter entries based on tag filtering

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
                //try
               //{
                    userInfo.LoadUserInfo(openFileDialog1.FileName);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                //}
            }
            DisplayEntries();
            ResetFilterTags();
            userInfoFile = openFileDialog1.FileName;
        }

        private void valueToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void FilterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Tag_Search_Table.Controls.Remove(TagSearchTypeTileList[currentTileIndex].GetTile());
            currentTileIndex = FilterTypeComboBox.SelectedIndex;
            Tag_Search_Table.Controls.Add(TagSearchTypeTileList[currentTileIndex].GetTile(), 2, 1);
            TagSearchTypeTileList[currentTileIndex].isDisplayed = true;
            TagSearchTypeTileList[currentTileIndex].RefreshTags();
        }
    }

    //A tile that will specify either a "must-have" list of tags, or "either-or" list of tags to filter the entries by
    //Can be one of "must_have", "at_least_one", or "only_one" types.
    //"must_have" means that the entry must have every tag specified.
    //"at_least_one" means that the entry must have at least one of the tags specified.
    //"only_one" means that the entry must have at most one of the group of tags specified.
    public class TagSearchTypeTile
    {
        public bool isDisplayed = false;

        protected Label FilterTypeLabel = new Label();
        protected TableLayoutPanel mainTable = new TableLayoutPanel();

        private Button ClearAllButton = new Button();
        private Button DeleteFilterButton = new Button();
        protected CheckedListBox checkedListBox;
        private List<string> tags = new List<string>(); //Change back to private
        private List<string> tagWhiteList;
        private List<string> tagBlackList = new List<string>();

        public TagSearchTypeTile(ref CheckedListBox checkedListBox_) 
        {
            //Initialization
            mainTable.RowCount = 3;
            mainTable.ColumnCount = 2;
            checkedListBox = checkedListBox_;
            checkedListBox.CheckOnClick = true;
            tagWhiteList = tags;
            InitializeClearAllButton();
            InitializeEvents();

            //Add the controls to the tile
            mainTable.Controls.Add(FilterTypeLabel, 0, 0);
            mainTable.Controls.Add(ClearAllButton, 0, 2);



        }

        public TableLayoutPanel GetTile()
        {
            return mainTable;
        }

        public void AddTag(string tag)
        {
            tags.Add(tag);
            UpdateSearch();
        }

        public void RefreshTags()
        {
            UpdateSelectedTags();
        }

        private void InitializeClearAllButton()
        {
            ClearAllButton.Text = "Clear all";
            ClearAllButton.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
            ClearAllButton.Click += (sender, e) =>
            {
                tags.Clear();
                UpdateSelectedTags();
            };
        }

        protected void InitializeDeleteFilterButton()
        {
            DeleteFilterButton.Image = Properties.Resources.Exit_Up;
            DeleteFilterButton.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
            DeleteFilterButton.Width = 16;
            DeleteFilterButton.Height = 16;
            DeleteFilterButton.FlatStyle = FlatStyle.Flat;
            DeleteFilterButton.ImageAlign = ContentAlignment.MiddleCenter;
            DeleteFilterButton.FlatAppearance.BorderSize = 0;
            DeleteFilterButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void InitializeEvents()
        {
            checkedListBox.SelectedIndexChanged += (sender, e) => //When a tag is checked, update the search results
            {
                if (isDisplayed == true)
                {
                    tags.Clear();
                    foreach (object itemChecked in checkedListBox.CheckedItems)
                    {
                        tags.Add(itemChecked.ToString());
                    }
                    UpdateSearch();
                }
            };
        }

        private void UpdateSelectedTags() //Loads the tags that are checked for this tile
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++) checkedListBox.SetItemChecked(i, false);

            if (checkedListBox.Items.Count != 0)
            {
                for(int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    foreach(string s in tags)
                    {
                        if (s == checkedListBox.Items[i].ToString()) checkedListBox.SetItemChecked(i, true);
                    }
                }

            }
        }

        private void UpdateSearch()
        {

        }
    }

    public class MustHaveTile : TagSearchTypeTile
    {
        public MustHaveTile(ref CheckedListBox checkedListBox_) : base(ref checkedListBox_)
        {
            /*
            checkedListBox.ItemCheck += (sender, e) =>
            {
                Console.WriteLine("Child");
            };
            */
            FilterTypeLabel.Text = "Must have";
        }
    }

    public class MustHaveNotTile : TagSearchTypeTile
    {
        public MustHaveNotTile(ref CheckedListBox checkedListBox_) : base(ref checkedListBox_)
        {
            FilterTypeLabel.Text = "Must not have";
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
