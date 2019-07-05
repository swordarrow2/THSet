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
    public partial class TH128Special:UserControl {
        private bool init = true;
        public TH128Special(int i) {
            init=i==1;
            InitializeComponent();
            Location=new Point(181,7);
            if(init) {
                Name="th128initSpecial";
            } else {
                Name="th128Special";
            }
            Size=new Size(200,128);
            TabIndex=29;
        }
    }
}
