using System.Drawing;
using System.Windows.Forms;

namespace THSet.specialCheat {
    public partial class TH07Special:UserControl {
        private bool init = true;
        public TH07Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            if(init) {
                Name="th07initSpecial";
            } else {
                Name="th07Special";
            }
            Size=new Size(200,128);
            TabIndex=29;
        }
    }
}
