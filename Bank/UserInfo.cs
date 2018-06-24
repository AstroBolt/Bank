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
        public UserInfo()
        {
        }

        public void AddDataEntry(DataEntry data)
        {
            data.Id = tagsCount++;
            //dataEntryByDate.Add(data);
            Console.WriteLine(dataEntryByDate.Add(data));
            //dataEntryByValue.Add(data);
            Console.WriteLine(dataEntryByValue.Add(data));
            Console.WriteLine("Added entry");
        }

        public void AddTag(string tagName) { tags.AddTag(tagName); }

        public List<DataEntry> GetDataEntryListByDate()
        {
            Console.WriteLine("Number of elements in DataEntry lists: " + dataEntryByDate.Count);
            return new List<DataEntry>(dataEntryByDate);
        }

        public List<DataEntry> GetDataEntryListByValue()
        {
            return new List<DataEntry>(dataEntryByValue);
        }

        public int GetDataEntryCount()
        {
            return dataEntryByDate.Count;
        }

        public string[] GetTagsArray() { return tags.GetArray(); }

        private Tags tags = new Tags();

        private SortedSet<DataEntry> dataEntryByDate = new SortedSet<DataEntry>(new ComparerDataEntryByDate());
        private SortedSet<DataEntry> dataEntryByValue = new SortedSet<DataEntry>(new ComparerDataEntryByValue());
        //private List<DataEntry> dataEntryByDateCreated = new List<DataEntry>();

        private int tagsCount = 0;
    }

    class ComparerDataEntryByDate : IComparer<DataEntry>
    {
        public int Compare(DataEntry left, DataEntry right)
        { 
            if (DateTime.Parse(left.Date).CompareTo(DateTime.Parse(right.Date)) == 0)
            {
                return 1;
            }
            return DateTime.Parse(left.Date).CompareTo(DateTime.Parse(right.Date));
        }
    }

    class ComparerDataEntryByValue : IComparer<DataEntry>
    {
        public int Compare(DataEntry left, DataEntry right)
        {
            if (left.Value == right.Value)
            {
                return 1;
            }
            return left.Value.CompareTo(right.Value);
        }
    }
    

    class Tags
    {

        public Tags()
        {
            //nextTagId.Enqueue(1);
        }


        public void AddTag(string t)
        {
                tags.Add(t);
        }

        public string[] GetArray()
        {
            List<string> tagsList = new List<string>();
            if (tags != null)
            {
                foreach (string tag in tags)
                {
                    tagsList.Add(tag);
                }
                return tagsList.ToArray();
            }
            return null;
        }

        public int GetCount()
        {
            return tags.Count;
        }

        private SortedSet<string> tags = new SortedSet<string>();
    }
}
