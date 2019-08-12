using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace THSet.specialCheat {
    public partial class TH12Special:UserControl {
        private bool init = true;
        public TH12Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            if(init) {
                Name="th12initSpecial";
            } else {
                Name="th12Special";
            }
            TabIndex=29;
        }

        private void SelectChanged(object sender,EventArgs e) {
            MaterialRadioButton radioButton = (MaterialRadioButton)sender;
            if(radioButton.Checked) {
                if(init) {
                    switch(radioButton.Name) {
                        case "g1n":
                            MainForm.thCode.SetISpecial1(0);
                            break;
                        case "g1r":
                            MainForm.thCode.SetISpecial1(1);
                            break;
                        case "g1b":
                            MainForm.thCode.SetISpecial1(2);
                            break;
                        case "g1g":
                            MainForm.thCode.SetISpecial1(3);
                            break;
                        case "g2n":
                            MainForm.thCode.SetISpecial2(0);
                            break;
                        case "g2r":
                            MainForm.thCode.SetISpecial2(1);
                            break;
                        case "g2b":
                            MainForm.thCode.SetISpecial2(2);
                            break;
                        case "g2g":
                            MainForm.thCode.SetISpecial2(3);
                            break;
                    }
                } else {
                    switch(radioButton.Name) {
                        case "g1n":
                            MainForm.thCode.SetSpecial1(1);
                            break;
                        case "g1r":
                            MainForm.thCode.SetSpecial1(1);
                            break;
                        case "g1b":
                            MainForm.thCode.SetSpecial1(2);
                            break;
                        case "g1g":
                            MainForm.thCode.SetSpecial1(3);
                            break;
                        case "g2n":
                            MainForm.thCode.SetSpecial2(0);
                            break;
                        case "g2r":
                            MainForm.thCode.SetSpecial2(1);
                            break;
                        case "g2b":
                            MainForm.thCode.SetSpecial2(2);
                            break;
                        case "g2g":
                            MainForm.thCode.SetSpecial2(3);
                            break;
                    }
                }
            }
        }
    }
}
