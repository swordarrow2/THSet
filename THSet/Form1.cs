using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public partial class Form1:Form {
        MemoryTool MemoryFunctions = new MemoryTool("th16");
        THDataManager t = new THDataManager(new TH16Code());
        public Form1() {
            InitializeComponent();
            this.Text=t.name+"正在运行";
        }

        private void lockPlayer_CheckedChanged(object sender,EventArgs e) {
            if(lockPlayer.Checked) {
                MemoryFunctions.WriteBytes(t.playerCode,t.lockPlayerCode1);
            } else {
                MemoryFunctions.WriteBytes(t.playerCode,t.lockPlayerCode0);
            }
        }
        private void lockBomb_CheckedChanged(object sender,EventArgs e) {
            if(lockBomb.Checked) {
                MemoryFunctions.WriteBytes(t.bombCode,t.lockBombCode1);
            } else {
                MemoryFunctions.WriteBytes(t.bombCode,t.lockBombCode0);
            }
        }

        private void label1_Click(object sender,EventArgs e) {
            MemoryFunctions.WriteInteger(t.player,8);
            label1.Text=Convert.ToString(MemoryFunctions.ReadInteger(t.player));
        }

        private void label2_Click(object sender,EventArgs e) {
            MemoryFunctions.WriteInteger(t.bomb,8);
            label2.Text=Convert.ToString(MemoryFunctions.ReadInteger(t.bomb));
        }
        private void btnPlayer_Click(object sender,EventArgs e) {
            MemoryFunctions.WriteInteger(t.player,Convert.ToInt32(tbPlayer.Text));
        }
        private void btnPlayerFragment_Click(object sender,EventArgs e) {
            MemoryFunctions.WriteInteger(t.playerFragment,Convert.ToInt32(tbPlayerFragment.Text));
        }
        private void btnBomb_Click(object sender,EventArgs e) {
            MemoryFunctions.WriteInteger(t.bomb,Convert.ToInt32(tbBomb.Text));
        }
        private void btnBombFragment_Click(object sender,EventArgs e) {
            MemoryFunctions.WriteInteger(t.bombFragment,Convert.ToInt32(tbBombFragment.Text));
        }
        private void btnPower_Click(object sender,EventArgs e) {
            MemoryFunctions.WriteInteger(t.power,Convert.ToInt32(tbPower.Text));
        }

        private void btnSeason_Click(object sender,EventArgs e) {
            MemoryFunctions.WriteInteger(t.special[0],Convert.ToInt32(tbSeason.Text));
        }

    }
}
