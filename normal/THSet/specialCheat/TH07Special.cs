﻿using System.Drawing;
using System.Windows.Forms;

namespace THSet.specialCheat {
    public partial class TH07Special:UserControl {
        private bool init = true;
        public TH07Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            editText1.Text="分子";
            editText2.Text="分母";
            editText3.Text="樱+";
            editText4.Text="收卡数";
            if(init) {
                Name="th17initSpecial";
                editText1.Action=delegate () { MainForm.thCode.SetISpecial1(editText1.number); };
                editText2.Action=delegate () { MainForm.thCode.SetISpecial2(editText2.number); };
                editText3.Action=delegate () { MainForm.thCode.SetISpecial3(editText3.number); };
                editText4.Action=delegate () { MainForm.thCode.SetISpecial4(editText4.number); };
            } else {
                Name="th17Special";
                editText1.Action=delegate () { MainForm.thCode.SetSpecial1(editText1.number); };
                editText2.Action=delegate () { MainForm.thCode.SetSpecial2(editText2.number); };
                editText3.Action=delegate () { MainForm.thCode.SetSpecial3(editText3.number); };
                editText4.Action=delegate () { MainForm.thCode.SetSpecial4(editText4.number); };
            }
            TabIndex=29;
        }
    }
}
