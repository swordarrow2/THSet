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
    public partial class TH128Special:UserControl {
        private bool init = true;
        public TH128Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            editText1.Text="蓄力";
            if(init) {
                Name="th128initSpecial";
                editText1.Action=delegate () { MainForm.thCode.SetISpecial1(editText1.number); };
            } else {
                Name="th128Special";
                editText1.Action=delegate () { MainForm.thCode.SetSpecial1(editText1.number); };
            }
            TabIndex=29;
        }
    }
}
