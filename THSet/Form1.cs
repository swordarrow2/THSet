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
            this.Text=t.name;
            bool[] enable = t.enable;
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
            lbSpecialTip.Text=lbISpecialTip.Text=t.specialTip;
        }

        private void lockPlayer_CheckedChanged(object sender,EventArgs e) {
            write(t.playerCode,lockPlayer.Checked ? t.lockPlayerCode1 : t.lockPlayerCode0);
        }
        private void lockBomb_CheckedChanged(object sender,EventArgs e) {
            write(t.bombCode,lockBomb.Checked ? t.lockBombCode1 : t.lockBombCode0);
        }
        private void btnPlayer_Click(object sender,EventArgs e) {
            write(t.player,Convert.ToInt32(tbPlayer.Text));
        }
        private void btnPlayerFragment_Click(object sender,EventArgs e) {
            write(t.playerFragment,Convert.ToInt32(tbPlayerFragment.Text));
        }
        private void btnBomb_Click(object sender,EventArgs e) {
            write(t.bomb,Convert.ToInt32(tbBomb.Text));
        }
        private void btnBombFragment_Click(object sender,EventArgs e) {
            write(t.bombFragment,Convert.ToInt32(tbBombFragment.Text));
        }
        private void btnPower_Click(object sender,EventArgs e) {
            write(t.power,Convert.ToInt32(tbPower.Text));
        }
        private void btnSpecial1_Click(object sender,EventArgs e) {
            write(t.special[0],Convert.ToInt32(tbSpecial1.Text));
        }
        private void btnSpecial2_Click(object sender,EventArgs e) {
            write(t.special[1],Convert.ToInt32(tbSpecial2.Text));
        }
        private void btnSpecial3_Click(object sender,EventArgs e) {
            write(t.special[2],Convert.ToInt32(tbSpecial3.Text));
        }
        private void btnIPlayer_Click(object sender,EventArgs e) {
            write(t.Iplayer,t.IplayerCode,Convert.ToByte(tbIPlayer.Text));
        }
        private void btnIPlayerFragment_Click(object sender,EventArgs e) {
            write(t.IplayerFragment,t.IplayerFragmentCode,Convert.ToByte(tbIPlayerFragment.Text));
        }
        private void btnIBomb_Click(object sender,EventArgs e) {
            write(t.Ibomb,t.IbombCode,Convert.ToByte(tbIBomb.Text));
        }
        private void btnIBombFragment_Click(object sender,EventArgs e) {

        }
        private void btnIPower_Click(object sender,EventArgs e) {

        }
        private void btnISpecial1_Click(object sender,EventArgs e) {

        }
        private void btnISpecial2_Click(object sender,EventArgs e) {

        }
        private void btnISpecial3_Click(object sender,EventArgs e) {

        }
        private void write(int addr,int value) {
            MemoryFunctions.WriteInteger(addr,value);
        }
        private void write(int addr,byte[] value) {
            MemoryFunctions.WriteBytes(addr,value);
        }
        private void write(int addr,byte[] opCode,byte value2) {
            List<byte> tmp = opCode.ToList();
            tmp.Add(value2);
            MemoryFunctions.WriteBytes(addr,tmp.ToArray());
        }
    }
}
