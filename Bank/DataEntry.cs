using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class DataEntry
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public string TimeStamp { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }

        public DataEntry() { }
        public DataEntry(double _value, string _timeStamp, string _description, List<string> _tags)
        {
            value = _value;
            timeStamp = _timeStamp;
            description = _description;
            tags = _tags;
        }

        public string TagsToString(List<string> listStrings)
        {
            string tagsString = string.Empty;
            if(listStrings.Count != 0)
            {
                foreach(string s in listStrings)
                {
                    tagsString += s + " | ";
                }
            }
            return tagsString;
        }

        private int id = -1;
        private double value = 0;
        private string timeStamp = string.Empty;
        private string description = string.Empty;
        private List<string> tags = new List<string>();
    }
}
