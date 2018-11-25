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
            //    if(GetProcessHandle("th06")!=(IntPtr)0) {

            //    } else if(GetProcessHandle("th07")!=(IntPtr)0) {

            //    } else if(GetProcessHandle("th08")!=(IntPtr)0) {

            //    } else if(GetProcessHandle("th10")!=(IntPtr)0) {

            //    } else if(GetProcessHandle("th11")!=(IntPtr)0) {

            //   } else 
            if(GetProcessHandle("th12")!=(IntPtr)0) {
                tc=new TH12Code();
                tc.setMemoryTool(new MemoryTool("th12"));
            } else if(GetProcessHandle("th12c")!=(IntPtr)0) {
                tc=new TH12Code();
                tc.setTitle("东方红红蓝汉化版");
                tc.setMemoryTool(new MemoryTool("th12c"));
            } else
            //if(GetProcessHandle("th13")!=(IntPtr)0) {

            //   } else if(GetProcessHandle("th14")!=(IntPtr)0) {

            //   } else if(GetProcessHandle("th15")!=(IntPtr)0) {

            //   }  else
            if(GetProcessHandle("th16")!=(IntPtr)0) {
                tc=new TH16Code();
                tc.setMemoryTool(new MemoryTool("th16"));
            } else {
                MessageBox.Show("没有发现车万进程");
                System.Environment.Exit(System.Environment.ExitCode);
            }

            this.Text=tc.getTitle();
            bool[] enable = tc.getEnable();
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
            tbSpecial1.Enabled=btnSpecial1.Enabled=tbISpecial1.Enabled=btnISpecial1.Enabled=btnReadSpecial1.Enabled=enable[10];
            tbSpecial2.Enabled=btnSpecial2.Enabled=tbISpecial2.Enabled=btnISpecial2.Enabled=btnReadSpecial2.Enabled=enable[11];
            tbSpecial3.Enabled=btnSpecial3.Enabled=tbISpecial3.Enabled=btnISpecial3.Enabled=btnReadSpecial3.Enabled=enable[12];
            lbSpecialTip.Text=tc.getSpecialTip();
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
            tc.setISpecial2(Convert.ToByte(tbISpecial2.Text));
        }
        private void btnISpecial3_Click(object sender,EventArgs e) {
            tc.setISpecial3(Convert.ToByte(tbISpecial3.Text));
        }
        public IntPtr GetProcessHandle(string exeName) {
            try {
                Process[] ProcList = Process.GetProcessesByName(exeName);
                IntPtr pHandle = ProcList[0].Handle;
                return pHandle;
            } catch {
                return IntPtr.Zero;
            }
        }

    }
}
