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
        public List<int> TagKeys { get; set; }

        public DataEntry() { }
        public DataEntry(double _value, string _timeStamp, string _description, List<int> _tagKeys)
        {
            value = _value;
            timeStamp = _timeStamp;
            description = _description;
            tagKeys = _tagKeys;
        }

        private int id = -1;
        private double value = 0;
        private string timeStamp = string.Empty;
        private string description = string.Empty;
        private List<int> tagKeys;
    }
}
