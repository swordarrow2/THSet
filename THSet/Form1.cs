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
        THCode tc = new TH16Code();
        public Form1() {
            InitializeComponent();
            this.Text=tc.getName();
            bool[] enable = tc.getEnable();
            lockPlayer.Enabled=enable[0];
            lockBomb.Enabled=enable[1];
            tbPlayer.Enabled=btnPlayer.Enabled=tbIPlayer.Enabled=btnIPlayer.Enabled=enable[2];
            tbPlayerFragment.Enabled=btnPlayerFragment.Enabled=tbIPlayerFragment.Enabled=btnIPlayerFragment.Enabled=enable[3];
            tbBomb.Enabled=btnBomb.Enabled=tbIBomb.Enabled=btnIBomb.Enabled=enable[4];
            tbBombFragment.Enabled=btnBombFragment.Enabled=tbIBombFragment.Enabled=btnIBombFragment.Enabled=enable[5];
            tbPower.Enabled=btnPower.Enabled=tbIPower.Enabled=btnIPower.Enabled=enable[6];
            tbSpecial1.Enabled=btnSpecial1.Enabled=tbISpecial1.Enabled=btnISpecial1.Enabled=enable[7];
            tbSpecial2.Enabled=btnSpecial2.Enabled=tbISpecial2.Enabled=btnISpecial2.Enabled=enable[8];
            tbSpecial3.Enabled=btnSpecial3.Enabled=tbISpecial3.Enabled=btnISpecial3.Enabled=enable[9];
            lbSpecialTip.Text=lbISpecialTip.Text=tc.getSpecialTip();
        }

        private void lockPlayer_CheckedChanged(object sender,EventArgs e) {
            tc.setLockPlayer(lockPlayer.Checked);
        }
        private void lockBomb_CheckedChanged(object sender,EventArgs e) {
            tc.setLockBomb(lockBomb.Checked);
        }
        private void choice_CheckedChanged(object sender,EventArgs e) {
            tc.setChoice(choice.Checked);
        }
        private void btnPlayer_Click(object sender,EventArgs e) {
            tc.setPlayer(Convert.ToInt32(tbPlayer.Text));
        }
        private void btnPlayerFragment_Click(object sender,EventArgs e) {
            tc.setPlayerFragment(Convert.ToInt32(tbPlayerFragment.Text));
        }
        private void btnBomb_Click(object sender,EventArgs e) {
            tc.setBomb(Convert.ToInt32(tbBomb.Text));
        }
        private void btnBombFragment_Click(object sender,EventArgs e) {
            tc.setBombFragment(Convert.ToInt32(tbBombFragment.Text));
        }
        private void btnPower_Click(object sender,EventArgs e) {
            tc.setPower(Convert.ToInt32(tbPower.Text));
        }
        private void btnSpecial1_Click(object sender,EventArgs e) {
            tc.setSpecial1(Convert.ToInt32(tbSpecial1.Text));
        }
        private void btnSpecial2_Click(object sender,EventArgs e) {
            tc.setSpecial2(Convert.ToInt32(tbSpecial2.Text));
        }
        private void btnSpecial3_Click(object sender,EventArgs e) {
            tc.setSpecial3(Convert.ToInt32(tbSpecial3.Text));
        }

        private void btnIPlayer_Click(object sender,EventArgs e) {
            tc.setIPlayer(Convert.ToByte(tbIPlayer.Text));
        }
        private void btnIPlayerFragment_Click(object sender,EventArgs e) {
            tc.setIPlayerFragment(Convert.ToByte(tbIPlayerFragment.Text));
        }
        private void btnIBomb_Click(object sender,EventArgs e) {
            tc.setIBomb(Convert.ToByte(tbIBomb.Text));
        }
        private void btnIBombFragment_Click(object sender,EventArgs e) {
            tc.setIBombFragment(Convert.ToByte(tbIBombFragment.Text));
        }
        private void btnIPower_Click(object sender,EventArgs e) {
            tc.setIPower(Convert.ToInt32(tbIPower.Text));
        }
        private void btnISpecial1_Click(object sender,EventArgs e) {
            tc.setISpecial1(Convert.ToInt32(tbISpecial1.Text));
        }
        private void btnISpecial2_Click(object sender,EventArgs e) {
            tc.setISpecial2(Convert.ToByte(tbISpecial2.Text));
        }
        private void btnISpecial3_Click(object sender,EventArgs e) {
            tc.setISpecial3(Convert.ToByte(tbISpecial3.Text));
        }

    }
}
