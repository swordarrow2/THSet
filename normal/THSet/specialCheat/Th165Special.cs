using System.Drawing;
using System.Windows.Forms;

namespace THSet.specialCheat {
    public partial class TH165Special:UserControl {
        private bool init = true;
        public TH165Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            editText1.Text="拍照蓄力";
            if(init) {
                Name="th165initSpecial";
                editText1.Action=delegate () { MainForm.thCode.SetISpecial1(editText1.number); };
            } else {
                Name="th165Special";
                editText1.Action=delegate () { MainForm.thCode.SetSpecial1(editText1.number); };
            }
            TabIndex=29;
        }
    }
}
