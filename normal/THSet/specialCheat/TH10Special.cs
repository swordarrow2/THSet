using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace THSet.specialCheat {
    public partial class TH10Special:UserControl {
        private bool init = true;
        public TH10Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            editText1.Text="信仰";
            if(init) {
                Name="th10initSpecial";
                editText1.Action=delegate () { MainForm.thCode.SetISpecial1(editText1.number); };
            } else {
                Name="th10Special";
                editText1.Action=delegate () { MainForm.thCode.SetSpecial1(editText1.number); };
            }
            Size=new Size(200,128);
            TabIndex=29;
        }
    }
}
