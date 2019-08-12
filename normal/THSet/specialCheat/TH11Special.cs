using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace THSet.specialCheat {
    public partial class TH11Special:UserControl {
        private bool init = true;
        public TH11Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            editText1.Text="信仰";
            if(init) {
                Name="th11initSpecial";
                editText1.Action=delegate () { MainForm.thCode.SetISpecial1(editText1.number); };
            } else {
                Name="th11Special";
                editText1.Action=delegate () { MainForm.thCode.SetSpecial1(editText1.number); };
            }
            TabIndex=29;
        }
    }
}
