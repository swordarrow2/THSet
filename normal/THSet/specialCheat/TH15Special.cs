using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THSet.specialCheat {
    public partial class TH15Special:UserControl {
        private bool init = true;
        public TH15Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            editText1.Text="当前章节擦弹";
            if(init) {
                Name="th15initSpecial";
                editText1.Action=delegate () { MainForm.thCode.SetISpecial1(editText1.number); };
            } else {
                Name="th15Special";
                editText1.Action=delegate () { MainForm.thCode.SetSpecial1(editText1.number); };
            }
            TabIndex=29;
        }
    }
}
