using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; //For buttons

namespace Bank
{
    public class UserInfo
    {
        public string[] GetTagsArray() { return tags.GetArray(); }
        public int GetKey(string s)
        {
            return tags.GetKey(s);
        }
        public List<Button> GetEntryList()
        {
            List<Button> buttons = new List<Button>();
            foreach(DataEntry d in dataEntryList)
            {
                string s = d.Id + "| " + "$" + d.Value + "\r\n" + d.TimeStamp + "\r\n" + d.Description + "\r\n" + d.TagsToString(d.Tags);
                Button b = new Button();
                b.Text = s;
                b.Click += (sender, e) => EntryButton_Click(sender, e, d);
                buttons.Add(b);
            }
            return buttons;
        }
        public void AddTag(string tagName) { tags.AddTag(tagName); }
        public void AddDataEntry(DataEntry data)
        {
            data.Id = dataEntryList.Count; //Definately going to have to change this, if not overwriting will occur
            dataEntryList.Add(data);

        }
        public UserInfo()
        {
        }

        private Tags tags = new Tags();
        private List<DataEntry> dataEntryList = new List<DataEntry>();

        private void EntryButton_Click(object sender, EventArgs e, DataEntry dataEntry)
        {
            EditDataEntryForm EDEForm = new EditDataEntryForm(this, ref dataEntry);
            EDEForm.ShowDialog();
            //Open form to edit entry
                //Be able to scroll up and down through entries in form

        }
    }

    class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private int id = -1;
        private string name = string.Empty;
    }

    class Tags
    {

        public Tags()
        {
            //nextTagId.Enqueue(1);
        }


        public void AddTag(string t)
        {
            Tag newTag = new Tag();
            newTag.Name = t;
            newTag.Id = GetNextAvailableTagId();
            if (!DuplicateTag(newTag))
            {
                tags.Add(newTag.Id, newTag);
            }
        }

        public string ConvertKeysToTagStrings(List<int> keys)
        {
            string s = "";
            foreach (int k in keys)
            {
                s += tags[k].Name + "|";
            }
            return s;
        }

        public List<string> ConvertKeysToTags(List<int> keys)
        {
            List<string> t = new List<string>();
            foreach (int k in keys)
            {
                t.Add(tags[k].Name);
            }
            return t;
        }

        public string[] GetArray()
        {
            List<string> tagsList = new List<string>();
            if (tags != null)
            {
                foreach (Tag value in tags.Values)
                {
                    tagsList.Add(value.Name);
                }
                return tagsList.ToArray();
            }
            return null;
        }

        public int GetKey(string s)
        {
            foreach (KeyValuePair<int, Tag> t in tags)
            {
                if (s == t.Value.Name) return t.Key;
            }
            return -1;
        }

        public void RemoveTag(Tag t)
        {
            nextTagId.Enqueue(t.Id);
            tags.Remove(t.Id);
        }

        private Dictionary<int, Tag> tags = new Dictionary<int, Tag>();
        private Queue<int> nextTagId = new Queue<int>();

        private bool DuplicateTag(Tag tag)
        {
            foreach(KeyValuePair<int, Tag> t in tags)
            {
                if (t.Value.Name == tag.Name)
                {
                    return true;
                }
            }
            return false;
        }

        private int GetNextAvailableTagId()
        {
            if (nextTagId.Count != 0) return(nextTagId.Dequeue());
            else return(tags.Count);
        }
    }
}
