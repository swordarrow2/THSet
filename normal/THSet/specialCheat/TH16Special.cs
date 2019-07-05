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
    public partial class TH16Special:UserControl {
        private bool init = true;
        public TH16Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            if(init) {
                Name="th16initSpecial";
            } else {
                Name="th16Special";
            }
            Size=new Size(200,128);
            TabIndex=29;
        }
    }
}
