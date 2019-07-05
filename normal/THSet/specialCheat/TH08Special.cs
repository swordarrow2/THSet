using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace THSet.specialCheat {
    public partial class TH08Special:UserControl {
        private bool init = true;
        public TH08Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            if(init) {
                Name="th08initSpecial";
            } else {
                Name="th08Special";
            }
            Size=new Size(200,128);
            TabIndex=29;
        }

        private void SelectChanged(object sender,EventArgs e) {
            MaterialRadioButton radioButton = (MaterialRadioButton)sender;
            if(radioButton.Checked) {
                switch(radioButton.Name) {
                    case "g1n":
                        if(init) { MainForm.thCode.SetISpecial1(0); } else { MainForm.thCode.SetSpecial1(1); }
                        break;
                    case "g1r":
                        if(init) { MainForm.thCode.SetISpecial1(1); } else { MainForm.thCode.SetSpecial1(1); }
                        break;
                    case "g1b":
                        if(init) { MainForm.thCode.SetISpecial1(2); } else { MainForm.thCode.SetSpecial1(2); }
                        break;
                    case "g1g":
                        if(init) { MainForm.thCode.SetISpecial1(3); } else { MainForm.thCode.SetSpecial1(3); }
                        break;
                    case "g2n":
                        if(init) { MainForm.thCode.SetISpecial2(0); } else { MainForm.thCode.SetSpecial2(0); }
                        break;
                    case "g2r":
                        if(init) { MainForm.thCode.SetISpecial2(1); } else { MainForm.thCode.SetSpecial2(1); }
                        break;
                    case "g2b":
                        if(init) { MainForm.thCode.SetISpecial2(2); } else { MainForm.thCode.SetSpecial2(2); }
                        break;
                    case "g2g":
                        if(init) { MainForm.thCode.SetISpecial2(3); } else { MainForm.thCode.SetSpecial2(3); }
                        break;
                }
            }
        }
    }
}
