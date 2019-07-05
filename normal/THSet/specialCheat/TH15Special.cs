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
    public partial class TH15Special:UserControl {
        private bool init = true;
        public TH15Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            if(init) {
                Name="th15initSpecial";
            } else {
                Name="th15Special";
            }
            Size=new Size(200,128);
            TabIndex=29;
        }
    }
}
