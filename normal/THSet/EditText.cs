using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THSet {
    public partial class EditText:UserControl {
        private Action action;

        public Action Action {
            set => action=value;
        }

        public override string Text {
            get => MDText.Text;
            set => MDText.Hint=value;
        }

        public Int32 number {
            get {
                if(MDText.Text.Equals("")) {
                    return 0;
                } else {
                    return Convert.ToInt32(MDText.Text);
                }
            }
            set => MDText.Hint=Convert.ToString(value);
        }
        public EditText() {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender,EventArgs e) {
            action();
        }

    }
}
