using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using THSet.specialCheat;

namespace THSet {
    public partial class MainForm:MaterialForm {
        struct PracticeData {
            public string stage;
            public string chapter;
            public string boss;
        };
        public struct Page3Data {
            public int miss;
            public int bomb;
            public int hp;
            public int dps;
            public int bullet;
            public int other1;
            public int other2;
            public int other3;
        };

        public const string versonCode = "THSet v3.4.9";
        private string[] names = new string[] { "th07","th08","th09","th09c","th10","th10chs","th10cht","th11","th11c","th12","th12c","th128","th128_CN","th13","th13c","th14","th15","th16","th165","th17" };
        private int gameIndex = 0;
        private PracticeData practiceData;
        public Page3Data page3data;
        private Process THprocess;
        public static THCode thCode;
        public int gameNum = 0;
        private bool useAutoBomb = false;

        private int lastLife = 0;
        public int dps = 0;

        private bool tipedWarning = false;

        private FormWindowState fwsPrevious;
        private FloatWindow floatWindow;

        private readonly MaterialSkinManager materialSkinManager;

        [DllImport("user32.dll")]
        public static extern IntPtr GetActiveWindow();//获得当前活动窗体  

        public MainForm() {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager=MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme=MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme=new ColorScheme(Primary.BlueGrey800,Primary.BlueGrey900,Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
            materialSkinManager.ColorScheme=new ColorScheme(Primary.Green600,Primary.Green700,Primary.Green200,Accent.Red100,TextShade.WHITE);
            practiceData=new PracticeData();
            page3data=new Page3Data();
            findProcess();
        }
        #region page3
        private void setFps(object sender,EventArgs e) {
            MaterialRadioButton radioButton = (MaterialRadioButton)sender;
            customFPS.Enabled=false;
            fpsButton.Enabled=false;
            if(radioButton.Checked) {
                switch(radioButton.Name) {
                    case "_60":
                        thCode.SetFPS(60);
                        break;
                    case "_75":
                        thCode.SetFPS(75);
                        break;
                    case "_90":
                        thCode.SetFPS(90);
                        break;
                    case "custom":
                        customFPS.Enabled=true;
                        fpsButton.Enabled=true;
                        break;
                }
            }
        }

        private void fpsButton_Click(object sender,EventArgs e) {
            thCode.SetFPS(Convert.ToInt32(customFPS.Text));
        }
        #endregion

        #region page4

        private void lockPlayer_CheckedChanged(object sender,EventArgs e) {
            thCode.SetLockPlayer(lockPlayer.Checked);
        }

        private void unbeatable_CheckedChanged(object sender,EventArgs e) {
            thCode.SetUnbeatable(unbeatable.Checked);
        }

        private void lockBomb_CheckedChanged(object sender,EventArgs e) {
            thCode.SetLockBomb(lockBomb.Checked);
        }

        private void autoBomb_CheckedChanged(object sender,EventArgs e) {
            useAutoBomb=autoBomb.Checked;
        }

        private void killSelf_Click(object sender,EventArgs e) {
            thCode.KillSelf();
        }

        private void chapterPracticeSelect(object sender,EventArgs e) {
            MaterialListView listView = (MaterialListView)sender;
            switch(listView.Name) {
                case "stageList":
                    if(listView.SelectedItems.Count>0) {
                        practiceData.stage=listView.SelectedItems[0].Text;
                    }
                    break;
                case "chapterList":
                    if(listView.SelectedItems.Count>0) {
                        practiceData.chapter=listView.SelectedItems[0].Text;
                    }
                    break;
                case "bossList":
                    if(listView.SelectedItems.Count>0) {
                        practiceData.boss=listView.SelectedItems[0].Text;
                    }
                    break;
            }
            MessageBox.Show(practiceData.stage+" "+practiceData.chapter+" "+practiceData.boss);
        }
        #endregion

        #region findProcess
        private void findProcess() {
            int pid = 0;
            for(;gameIndex<names.Length;++gameIndex) {
                try {
                    THprocess=Process.GetProcessesByName(names[gameIndex])[0];
                } catch {
                    continue;
                }
                if(THprocess.Id!=0) {
                    pid=THprocess.Id;
                    break;
                }
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
                case 0: thCode=new TH07Code(new MemoryTool(THprocess)); gameNum=7; break;
                case 1: thCode=new TH08Code(new MemoryTool(THprocess)); gameNum=8; break;
                case 4:
                case 5:
                case 6: thCode=new TH10Code(new MemoryTool(THprocess)); gameNum=10; break;
                case 7:
                case 8: thCode=new TH11Code(new MemoryTool(THprocess)); gameNum=11; break;
                case 9:
                case 10: thCode=new TH12Code(new MemoryTool(THprocess)); gameNum=12; break;
                case 11:
                case 12: thCode=new TH128Code(new MemoryTool(THprocess)); gameNum=128; break;
                case 13:
                case 14: thCode=new TH13Code(new MemoryTool(THprocess)); gameNum=13; break;
                case 15: thCode=new TH14Code(new MemoryTool(THprocess)); gameNum=14; break;
                case 16: thCode=new TH15Code(new MemoryTool(THprocess)); gameNum=15; break;
                case 17: thCode=new TH16Code(new MemoryTool(THprocess)); gameNum=16; break;
                case 18: thCode=new TH165Code(new MemoryTool(THprocess)); gameNum=165; break;
                case 19: thCode=new TH17Code(new MemoryTool(THprocess)); gameNum=17; break;
            }
            init();
        }

        #endregion

        #region init
        private void init() {
            Text=thCode.GetTitle();
            iPlayer.Text="残机";
            iPlayer.Enabled=thCode.EnableSetIPlayer;
            iPlayer.Action=delegate () { thCode.SetIPlayer(iPlayer.number); };
            iPlayerFragment.Text="残机碎片";
            iPlayerFragment.Enabled=thCode.EnableSetIPlayerFragment;
            iPlayerFragment.Action=delegate () { thCode.SetIPlayerFragment(iPlayerFragment.number); };
            iBomb.Text="Bomb";
            iBomb.Enabled=thCode.EnableSetIBomb;
            iBomb.Action=delegate () { thCode.SetIBomb(iBomb.number); };
            iBombFragment.Text="Bomb碎片";
            iBombFragment.Enabled=thCode.EnableSetIBombFragment;
            iBombFragment.Action=delegate () { thCode.SetIBomb(iBombFragment.number); };
            iPower.Text="灵力";
            iPower.Enabled=thCode.EnableSetIPower;
            iPower.Action=delegate () { thCode.SetIPower(iPower.number); };
            iScore.Text="得分";
            iScore.Enabled=thCode.EnableSetIScore;
            iScore.Action=delegate () { thCode.SetIScore(iScore.number); };
            iMaxPoint.Text="最大得点";
            iMaxPoint.Enabled=thCode.EnableSetIMaxPoint;
            iMaxPoint.Action=delegate () { thCode.SetIPlayer(iMaxPoint.number); };

            player.Text="残机";
            player.Enabled=thCode.EnableSetPlayer;
            player.Action=delegate () { thCode.SetPlayer(player.number); };
            playerFragment.Text="残机碎片";
            playerFragment.Enabled=thCode.EnableSetPlayerFragment;
            playerFragment.Action=delegate () { thCode.SetPlayerFragment(playerFragment.number); };
            bomb.Text="Bomb";
            bomb.Enabled=thCode.EnableSetBomb;
            bomb.Action=delegate () { thCode.SetBomb(bomb.number); };
            bombFragment.Text="Bomb碎片";
            bombFragment.Enabled=thCode.EnableSetBombFragment;
            bombFragment.Action=delegate () { thCode.SetBomb(bombFragment.number); };
            power.Text="灵力";
            power.Enabled=thCode.EnableSetPower;
            power.Action=delegate () { thCode.SetPower(power.number); };
            score.Text="得分";
            score.Enabled=thCode.EnableSetScore;
            score.Action=delegate () { thCode.SetScore(score.number); };
            maxPoint.Text="最大得点";
            maxPoint.Enabled=thCode.EnableSetMaxPoint;
            maxPoint.Action=delegate () { thCode.SetPlayer(maxPoint.number); };

            _60.Enabled=_75.Enabled=_90.Enabled=custom.Enabled=customFPS.Enabled=fpsButton.Enabled=thCode.EnableSetFPS;
            materialLabel1.Enabled=missLable.Enabled=bombLable.Enabled=thCode.EnableSourceCount;
            materialLabel3.Enabled=hpLabel.Enabled=dpsLabel.Enabled=thCode.EnableBossHPInfo;
            materialLabel4.Enabled=bulletLable.Enabled=thCode.EnableShowBulletCount;
            lockPlayer.Enabled=thCode.EnableSetLockPlayer;
            lockBomb.Enabled=thCode.EnableSetLockBomb;
            unbeatable.Enabled=thCode.EnableSetUnbeatable;
            autoBomb.Enabled=thCode.EnableAutoBomb;
            stageList.Enabled=chapterList.Enabled=bossList.Enabled=thCode.EnableChapterPractice;
            killSelf.Enabled=thCode.EnableKillSelf;

            switch(gameNum) {
                case 7:
                    TH07Special th07Special1 = new TH07Special(1);
                    TH07Special th07Special2 = new TH07Special(0);
                    tabPage1.Controls.Add(th07Special1);
                    tabPage2.Controls.Add(th07Special2);
                    break;
                case 8:
                    TH08Special th08Special1 = new TH08Special(1);
                    TH08Special th08Special2 = new TH08Special(0);
                    tabPage1.Controls.Add(th08Special1);
                    tabPage2.Controls.Add(th08Special2);
                    break;
                case 10:
                    TH10Special th10Special1 = new TH10Special(1);
                    TH10Special th10Special2 = new TH10Special(0);
                    tabPage1.Controls.Add(th10Special1);
                    tabPage2.Controls.Add(th10Special2);
                    break;
                case 11:
                    TH11Special th11Special1 = new TH11Special(1);
                    TH11Special th11Special2 = new TH11Special(0);
                    tabPage1.Controls.Add(th11Special1);
                    tabPage2.Controls.Add(th11Special2);
                    break;
                case 12:
                    TH12Special th12Special1 = new TH12Special(1);
                    TH12Special th12Special2 = new TH12Special(0);
                    tabPage1.Controls.Add(th12Special1);
                    tabPage2.Controls.Add(th12Special2);
                    break;
                case 128:
                    TH128Special th128Special1 = new TH128Special(1);
                    TH128Special th128Special2 = new TH128Special(0);
                    tabPage1.Controls.Add(th128Special1);
                    tabPage2.Controls.Add(th128Special2);
                    break;
                case 13:
                    TH13Special th13Special1 = new TH13Special(1);
                    TH13Special th13Special2 = new TH13Special(0);
                    tabPage1.Controls.Add(th13Special1);
                    tabPage2.Controls.Add(th13Special2);
                    break;
                case 14:
                    TH14Special th14Special1 = new TH14Special(1);
                    TH14Special th14Special2 = new TH14Special(0);
                    tabPage1.Controls.Add(th14Special1);
                    tabPage2.Controls.Add(th14Special2);
                    break;
                case 15:
                    TH15Special th15Special1 = new TH15Special(1);
                    TH15Special th15Special2 = new TH15Special(0);
                    tabPage1.Controls.Add(th15Special1);
                    tabPage2.Controls.Add(th15Special2);
                    break;
                case 16:
                    TH16Special th16Special1 = new TH16Special(1);
                    TH16Special th16Special2 = new TH16Special(0);
                    tabPage1.Controls.Add(th16Special1);
                    tabPage2.Controls.Add(th16Special2);
                    break;
                case 165:
                    TH165Special th165Special1 = new TH165Special(1);
                    TH165Special th165Special2 = new TH165Special(0);
                    tabPage1.Controls.Add(th165Special1);
                    tabPage2.Controls.Add(th165Special2);
                    break;
                case 17:
                    TH17Special th17Special1 = new TH17Special(1);
                    TH17Special th17Special2 = new TH17Special(0);
                    tabPage1.Controls.Add(th17Special1);
                    tabPage2.Controls.Add(th17Special2);
                    break;
            }

        }
        #endregion

        #region theme

        private void floatWindowColor_Click(object sender,EventArgs e) {

        }

        private void greenLight_Click(object sender,EventArgs e) {
            materialSkinManager.ColorScheme=new ColorScheme(Primary.Green600,Primary.Green700,Primary.Green200,Accent.Red100,TextShade.WHITE);
            materialSkinManager.Theme=MaterialSkinManager.Themes.LIGHT;
        }

        private void greenDark_Click(object sender,EventArgs e) {
            materialSkinManager.ColorScheme=new ColorScheme(Primary.Green600,Primary.Green700,Primary.Green200,Accent.Red100,TextShade.WHITE);
            materialSkinManager.Theme=MaterialSkinManager.Themes.DARK;
        }

        private void blueLight_Click(object sender,EventArgs e) {
            materialSkinManager.ColorScheme=new ColorScheme(Primary.Indigo500,Primary.Indigo700,Primary.Indigo100,Accent.Pink200,TextShade.WHITE);
            materialSkinManager.Theme=MaterialSkinManager.Themes.LIGHT;
        }

        private void blueDark_Click(object sender,EventArgs e) {
            materialSkinManager.ColorScheme=new ColorScheme(Primary.Indigo500,Primary.Indigo700,Primary.Indigo100,Accent.Pink200,TextShade.WHITE);
            materialSkinManager.Theme=MaterialSkinManager.Themes.DARK;
        }

        private void grayLight_Click(object sender,EventArgs e) {
            materialSkinManager.ColorScheme=new ColorScheme(Primary.BlueGrey800,Primary.BlueGrey900,Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
            materialSkinManager.Theme=MaterialSkinManager.Themes.LIGHT;
        }

        private void grayDark_Click(object sender,EventArgs e) {
            materialSkinManager.ColorScheme=new ColorScheme(Primary.BlueGrey800,Primary.BlueGrey900,Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
            materialSkinManager.Theme=MaterialSkinManager.Themes.DARK;
        }
        #endregion

        #region windowChange

        public void RestoreWindow() {
            WindowState=fwsPrevious;
            ShowInTaskbar=true;
        }
        private void MainForm_Load(object sender,EventArgs e) {
            fwsPrevious=WindowState;
            floatWindow=new FloatWindow(this);
        }
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            if(WindowState!=FormWindowState.Maximized) {
                if(WindowState==FormWindowState.Minimized) {
                    floatWindow.Show();
                    ShowInTaskbar=false;
                } else if(WindowState!=fwsPrevious) {
                    fwsPrevious=WindowState;
                }
            }
        }
        #endregion 

        public void restartCount() => thCode.StartCount();

        #region timer
        private void timer1_Tick(object sender,EventArgs e) {
            if(thCode.EnableSourceCount) {
                page3data.miss=thCode.GetMissCount();
                page3data.bomb=thCode.GetBombCount();
                missLable.Text="miss:"+page3data.miss;
                bombLable.Text="bomb:"+page3data.bomb;
            }
            if(thCode.EnableBossHPInfo) {
                page3data.hp=thCode.GetBossLife();
                dps=lastLife-page3data.hp;
                dpsLabel.Text="DPS:"+dps;
                lastLife=page3data.hp;
            }
        }

        private void timeProcess_Tick(object sender,EventArgs e) {
            try {
                if(Process.GetProcessesByName(names[gameIndex])[0].Id==0) Environment.Exit(Environment.ExitCode);
            } catch {
                Environment.Exit(Environment.ExitCode);
            }
        }

        private void timerEnemy_Tick(object sender,EventArgs e) {
            if(GetActiveWindow()==IntPtr.Zero&&useAutoBomb) {
                thCode.CheckNeedBomb();
            }
            if(thCode.EnableBossHPInfo) {
                page3data.hp=thCode.GetBossLife();
                hpLabel.Text="血量:"+page3data.hp;
            }
            if(thCode.EnableShowBulletCount) {
                page3data.bullet=thCode.GetBulletCount();
                bulletLable.Text="子弹数量:"+page3data.bullet;
            }
            if(!thCode.EnableSetSpecial1) return;
            if(gameNum==7) {
                otherLabel1.Text="樱道具值:"+(1000+100*thCode.GetSpecial1());
            } else {
                otherLabel1.Text=thCode.GetSpecialTip()[0]+":"+thCode.GetSpecial1();
            }
            if(!thCode.EnableSetSpecial2) return;
            otherLabel2.Text=thCode.GetSpecialTip()[1]+":"+thCode.GetSpecial2();
            if(!thCode.EnableSetSpecial3) return;
            if(gameNum==7) otherLabel3.Text=thCode.GetSpecialTip()[2]+":"+thCode.GetSpecial3();
        }
        #endregion

        private void materialTabSelector1_Click(object sender,EventArgs e) {
            if(!tipedWarning&&MessageBox.Show("是为了打接力吗？","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.No) {
                thCode.StartCount();
                timeMAndB.Enabled=true;
            }
            tipedWarning=true;
            timerEnemy.Enabled=true;
        }
    }
}
