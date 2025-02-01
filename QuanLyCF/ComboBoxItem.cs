using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboBoxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }

        // Override ToString to display the text in the ComboBox
        public override string ToString()
        {
            return Text;
        }
    }

}
