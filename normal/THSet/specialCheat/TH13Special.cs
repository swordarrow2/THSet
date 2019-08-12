using System.Drawing;
using System.Windows.Forms;

namespace THSet.specialCheat {
    public partial class TH13Special:UserControl {
        private bool init = true;
        public TH13Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            editText1.Text="灵界槽(0-600)";
            editText2.Text="已得奖残";
            if(init) {
                Name="th13initSpecial";
                editText1.Action=delegate () { MainForm.thCode.SetISpecial1(editText1.number); };
                editText2.Action=delegate () { MainForm.thCode.SetISpecial2(editText2.number); };
            } else {
                Name="th13Special";
                editText1.Action=delegate () { MainForm.thCode.SetSpecial1(editText1.number); };
                editText2.Action=delegate () { MainForm.thCode.SetSpecial2(editText2.number); };
            }
            TabIndex=29;
        }
    }
}
