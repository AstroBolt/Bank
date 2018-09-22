using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bank
{
    public class TagSearch
    {
        private UserInfo userInfo;
        private TableLayoutPanel mainTable = new TableLayoutPanel();
        private Label filterTypeLabel = new Label();
        private ComboBox filterTypeComboBox = new ComboBox();
        private Label tagSelectionLabel = new Label();
        private CheckedListBox tagSelectionBox = new CheckedListBox();
        private Button clearAllButton = new Button();
        private Button applyButton = new Button();
        private string currentFilterType = "Must have";
        private List<string> mustHaveList = new List<string>();
        private List<string> mustNotHaveList = new List<string>();
        private int prevSelectedIndex = 0;

        public TagSearch(ref UserInfo userInfo_)
        {
            userInfo = userInfo_;

            mainTable.RowCount = 2;
            mainTable.ColumnCount = 2;
            //mainTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single; //For cell visibility during testing
            mainTable.RowStyles.Add(new RowStyle() { Height = 25, SizeType = SizeType.Absolute });
            mainTable.RowStyles.Add(new RowStyle() { Height = 25, SizeType = SizeType.Absolute });
            mainTable.RowStyles.Add(new RowStyle() { Height = 25, SizeType = SizeType.Absolute });
            mainTable.RowStyles.Add(new RowStyle() { Height = 50, SizeType = SizeType.Percent });
            mainTable.RowStyles.Add(new RowStyle() { Height = 35, SizeType = SizeType.Absolute });
            mainTable.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);

            filterTypeLabel.Text = "TagSearchFilter";
            filterTypeLabel.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
            mainTable.Controls.Add(filterTypeLabel, 0, 0);
            mainTable.SetColumnSpan(filterTypeLabel, 2);

            filterTypeComboBox.Items.Add("Must have");
            filterTypeComboBox.Items.Add("Must not have");
            filterTypeComboBox.SelectedIndex = 0;
            filterTypeComboBox.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            filterTypeComboBox.SelectedIndexChanged += (sender, e) =>
            {
                SaveCheckedTags();
                prevSelectedIndex = filterTypeComboBox.SelectedIndex;

                for (int i = 0; i < tagSelectionBox.Items.Count; i++) tagSelectionBox.SetItemChecked(i, false);
                if (filterTypeComboBox.SelectedIndex == 0) currentFilterType = "Must have";
                else if (filterTypeComboBox.SelectedIndex == 1) currentFilterType = "Must not have";
                CheckTagsInList();
            };
            mainTable.Controls.Add(filterTypeComboBox, 0, 1);
            mainTable.SetColumnSpan(filterTypeComboBox, 2);

            tagSelectionLabel.Text = "Tag Selection";
            tagSelectionLabel.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
            mainTable.Controls.Add(tagSelectionLabel, 0, 2);
            mainTable.SetColumnSpan(tagSelectionLabel, 2);

            tagSelectionBox.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            mainTable.Controls.Add(tagSelectionBox, 0, 3);
            mainTable.SetColumnSpan(tagSelectionBox, 2);

            applyButton.Text = "Apply";
            applyButton.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            mainTable.Controls.Add(applyButton, 0, 4);

            clearAllButton.Text = "Clear All";
            clearAllButton.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            clearAllButton.Click += (sender, e) => 
            {
                if (currentFilterType == "Must have") mustHaveList.Clear();
                else if (currentFilterType == "Must not have") mustNotHaveList.Clear();
                for(int i = 0; i < tagSelectionBox.Items.Count; i++)
                {
                    tagSelectionBox.SetItemChecked(i, false);
                }
            }; //Finish this
            mainTable.Controls.Add(clearAllButton, 1, 4);
        }

        public TableLayoutPanel GetMainTable()
        {
            return mainTable;
        }

        public void UpdateFilterTags()
        {
            tagSelectionBox.Items.Clear();
            tagSelectionBox.Items.AddRange(userInfo.GetTagsArray());
        }

        public ref Button GetApplyButton()
        {
            return ref applyButton;
        }

        public void SaveCheckedTags()
        {
            ref List<string> list = ref GetList(currentFilterType);
            list.Clear();
            foreach (object o in tagSelectionBox.CheckedItems)
            {
                list.Add(o.ToString());
            }
        }

        public List<DataEntry> FilterDataEntries(List<DataEntry> dataEntries)
        {
            List<DataEntry> output = new List<DataEntry>();
            if (mustHaveList.Count == 0 && mustNotHaveList.Count == 0) return dataEntries; //Check if this is necessary
            foreach(DataEntry d in dataEntries)
            {
                if (PassesFilters(d)) output.Add(d);
            }


            return output;
        }

        public void CheckTagsInList()
        {
            for (int i = 0; i < tagSelectionBox.Items.Count; i++)
            {
                foreach (string s in GetList(currentFilterType))
                {
                    if (s == tagSelectionBox.Items[i].ToString()) tagSelectionBox.SetItemChecked(i, true);
                }
            }
        }

        private bool PassesFilters(DataEntry dataEntry)
        {
            bool doesHave = false;
            for(int i = 0; i < mustHaveList.Count; i++)
            {
                foreach (string s in dataEntry.Tags)
                {
                    if (mustHaveList[i] == s) doesHave = true;
                }
                if (!doesHave) return false;
                else doesHave = false;
            }

            for(int i = 0; i < mustNotHaveList.Count; i++)
            {
                foreach(string s in dataEntry.Tags)
                {
                    if (mustNotHaveList[i] == s) return false;
                }
            }

            return true;
        }

        private ref List<string> GetList(string list) //Returns the list associated with the string parameter
        {
            switch (list)
            {
                case "Must have":
                    return ref mustHaveList;
                case "Must not have":
                    return ref mustNotHaveList;
                default:
                    Console.WriteLine("GetList(): Invalid parameter");
                    return ref mustNotHaveList;
            }
        }
    }
}
