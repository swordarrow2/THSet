using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public partial class MainForm:Form {
        THCode tc;
        public MainForm() {
            InitializeComponent();
            string[] names = new string[] { "th10","th10c","th11","th11c","th12","th12c","th128","th128_CN","th13","th13c","th14","th15","th16" };
            int pid = 0;
            int index = 0;
            for(;index<names.Length;index++) {
                pid=GetPID(names[index]);
                if(pid!=0) { break; }
            }
            if(pid==0) {
                MessageBox.Show("没有发现支持的车万进程\n目前支持TH10,11,12,12.8,13,14,15,16","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                System.Environment.Exit(System.Environment.ExitCode);
            }
            switch(index) {
                case 0:
                case 1:
                    tc=new TH10Code();
                    break;
                case 2:
                case 3:
                    tc=new TH11Code();
                    break;
                case 4:
                case 5:
                    tc=new TH12Code();
                    break;
                case 6:
                case 7:
                    tc=new TH128Code();
                    break;
                case 8:
                case 9:
                    tc=new TH13Code();
                    break;
                case 10:
                    tc=new TH14Code();
                    break;
                case 11:
                    tc=new TH15Code();
                    //Imports.FindGameProcess(pid);
                    break;
                case 12:
                    tc=new TH16Code();
                    break;
            }
            tc.setMemoryTool(new MemoryTool(names[index]));

            this.Text=tc.getTitle();
            bool[] enable = tc.getEnable();
            string[] sptip = tc.getSpecialTip();
            string[] d = tc.getDefaultValue();
            lockPlayer.Enabled=enable[0];
            lockBomb.Enabled=enable[1];
            choice.Enabled=enable[2];
            tbPlayer.Enabled=btnPlayer.Enabled=tbIPlayer.Enabled=btnIPlayer.Enabled=enable[3];
            tbPlayerFragment.Enabled=btnPlayerFragment.Enabled=tbIPlayerFragment.Enabled=btnIPlayerFragment.Enabled=enable[4];
            tbBomb.Enabled=btnBomb.Enabled=tbIBomb.Enabled=btnIBomb.Enabled=enable[5];
            tbBombFragment.Enabled=btnBombFragment.Enabled=tbIBombFragment.Enabled=btnIBombFragment.Enabled=enable[6];
            tbPower.Enabled=btnPower.Enabled=tbIPower.Enabled=btnIPower.Enabled=enable[7];
            tbScore.Enabled=btnScore.Enabled=tbIScore.Enabled=btnIScore.Enabled=enable[8];
            tbMaxPoint.Enabled=btnMaxPoint.Enabled=tbIMaxPoint.Enabled=btnIMaxPoint.Enabled=enable[9];
            lbSp1.Enabled=tbSpecial1.Enabled=btnSpecial1.Enabled=lbISp1.Enabled=tbISpecial1.Enabled=btnISpecial1.Enabled=btnReadSpecial1.Enabled=enable[10];
            lbSp2.Enabled=tbSpecial2.Enabled=btnSpecial2.Enabled=lbISp2.Enabled=tbISpecial2.Enabled=btnISpecial2.Enabled=btnReadSpecial2.Enabled=enable[11];
            lbSp3.Enabled=tbSpecial3.Enabled=btnSpecial3.Enabled=lbISp3.Enabled=tbISpecial3.Enabled=btnISpecial3.Enabled=btnReadSpecial3.Enabled=enable[12];
            lbFPS.Enabled=tbFPS.Enabled=btnFPS.Enabled=trackBar_FPS.Enabled=enable[13];
            lbSp1.Text=lbISp1.Text=sptip[0].Equals("") ? "不可用" : sptip[0];
            lbSp2.Text=lbISp2.Text=sptip[1].Equals("") ? "不可用" : sptip[1];
            lbSp3.Text=lbISp3.Text=sptip[2].Equals("") ? "不可用" : sptip[2];
            tbSpecial1.Text=tbISpecial1.Text=d[0];
            tbSpecial2.Text=tbISpecial2.Text=d[1];
            tbSpecial3.Text=tbISpecial3.Text=d[2];
            if(GetPID("th128_CN")!=0||GetPID("th128")!=0) {
                tbIPower.Enabled=btnIPower.Enabled=tbIPower.Enabled=btnIPower.Enabled=tbIScore.Enabled=btnIScore.Enabled=false;
            }
        }

        private void lockPlayer_CheckedChanged(object sender,EventArgs e) {
            tc.setLockPlayer(lockPlayer.Checked);
        }
        private void lockBomb_CheckedChanged(object sender,EventArgs e) {
            tc.setLockBomb(lockBomb.Checked);
        }
        private void choice_CheckedChanged(object sender,EventArgs e) {
            tc.setUnbeatable(choice.Checked);
        }
        private void btnFPS_Click(object sender,EventArgs e) {
            tc.setFPS(Convert.ToInt32(tbFPS.Text));
        }
        private void trackBar_FPS_Scroll(object sender,EventArgs e) {
            tbFPS.Text=Convert.ToString(trackBar_FPS.Value);
            tc.setFPS(Convert.ToInt32(tbFPS.Text));
        }
        private void btnPlayer_Click(object sender,EventArgs e) {
            //  Imports.SetPlayer(Convert.ToInt32(tbPlayer.Text));
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
        private void btnScore_Click(object sender,EventArgs e) {
            tc.setScore(Convert.ToInt32(tbScore.Text));
        }
        private void btnMaxPoint_Click(object sender,EventArgs e) {
            tc.setMaxPoint(Convert.ToInt32(tbMaxPoint.Text));
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
        private void btnReadSpecial1_Click(object sender,EventArgs e) {
            tbSpecial1.Text=Convert.ToString(tc.getSpecial1());
        }
        private void btnReadSpecial2_Click(object sender,EventArgs e) {
            tbSpecial2.Text=Convert.ToString(tc.getSpecial2());
        }
        private void btnReadSpecial3_Click(object sender,EventArgs e) {
            tbSpecial3.Text=Convert.ToString(tc.getSpecial3());
        }
        private void btnIPlayer_Click(object sender,EventArgs e) {
            tc.setIPlayer(Convert.ToInt32(tbIPlayer.Text));
        }
        private void btnIPlayerFragment_Click(object sender,EventArgs e) {
            tc.setIPlayerFragment(Convert.ToInt32(tbIPlayerFragment.Text));
        }
        private void btnIBomb_Click(object sender,EventArgs e) {
            tc.setIBomb(Convert.ToInt32(tbIBomb.Text));
        }
        private void btnIBombFragment_Click(object sender,EventArgs e) {
            tc.setIBombFragment(Convert.ToInt32(tbIBombFragment.Text));
        }
        private void btnIPower_Click(object sender,EventArgs e) {
            tc.setIPower(Convert.ToInt32(tbIPower.Text));
        }
        private void btnIScore_Click(object sender,EventArgs e) {
            tc.setIScore(Convert.ToInt32(tbIScore.Text));
        }
        private void btnIMaxPoint_Click(object sender,EventArgs e) {
            tc.setIMaxPoint(Convert.ToInt32(tbIMaxPoint.Text));
        }
        private void btnISpecial1_Click(object sender,EventArgs e) {
            tc.setISpecial1(Convert.ToInt32(tbISpecial1.Text));
        }
        private void btnISpecial2_Click(object sender,EventArgs e) {
            tc.setISpecial2(Convert.ToInt32(tbISpecial2.Text));
        }
        private void btnISpecial3_Click(object sender,EventArgs e) {
            tc.setISpecial3(Convert.ToInt32(tbISpecial3.Text));
        }
        private void showBug_Click(object sender,EventArgs e) {
            MessageBox.Show(tc.getAboutBug(),"",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void button2_Click(object sender,EventArgs e) {
            MessageBox.Show(tc.getAboutSpecial(),"",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void note_Click(object sender,EventArgs e) {
            MessageBox.Show("这个修改器主要为原版程序设计，如果你使用了修改过的游戏，可能有功能不正常.\n\n即时修改页为游戏中的当前数值，修改内容不会记录到录像中，有些数值修改后不会立刻显示(如残机),但值确实是已经改变了\n\n"+
                "Init页修改的为各项的初始值，修改内容会记录到录像中。此部分修改尽量不要和THInit同时使用，可能会造成游戏爆炸"+
                "\n\n注意：如果重启游戏需重启修改器","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public int GetPID(string exeName) {
            try {
                return Process.GetProcessesByName(exeName)[0].Id;
            } catch {
                return 0;
            }
        }

        
    }
}
