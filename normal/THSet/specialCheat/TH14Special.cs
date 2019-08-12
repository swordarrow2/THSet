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
    public partial class TH14Special:UserControl {
        private bool init = true;
        public TH14Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            editText1.Text="非2.0次数";
            editText2.Text="已得奖残";
            if(init) {
                Name="th14initSpecial";
                editText1.Action=delegate () { MainForm.thCode.SetISpecial1(editText1.number); };
                editText2.Action=delegate () { MainForm.thCode.SetISpecial2(editText2.number); };
            } else {
                Name="th14Special";
                editText1.Action=delegate () { MainForm.thCode.SetSpecial1(editText1.number); };
                editText2.Action=delegate () { MainForm.thCode.SetSpecial2(editText2.number); };
            }
            TabIndex=29;
        }
    }
}
