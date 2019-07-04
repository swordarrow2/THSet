using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace THSet {
    public partial class MainForm:MaterialForm {
        private readonly MaterialSkinManager materialSkinManager;
        private THCode thCode = new TH17Code(new MemoryTool(new System.Diagnostics.Process()));
        public MainForm() {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager=MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme=MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme=new ColorScheme(Primary.BlueGrey800,Primary.BlueGrey900,Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
            materialSkinManager.ColorScheme=new ColorScheme(Primary.Green600,Primary.Green700,Primary.Green200,Accent.Red100,TextShade.WHITE);

            iPlayer.Text="残机";
            iPlayer.Action=delegate () { thCode.SetIPlayer(iPlayer.number); };
            iPlayerFragment.Text="残机碎片";
            iPlayerFragment.Action=delegate () { thCode.SetIPlayerFragment(iPlayerFragment.number); };
            iBomb.Text="Bomb";
            iBomb.Action=delegate () { thCode.SetIBomb(iBomb.number); };
            iBombFragment.Text="Bomb碎片";
            iBombFragment.Action=delegate () { thCode.SetIBomb(iBombFragment.number); };
            iPower.Text="灵力";
            iPower.Action=delegate () { thCode.SetIPower(iPower.number); };
            iScore.Text="得分";
            iScore.Action=delegate () { thCode.SetIScore(iScore.number); };
            iMaxPoint.Text="最大得点";
            iMaxPoint.Action=delegate () { thCode.SetIPlayer(iMaxPoint.number); };

            player.Text="残机";
            player.Action=delegate () { thCode.SetPlayer(player.number); };
            playerFragment.Text="残机碎片";
            playerFragment.Action=delegate () { thCode.SetPlayerFragment(playerFragment.number); };
            bomb.Text="Bomb";
            bomb.Action=delegate () { thCode.SetBomb(bomb.number); };
            bombFragment.Text="Bomb碎片";
            bombFragment.Action=delegate () { thCode.SetBomb(bombFragment.number); };
            power.Text="灵力";
            power.Action=delegate () { thCode.SetPower(power.number); };
            score.Text="得分";
            score.Action=delegate () { thCode.SetScore(score.number); };
            maxPoint.Text="最大得点";
            maxPoint.Action=delegate () { thCode.SetPlayer(maxPoint.number); };


        }

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

        private void materialButton1_Click(object sender,EventArgs e) {
            materialSkinManager.Theme=materialSkinManager.Theme==MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        private int colorSchemeIndex;
        private void materialRaisedButton1_Click(object sender,EventArgs e) {
            colorSchemeIndex++;
            if(colorSchemeIndex>2) colorSchemeIndex=0;

            //These are just example color schemes
            switch(colorSchemeIndex) {
                case 0:
                    materialSkinManager.ColorScheme=new ColorScheme(Primary.BlueGrey800,Primary.BlueGrey900,Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme=new ColorScheme(Primary.Indigo500,Primary.Indigo700,Primary.Indigo100,Accent.Pink200,TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme=new ColorScheme(Primary.Green600,Primary.Green700,Primary.Green200,Accent.Red100,TextShade.WHITE);
                    break;
            }
        }

        private void comboBoxChapter_selected(object sender,EventArgs e) {

        }

        private void comboBoxStage_selected(object sender,EventArgs e) {

        }

        private void comboBoxBoss_selected(object sender,EventArgs e) {

        }

        private void comboBoxMBoss_selected(object sender,EventArgs e) {

        }
        
    }
}
