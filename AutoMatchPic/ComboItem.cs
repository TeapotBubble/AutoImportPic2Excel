using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMatchPic
{
    class ComboItem
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public int Column { get; set; }
        public ComboItem(string key, string value, int column)
        {
            Key = key; Value = value; Column = column;
        }
        //public override string ToString()
        //{
        //    return Value;
        //}
    }
}
