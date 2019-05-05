﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace THSet {
    public partial class MainForm:Form {
        public const string versonCode = "THSet v3.4.9";
        private bool useAutoBomb = false;
        private FormWindowState fwsPrevious;
        private FloatWindow floatWindow;
        private THCode thCode;
        private Process THprocess;
        public string[] names = new string[] { "th07","th08","th09","th09c","th10","th10chs","th10cht","th11","th11c","th12","th12c","th128","th128_CN","th13","th13c","th14","th15","th16","th165","th17" };
        private string[] sptip;
        private int pid = 0;
        private int lastLife = 0;
        private int thisLife = 0;
        private int gameIndex = 0;
        public int missCount = -1;
        public int bombCount = -1;
        public int bulletCount = 0;
        public int bossLife = 0;
        public int dps = 0;
        public string sp1 = "";
        private int THNo = 0;
        public static int bossEclIndex = 0;
        public static int lastStage = 0;

        [DllImport("user32.dll")]
        public static extern IntPtr GetActiveWindow();//获得当前活动窗体  
        public MainForm() {
            InitializeComponent();
            for(;gameIndex<names.Length;gameIndex++) {
                pid=GetPID(names[gameIndex]);
                if(pid!=0) { break; }
            }
            if(pid==0) {
                StringBuilder sb = new StringBuilder();
                foreach(string s in names) {
                    sb.Append(s);
                    sb.Append(".exe\n");
                }
                MessageBox.Show("没有发现支持的车万进程\n目前支持:\n"+sb.ToString(),versonCode,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Environment.Exit(Environment.ExitCode);
            }
            switch(gameIndex) {
                case 0:
                    thCode=new TH07Code(new MemoryTool(THprocess));
                    lbMaxpoint.Text=lbIMaxPoint.Text="分子";
                    THNo=7;
                    break;
                case 1:
                    thCode=new TH08Code(new MemoryTool(THprocess));
                    lbMaxpoint.Text=lbIMaxPoint.Text="Time";
                    THNo=8;
                    break;
                case 4:
                case 5:
                case 6: thCode=new TH10Code(new MemoryTool(THprocess)); THNo=10; break;
                case 7:
                case 8: thCode=new TH11Code(new MemoryTool(THprocess)); THNo=11; break;
                case 9:
                case 10: thCode=new TH12Code(new MemoryTool(THprocess)); THNo=12; break;
                case 11:
                case 12: thCode=new TH128Code(new MemoryTool(THprocess)); THNo=128; break;
                case 13:
                case 14: thCode=new TH13Code(new MemoryTool(THprocess)); THNo=13; break;
                case 15: thCode=new TH14Code(new MemoryTool(THprocess)); THNo=14; break;
                case 16: thCode=new TH15Code(new MemoryTool(THprocess)); THNo=15; break;
                case 17: thCode=new TH16Code(new MemoryTool(THprocess)); THNo=16; break;
                case 18: thCode=new TH165Code(new MemoryTool(THprocess)); THNo=165; break;
                case 19: thCode=new TH17Code(new MemoryTool(THprocess)); THNo=17; break;
            }
            Text=thCode.GetTitle();
            sptip=thCode.GetSpecialTip();
            string[] d = thCode.GetDefaultValue();
            lbPlayer.Enabled=tbPlayer.Enabled=btnPlayer.Enabled=thCode.EnableSetPlayer;
            lbPF.Enabled=tbPlayerFragment.Enabled=btnPlayerFragment.Enabled=thCode.EnableSetPlayerFragment;
            lbBomb.Enabled=tbBomb.Enabled=btnBomb.Enabled=thCode.EnableSetBomb;
            lbBF.Enabled=tbBombFragment.Enabled=btnBombFragment.Enabled=thCode.EnableSetBombFragment;
            lbPower.Enabled=tbPower.Enabled=btnPower.Enabled=thCode.EnableSetPower;
            lbScore.Enabled=tbScore.Enabled=btnScore.Enabled=thCode.EnableSetScore;
            lbMaxpoint.Enabled=tbMaxPoint.Enabled=btnMaxPoint.Enabled=thCode.EnableSetMaxPoint;
            lbSp1.Enabled=tbSp1.Enabled=btnSp1.Enabled=thCode.EnableSetSpecial1;
            lbSp2.Enabled=tbSp2.Enabled=btnSp2.Enabled=thCode.EnableSetSpecial2;
            lbSp3.Enabled=tbSp3.Enabled=btnSp3.Enabled=thCode.EnableSetSpecial3;

            lbIPlayer.Enabled=tbIPlayer.Enabled=btnIPlayer.Enabled=thCode.EnableSetIPlayer;
            lbIPF.Enabled=tbIPlayerFragment.Enabled=btnIPlayerFragment.Enabled=thCode.EnableSetIPlayerFragment;
            lbIBomb.Enabled=tbIBomb.Enabled=btnIBomb.Enabled=thCode.EnableSetIBomb;
            lbIBF.Enabled=tbIBombFragment.Enabled=btnIBombFragment.Enabled=thCode.EnableSetIBombFragment; ;
            lbIPower.Enabled=tbIPower.Enabled=btnIPower.Enabled=thCode.EnableSetIPower;
            lbIScore.Enabled=tbIScore.Enabled=btnIScore.Enabled=thCode.EnableSetIScore;
            lbIMaxPoint.Enabled=tbIMaxPoint.Enabled=btnIMaxPoint.Enabled=thCode.EnableSetIMaxPoint;
            lbISp1.Enabled=tbISp1.Enabled=btnISpe1.Enabled=thCode.EnableSetISpecial1;
            lbISp2.Enabled=tbISp2.Enabled=btnISp2.Enabled=thCode.EnableSetISpecial2;
            lbISp3.Enabled=tbISp3.Enabled=btnISp3.Enabled=thCode.EnableSetISpecial3;
            groupBoxFPSChange.Enabled=thCode.EnableSetFPS;
            groupBoxBoss.Enabled=thCode.EnableBossHPInfo;
            lbBulletCount.Enabled=thCode.EnableShowBulletCount;

            gbBossPractice.Enabled=thCode.EnableChapterPrictice;
            lbSp1.Text=lbSp1.Enabled ? sptip[0] : "不可用";
            lbSp2.Text=lbSp2.Enabled ? sptip[1] : "不可用";
            lbSp3.Text=lbSp3.Enabled ? sptip[2] : "不可用";

            tbSp1.Text=tbSp1.Enabled ? d[0] : "0";
            tbSp2.Text=tbSp2.Enabled ? d[1] : "0";
            tbSp3.Text=tbSp3.Enabled ? d[2] : "0";

            lbISp1.Text=lbISp1.Enabled ? sptip[0] : "不可用";
            lbISp2.Text=lbISp2.Enabled ? sptip[1] : "不可用";
            lbISp3.Text=lbISp3.Enabled ? sptip[2] : "不可用";

            tbISp1.Text=tbISp1.Enabled ? d[0] : "0";
            tbISp2.Text=tbISp2.Enabled ? d[1] : "0";
            tbISp3.Text=tbISp3.Enabled ? d[2] : "0";

            if(!tbSp1.Enabled&&!tbSp2.Enabled&&!tbSp3.Enabled) groupBoxSpecial.Enabled=false;
            if(!tbISp1.Enabled&&!tbISp2.Enabled&&!tbISp3.Enabled) groupBoxISpecial.Enabled=false;
            timerProcessWatcher.Enabled=true;
            cbTop.Checked=TopMost=Properties.Settings.Default.holdTop;
            trackBarA.Value=Properties.Settings.Default.bgA;
            trackBarR.Value=Properties.Settings.Default.bgR;
            trackBarG.Value=Properties.Settings.Default.bgG;
            trackBarB.Value=Properties.Settings.Default.bgB;
            trackBarFontR.Value=Properties.Settings.Default.fontR;
            trackBarFontG.Value=Properties.Settings.Default.fontG;
            trackBarFontB.Value=Properties.Settings.Default.fontB;
            lbShowRGB.BackColor=Color.FromArgb(trackBarR.Value,trackBarG.Value,trackBarB.Value);
            lbShowRGB.ForeColor=Color.FromArgb(trackBarFontR.Value,trackBarFontG.Value,trackBarFontB.Value);

            if(THNo==7||THNo==8) {
                lbPF.Text=lbIPF.Text="蓝点数";
                timerMissAndBomb.Enabled=true;
                btnCountStart.Enabled=false;
            }

            timerMissAndBomb.Enabled=true; timerEnemy.Enabled=timerDPS.Enabled=true;
            thCode.StartCount();
            lockPlayer.Enabled=thCode.EnableSetLockPlayer;
            lockBomb.Enabled=thCode.EnableSetLockBomb;
            unbeatable.Enabled=thCode.EnableSetUnbeatable;
            groupBoxSourceUse.Enabled=thCode.EnableSourceCount;
            btnKill.Enabled=thCode.EnableKillSelf;
            cbAutoBomb.Enabled=thCode.EnableAutoBomb;

        }

        public IntPtr getActiveWindow() => GetActiveWindow();

        private void MainForm_Load(object sender,EventArgs e) {
            fwsPrevious=WindowState;
            floatWindow=new FloatWindow(this);
        }
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            if(WindowState==FormWindowState.Maximized) {
                StringBuilder sb = new StringBuilder();
                for(int i = 0;i<150;i++) {
                    for(int j = 0;j<150;j++) sb.Append("发");
                    sb.Append("\n");
                }
                lbfafafa1.Text=sb.ToString();
            } else {
                lbfafafa1.Text="";
                if(WindowState==FormWindowState.Minimized) {
                    timerEnemy.Enabled=timerDPS.Enabled=true;
                    floatWindow.Show();
                    ShowInTaskbar=false;
                } else if(WindowState!=fwsPrevious) {
                    fwsPrevious=WindowState;
                }
            }
        }
        private void lockPlayer_CheckedChanged(object sender,EventArgs e) => thCode.SetLockPlayer(lockPlayer.Checked);
        private void lockBomb_CheckedChanged(object sender,EventArgs e) => thCode.SetLockBomb(lockBomb.Checked);
        private void choice_CheckedChanged(object sender,EventArgs e) => thCode.SetUnbeatable(unbeatable.Checked);
        private void btnFPS_Click(object sender,EventArgs e) {
            int v = Convert.ToInt32(tbFPS.Text);
            thCode.SetFPS(v);
            trackBar_FPS.Value=v>trackBar_FPS.Maximum ? trackBar_FPS.Maximum : v<trackBar_FPS.Minimum ? trackBar_FPS.Minimum : v;
        }
        private void trackBar_FPS_Scroll(object sender,EventArgs e) => thCode.SetFPS(Convert.ToInt32(tbFPS.Text=Convert.ToString(trackBar_FPS.Value)));
        private void btnPlayer_Click(object sender,EventArgs e) => thCode.SetPlayer(Convert.ToInt32(tbPlayer.Text));
        private void btnPlayerFragment_Click(object sender,EventArgs e) => thCode.SetPlayerFragment(Convert.ToInt32(tbPlayerFragment.Text));
        private void btnBomb_Click(object sender,EventArgs e) => thCode.SetBomb(Convert.ToInt32(tbBomb.Text));
        private void btnBombFragment_Click(object sender,EventArgs e) => thCode.SetBombFragment(Convert.ToInt32(tbBombFragment.Text));
        private void btnPower_Click(object sender,EventArgs e) => thCode.SetPower(Convert.ToInt32(tbPower.Text));
        private void btnScore_Click(object sender,EventArgs e) => thCode.SetScore(Convert.ToInt32(Convert.ToInt64(tbScore.Text)/10));
        private void btnMaxPoint_Click(object sender,EventArgs e) => thCode.SetMaxPoint(Convert.ToInt32(tbMaxPoint.Text));
        private void btnSpecial1_Click(object sender,EventArgs e) => thCode.SetSpecial1(Convert.ToInt32(tbSp1.Text));
        private void btnSpecial2_Click(object sender,EventArgs e) => thCode.SetSpecial2(Convert.ToInt32(tbSp2.Text));
        private void btnSpecial3_Click(object sender,EventArgs e) => thCode.SetSpecial3(Convert.ToInt32(tbSp3.Text));
        private void btnReadSpecial1_Click(object sender,EventArgs e) => tbSp1.Text=Convert.ToString(thCode.GetSpecial1());
        private void btnReadSpecial2_Click(object sender,EventArgs e) => tbSp2.Text=Convert.ToString(thCode.GetSpecial2());
        private void btnReadSpecial3_Click(object sender,EventArgs e) => tbSp3.Text=Convert.ToString(thCode.GetSpecial3());
        private void btnIPlayer_Click(object sender,EventArgs e) => thCode.SetIPlayer(Convert.ToInt32(tbIPlayer.Text));
        private void btnIPlayerFragment_Click(object sender,EventArgs e) => thCode.SetIPlayerFragment(Convert.ToInt32(tbIPlayerFragment.Text));
        private void btnIBomb_Click(object sender,EventArgs e) => thCode.SetIBomb(Convert.ToInt32(tbIBomb.Text));
        private void btnIBombFragment_Click(object sender,EventArgs e) => thCode.SetIBombFragment(Convert.ToInt32(tbIBombFragment.Text));
        private void btnIPower_Click(object sender,EventArgs e) => thCode.SetIPower(Convert.ToInt32(tbIPower.Text));
        private void btnIScore_Click(object sender,EventArgs e) => thCode.SetIScore(Convert.ToInt32(Convert.ToInt64(tbIScore.Text)/10));
        private void btnIMaxPoint_Click(object sender,EventArgs e) => thCode.SetIMaxPoint(Convert.ToInt32(tbIMaxPoint.Text));
        private void btnISpecial1_Click(object sender,EventArgs e) => thCode.SetISpecial1(Convert.ToInt32(tbISp1.Text));
        private void btnISpecial2_Click(object sender,EventArgs e) => thCode.SetISpecial2(Convert.ToInt32(tbISp2.Text));
        private void btnISpecial3_Click(object sender,EventArgs e) => thCode.SetISpecial3(Convert.ToInt32(tbISp3.Text));
        private void showBug_Click(object sender,EventArgs e) => MessageBox.Show(thCode.GetAboutBug(),versonCode,MessageBoxButtons.OK,MessageBoxIcon.Information);
        private void button2_Click(object sender,EventArgs e) => MessageBox.Show(thCode.GetAboutSpecial(),versonCode,MessageBoxButtons.OK,MessageBoxIcon.Information);
        private void btnKill_Click(object sender,EventArgs e) => killSelf();
        private void timerMissAndBomb_Tick(object sender,EventArgs e) {
            if(!thCode.EnableSourceCount) return;
            missCount=thCode.GetMissCount();
            bombCount=thCode.GetBombCount();
            lbMissCount.Text="miss次数:"+missCount;
            lbBombCount.Text="bomb次数:"+bombCount;
        }
        private void timerEnemy_Tick(object sender,EventArgs e) {
            if(getActiveWindow()==IntPtr.Zero&&useAutoBomb) {
                thCode.CheckNeedBomb();
            }
            // lbLife.Text="游戏"+THprocess.Handle+"\n当前"+getActiveWindow();
            if(thCode.EnableBossHPInfo) {
                bossLife=thCode.GetBossLife();
                lbLife.Text="血量:"+bossLife;
            }
            if(thCode.EnableShowBulletCount) {
                bulletCount=thCode.GetBulletCount();
                lbBulletCount.Text="子弹数量:"+bulletCount;
            }
            if(!thCode.EnableSetSpecial1) return;
            if(THNo==7) {
                lbShowSp1.Text=sp1="樱道具值:"+(1000+100*thCode.GetSpecial1());
            } else {
                lbShowSp1.Text=sptip[0]+":"+thCode.GetSpecial1();
            }
            if(!thCode.EnableSetSpecial2) return;
            lbShowSp2.Text=sptip[1]+":"+thCode.GetSpecial2();
            if(!thCode.EnableSetSpecial3) return;
            if(THNo==7) lbShowSp3.Text=sptip[2]+":"+thCode.GetSpecial3();
        }
        private void timerDPS_Tick(object sender,EventArgs e) {
            if(thCode.EnableBossHPInfo) {
                thisLife=thCode.GetBossLife();
                dps=lastLife-thisLife;
                lbDPS.Text="DPS:"+dps;
                lastLife=thisLife;
            }
        }
        private void btnCountStart_Click(object sender,EventArgs e) => restartCount();
        private void timerProcessWatcher_Tick(object sender,EventArgs e) {
            if(GetPID(names[gameIndex])==0) Environment.Exit(Environment.ExitCode);
        }
        private int GetPID(string exeName) {
            try {
                THprocess=Process.GetProcessesByName(exeName)[0];
                return THprocess.Id;
            } catch {
                return 0;
            }
        }
        public void RestoreWindow() {
            WindowState=fwsPrevious;
            ShowInTaskbar=true;
        }
        private void cbTop_CheckedChanged(object sender,EventArgs e) {
            TopMost=cbTop.Checked;
            Properties.Settings.Default.holdTop=cbTop.Checked;
            Properties.Settings.Default.Save();
        }
        private void trackBarR_Scroll(object sender,EventArgs e) => lbShowRGB.BackColor=Color.FromArgb(trackBarR.Value,trackBarG.Value,trackBarB.Value);
        private void trackBarG_Scroll(object sender,EventArgs e) => lbShowRGB.BackColor=Color.FromArgb(trackBarR.Value,trackBarG.Value,trackBarB.Value);
        private void trackBarB_Scroll(object sender,EventArgs e) => lbShowRGB.BackColor=Color.FromArgb(trackBarR.Value,trackBarG.Value,trackBarB.Value);
        private void trackBarFontR_Scroll(object sender,EventArgs e) => lbShowRGB.ForeColor=Color.FromArgb(trackBarFontR.Value,trackBarFontG.Value,trackBarFontB.Value);
        private void trackBarFontG_Scroll(object sender,EventArgs e) => lbShowRGB.ForeColor=Color.FromArgb(trackBarFontR.Value,trackBarFontG.Value,trackBarFontB.Value);
        private void trackBarFontB_Scroll(object sender,EventArgs e) => lbShowRGB.ForeColor=Color.FromArgb(trackBarFontR.Value,trackBarFontG.Value,trackBarFontB.Value);
        private void saveConfig(object sender,MouseEventArgs e) => saveConfig();
        private void btnDefault_Click(object sender,EventArgs e) {
            trackBarA.Value=0x50;
            trackBarR.Value=0x7F;
            trackBarG.Value=0xCA;
            trackBarB.Value=0x00;
            trackBarFontR.Value=0x00;
            trackBarFontG.Value=0x00;
            trackBarFontB.Value=0x00;
            lbShowRGB.BackColor=Color.FromArgb(trackBarR.Value,trackBarG.Value,trackBarB.Value);
            lbShowRGB.ForeColor=Color.FromArgb(trackBarFontR.Value,trackBarFontG.Value,trackBarFontB.Value);
            Properties.Settings.Default.floatWindowX=30;
            Properties.Settings.Default.floatWindowY=30;
            saveConfig();
        }
        private void saveConfig() {
            Properties.Settings.Default.bgA=trackBarA.Value;
            Properties.Settings.Default.bgR=trackBarR.Value;
            Properties.Settings.Default.bgG=trackBarG.Value;
            Properties.Settings.Default.bgB=trackBarB.Value;
            Properties.Settings.Default.fontR=trackBarFontR.Value;
            Properties.Settings.Default.fontG=trackBarFontG.Value;
            Properties.Settings.Default.fontB=trackBarFontB.Value;
            Properties.Settings.Default.Save();
        }
        public void restartCount() => thCode.StartCount();
        public void killSelf() => thCode.KillSelf();
        private void comboBoxStage_selected(object sender,EventArgs e) {
            if(comboBoxStage.Text.Equals("")) return;
            thCode.SetStage(comboBoxStage,comboBoxChapter,comboBoxMBoss,comboBoxBoss);
        }
        private void comboBoxChapter_selected(object sender,EventArgs e) {
            if(comboBoxChapter.Text.Equals("")) return;
            thCode.SetChapter(comboBoxStage,comboBoxChapter,comboBoxMBoss,comboBoxBoss);
        }
        private void comboBoxMBoss_selected(object sender,EventArgs e) {
            if(comboBoxMBoss.Text.Equals("")) return;
            thCode.SetMBossNum(comboBoxStage,comboBoxChapter,comboBoxMBoss,comboBoxBoss);
        }
        private void comboBoxBoss_selected(object sender,EventArgs e) {
            if(comboBoxBoss.Text.Equals("")) return;
            thCode.SetBossNum(comboBoxStage,comboBoxChapter,comboBoxMBoss,comboBoxBoss);
        }
        private void cbAutoBomb_CheckedChanged(object sender,EventArgs e) => useAutoBomb=cbAutoBomb.Checked;
    }
}