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
        public decimal Value { get; set; }
        public DateTime DateCreated { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }

        public DataEntry() { }
        public DataEntry(decimal _value, string _date, string _description, List<string> _tags)
        {
            value = _value;
            dateCreated = DateTime.Now;
            date = _date;
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
        private decimal value = 0;
        private DateTime dateCreated = DateTime.Now;
        private string date = string.Empty;
        private string description = string.Empty;
        private List<string> tags = new List<string>();
    }
}
