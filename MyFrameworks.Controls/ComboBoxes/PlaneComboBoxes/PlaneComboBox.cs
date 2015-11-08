using MyFrameworks.Controls.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFrameworks.Controls.ComboBoxes.PlaneComboBoxes
{
    public class PlaneComboBox : ComboBox
    {
        private ControlModelBase model;

        public PlaneComboBox()
        {
            // 以下、デザインモード時は実行せず
            if (Process.GetCurrentProcess().ProcessName.ToUpper().Equals("DEVENV"))
                return;

            model = new PlaneComboBoxTestModel(this);
        }

        
    }
}
