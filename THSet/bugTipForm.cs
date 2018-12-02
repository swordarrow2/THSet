using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public partial class bugTipForm:Form {
        public bugTipForm() {
            InitializeComponent();
        }
        public bugTipForm(string text) {
            InitializeComponent();
            label1.Text=text;
        }

        private void bugTipForm_Load(object sender,EventArgs e) {

        }
    }
}
