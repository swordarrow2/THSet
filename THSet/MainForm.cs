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
        private const string versonCode = "THSet v2.6.0";
        private FormWindowState fwsPrevious;
        private floatWindow myTopMost;
        private THCode tc;
        private Process THprocess;
        private bool tipedWarning = false;
        private bool[] enable;
        public string[] names = new string[] { "th10","th10chs","th10cht","th11","th11c","th12","th12c","th128","th128_CN","th13","th13c","th14","th15","th16","th165" };
        private int pid = 0;
        private int lastLife = 0;
        private int thisLife = 0;
        public int index = 0;
        public int missCount = 0;
        public int bombCount = 0;
        public int bulletCount = 0;
        public int bossLife = 0;
        public int dps = 0;

        public MainForm() {
            InitializeComponent();
            for(;index<names.Length;index++) {
                pid=GetPID(names[index]);
                if(pid!=0) { break; }
            }
            if(pid==0) {
                MessageBox.Show("没有发现支持的车万进程\n目前支持TH10,11,12,12.8,13,14,15,16,16.5",versonCode,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Environment.Exit(Environment.ExitCode);
            }
            switch(index) {
                case 0:
                case 1:
                case 2: tc=new TH10Code(new MemoryTool(THprocess)); break;
                case 3:
                case 4: tc=new TH11Code(new MemoryTool(THprocess)); break;
                case 5:
                case 6: tc=new TH12Code(new MemoryTool(THprocess)); break;
                case 7:
                case 8: tc=new TH128Code(new MemoryTool(THprocess)); break;
                case 9:
                case 10: tc=new TH13Code(new MemoryTool(THprocess)); break;
                case 11: tc=new TH14Code(new MemoryTool(THprocess)); break;
                case 12: tc=new TH15Code(new MemoryTool(THprocess)); break;
                case 13: tc=new TH16Code(new MemoryTool(THprocess)); break;
                case 14: tc=new TH165Code(new MemoryTool(THprocess)); break;
            }
            Text=tc.getTitle();
            enable=tc.getEnable();
            string[] sptip = tc.getSpecialTip();
            string[] d = tc.getDefaultValue();
            lockPlayer.Enabled=false;
            lockBomb.Enabled=false;
            unbeatable.Enabled=false;
            lbPlayer.Enabled=tbPlayer.Enabled=btnPlayer.Enabled=enable[0];
            lbPF.Enabled=tbPlayerFragment.Enabled=btnPlayerFragment.Enabled=enable[1];
            lbBomb.Enabled=tbBomb.Enabled=btnBomb.Enabled=enable[2];
            lbBF.Enabled=tbBombFragment.Enabled=btnBombFragment.Enabled=enable[3];
            lbPower.Enabled=tbPower.Enabled=btnPower.Enabled=enable[4];
            lbScore.Enabled=tbScore.Enabled=btnScore.Enabled=enable[5];
            lbMaxpoint.Enabled=tbMaxPoint.Enabled=btnMaxPoint.Enabled=enable[6];
            lbSp1.Enabled=tbSp1.Enabled=btnSp1.Enabled=btnReadSp1.Enabled=enable[7];
            lbSp2.Enabled=tbSp2.Enabled=btnSp2.Enabled=btnReadSp2.Enabled=enable[8];
            lbSp3.Enabled=tbSp3.Enabled=btnSp3.Enabled=btnReadSp3.Enabled=enable[9];


            lbIPlayer.Enabled=tbIPlayer.Enabled=btnIPlayer.Enabled=enable[10];
            lbIPF.Enabled=tbIPlayerFragment.Enabled=btnIPlayerFragment.Enabled=enable[11];
            lbIBomb.Enabled=tbIBomb.Enabled=btnIBomb.Enabled=enable[12];
            lbIBF.Enabled=tbIBombFragment.Enabled=btnIBombFragment.Enabled=enable[13];
            lbIPower.Enabled=tbIPower.Enabled=btnIPower.Enabled=enable[14];
            lbIScore.Enabled=tbIScore.Enabled=btnIScore.Enabled=enable[15];
            lbIMaxPoint.Enabled=tbIMaxPoint.Enabled=btnIMaxPoint.Enabled=enable[16];
            lbISp1.Enabled=tbISp1.Enabled=btnISpe1.Enabled=enable[17];
            lbISp2.Enabled=tbISp2.Enabled=btnISp2.Enabled=enable[18];
            lbISp3.Enabled=tbISp3.Enabled=btnISp3.Enabled=enable[19];

            groupBoxFPSChange.Enabled=false;
            groupBoxSourceUse.Enabled=false;
            groupBoxBoss.Enabled=false;
            btnKill.Enabled=false;

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
        }
        private void MainForm_Load(object sender,EventArgs e) {
            fwsPrevious=WindowState;
            myTopMost=new floatWindow(this);
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
                if(WindowState==FormWindowState.Minimized&&tipedWarning) {
                    myTopMost.Show();
                    ShowInTaskbar=false;
                } else if(WindowState!=fwsPrevious) {
                    fwsPrevious=WindowState;
                }
            }
        }
        private void lockPlayer_CheckedChanged(object sender,EventArgs e) => tc.setLockPlayer(lockPlayer.Checked);
        private void lockBomb_CheckedChanged(object sender,EventArgs e) => tc.setLockBomb(lockBomb.Checked);
        private void choice_CheckedChanged(object sender,EventArgs e) => tc.setUnbeatable(unbeatable.Checked);
        private void btnFPS_Click(object sender,EventArgs e) {
            int v = Convert.ToInt32(tbFPS.Text);
            tc.setFPS(v);
            trackBar_FPS.Value=v>trackBar_FPS.Maximum ? trackBar_FPS.Maximum : v<trackBar_FPS.Minimum ? trackBar_FPS.Minimum : v;
        }
        private void trackBar_FPS_Scroll(object sender,EventArgs e) => tc.setFPS(Convert.ToInt32(tbFPS.Text=Convert.ToString(trackBar_FPS.Value)));
        private void btnPlayer_Click(object sender,EventArgs e) => tc.setPlayer(Convert.ToInt32(tbPlayer.Text));
        private void btnPlayerFragment_Click(object sender,EventArgs e) => tc.setPlayerFragment(Convert.ToInt32(tbPlayerFragment.Text));
        private void btnBomb_Click(object sender,EventArgs e) => tc.setBomb(Convert.ToInt32(tbBomb.Text));
        private void btnBombFragment_Click(object sender,EventArgs e) => tc.setBombFragment(Convert.ToInt32(tbBombFragment.Text));
        private void btnPower_Click(object sender,EventArgs e) => tc.setPower(Convert.ToInt32(tbPower.Text));
        private void btnScore_Click(object sender,EventArgs e) => tc.setScore(Convert.ToInt32(tbScore.Text));
        private void btnMaxPoint_Click(object sender,EventArgs e) => tc.setMaxPoint(Convert.ToInt32(tbMaxPoint.Text));
        private void btnSpecial1_Click(object sender,EventArgs e) => tc.setSpecial1(Convert.ToInt32(tbSp1.Text));
        private void btnSpecial2_Click(object sender,EventArgs e) => tc.setSpecial2(Convert.ToInt32(tbSp2.Text));
        private void btnSpecial3_Click(object sender,EventArgs e) => tc.setSpecial3(Convert.ToInt32(tbSp3.Text));
        private void btnReadSpecial1_Click(object sender,EventArgs e) => tbSp1.Text=Convert.ToString(tc.getSpecial1());
        private void btnReadSpecial2_Click(object sender,EventArgs e) => tbSp2.Text=Convert.ToString(tc.getSpecial2());
        private void btnReadSpecial3_Click(object sender,EventArgs e) => tbSp3.Text=Convert.ToString(tc.getSpecial3());
        private void btnIPlayer_Click(object sender,EventArgs e) => tc.setIPlayer(Convert.ToInt32(tbIPlayer.Text));
        private void btnIPlayerFragment_Click(object sender,EventArgs e) => tc.setIPlayerFragment(Convert.ToInt32(tbIPlayerFragment.Text));
        private void btnIBomb_Click(object sender,EventArgs e) => tc.setIBomb(Convert.ToInt32(tbIBomb.Text));
        private void btnIBombFragment_Click(object sender,EventArgs e) => tc.setIBombFragment(Convert.ToInt32(tbIBombFragment.Text));
        private void btnIPower_Click(object sender,EventArgs e) => tc.setIPower(Convert.ToInt32(tbIPower.Text));
        private void btnIScore_Click(object sender,EventArgs e) => tc.setIScore(Convert.ToInt32(tbIScore.Text));
        private void btnIMaxPoint_Click(object sender,EventArgs e) => tc.setIMaxPoint(Convert.ToInt32(tbIMaxPoint.Text));
        private void btnISpecial1_Click(object sender,EventArgs e) => tc.setISpecial1(Convert.ToInt32(tbISp1.Text));
        private void btnISpecial2_Click(object sender,EventArgs e) => tc.setISpecial2(Convert.ToInt32(tbISp2.Text));
        private void btnISpecial3_Click(object sender,EventArgs e) => tc.setISpecial3(Convert.ToInt32(tbISp3.Text));
        private void showBug_Click(object sender,EventArgs e) => MessageBox.Show(tc.getAboutBug(),versonCode,MessageBoxButtons.OK,MessageBoxIcon.Information);
        private void button2_Click(object sender,EventArgs e) => MessageBox.Show(tc.getAboutSpecial(),versonCode,MessageBoxButtons.OK,MessageBoxIcon.Information);
        private void note_Click(object sender,EventArgs e) => MessageBox.Show("这个修改器主要为原版程序设计，如果你使用了修改过的游戏，可能有功能不正常."+
                "\n\n修改器在Windows7 64位系统中运行正常，其他系统暂未测试\n\n即时修改页为游戏中的当前数值，修改内容不会记录到录像中，有些数值修改后不会立刻显示(如残机),但值确实是已经改变了\n\n"+
                "Init页修改的为各项的初始值，修改内容会记录到录像中。此部分修改尽量不要和THInit同时使用，可能会造成游戏爆炸\n\n调速前请关闭垂直同步(custom.exe-->输入方式-->快速)\n对使用了vpatch的程序调速小于60FPS时,游戏可能会无响应,一般稍等即可恢复"+
                "\n\n注意：如果重启游戏需重启修改器\n……另外,不要点击最大化按钮,不要点不要点不要点",versonCode,MessageBoxButtons.OK,MessageBoxIcon.Information);
        private void btnKill_Click(object sender,EventArgs e) => killSelf();
        private void timerMissAndBomb_Tick(object sender,EventArgs e) {
            if(!enable[24]) return;
            missCount=tc.getMissCount();
            bombCount=tc.getBombCount();
            lbMissCount.Text="miss次数:"+missCount;
            lbBombCount.Text="bomb次数:"+bombCount;
        }
        private void timerEnemy_Tick(object sender,EventArgs e) {
            if(enable[25]) {
                bossLife=tc.getBossLife();
                lbLife.Text="血量:"+bossLife;
            }
            if(enable[26]) {
                bulletCount=tc.getBulletCount();
                lbBulletCount.Text="子弹数量:"+bulletCount;
            }
        }
        private void timerDPS_Tick(object sender,EventArgs e) {
            if(enable[25]) {
                thisLife=tc.getBossLife();
                dps=lastLife-thisLife;
                lbDPS.Text="DPS:"+dps;
                lastLife=thisLife;
            }
        }
        private void btnCountStart_Click(object sender,EventArgs e) => restartCount();
        private void tabChange(object sender,EventArgs e) {
            if(tabControl1.SelectedTab==tabPage3&&!tipedWarning) {
                if(MessageBox.Show("这些功能可能会对游戏录像(.rpy)产生影响,如果产生了影响,则必须在本修改器开启且使用相同设置的状态下才能正常播放.\n对于计数功能,开启后若想关闭,需重启游戏.\n\n点击确定开始使用,点击取消则不使用本页功能",versonCode,MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK) {
                    tipedWarning=timerMissAndBomb.Enabled=timerEnemy.Enabled=timerDPS.Enabled=true;
                    tc.StartCount();
                    lockPlayer.Enabled=enable[20];
                    lockBomb.Enabled=enable[21];
                    unbeatable.Enabled=enable[22];
                    groupBoxFPSChange.Enabled=enable[23];
                    groupBoxSourceUse.Enabled=enable[24];
                    groupBoxBoss.Enabled=enable[25];
                    lbBulletCount.Enabled=enable[26];
                    btnKill.Enabled=enable[27];
                }
            }
        }
        private void timerProcessWatcher_Tick(object sender,EventArgs e) {
            if(GetPID(names[index])==0) Environment.Exit(Environment.ExitCode);
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
        private void btnUseFloatWindow_Click(object sender,EventArgs e) => MessageBox.Show("启用数据监视的状态下把本软件主窗体最小化，将会自动打开悬浮窗,拖动边框即可改变悬浮窗位置",versonCode,MessageBoxButtons.OK,MessageBoxIcon.Information);

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
            Properties.Settings.Default.Save();
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
        }
        public void restartCount() => tc.StartCount();
        public void killSelf() => tc.killSelf();
    }
}
