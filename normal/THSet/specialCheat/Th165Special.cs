using System.Drawing;
using System.Windows.Forms;

namespace THSet.specialCheat {
    public partial class TH165Special:UserControl {
        private bool init = true;
        public TH165Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            if(init) {
                Name="th165initSpecial";
            } else {
                Name="th165Special";
            }
            Size=new Size(200,128);
            TabIndex=29;
        }
    }
}
