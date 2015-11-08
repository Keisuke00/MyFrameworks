using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFrameworks.Controls.ComboBoxes.PlaneComboBoxes
{
    public class PlaneComboBoxTestData
    {
        public IList<string> Items { get; set; }

        public PlaneComboBoxTestData()
        {
            Items = new List<string>() { " ", "0", "1", "2" };
        }
    }
}
