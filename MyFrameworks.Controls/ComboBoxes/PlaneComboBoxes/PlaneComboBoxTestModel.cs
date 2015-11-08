using MyFrameworks.Controls.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFrameworks.Controls.ComboBoxes.PlaneComboBoxes
{
    class PlaneComboBoxTestModel : ControlModelBase
    {
        public PlaneComboBoxTestModel(ComboBox _combo) : base(_combo)
        {
            this.DataSource = new PlaneComboBoxTestData();
        }

        public override void OnBuildBindingsDefault(ControlBindingsCollection bindings, object source)
        {
            bindings.Clear();
            bindings.Add("DataSource", source, "Items");
        }
    }
}
