using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public partial class FloatWindow:Form {
        private Point ptMouseCurrrnetPos, ptMouseNewPos, ptFormPos, ptFormNewPos;
        private bool blnMouseDown = false;
        private MainForm parent;
        public FloatWindow(MainForm pMain) {
            InitializeComponent();
            parent=pMain;
        }

        private void floatWindow_Load(object sender,EventArgs e) {
            Show();
            Location=(Point)new Size(Properties.Settings.Default.floatWindowX,Properties.Settings.Default.floatWindowY);
        }
        private void floatWindow_MouseMove(object sender,MouseEventArgs e) {
            if(blnMouseDown) {
                ptMouseNewPos=MousePosition;
                ptFormNewPos.X=ptMouseNewPos.X-ptMouseCurrrnetPos.X+ptFormPos.X;
                ptFormNewPos.Y=ptMouseNewPos.Y-ptMouseCurrrnetPos.Y+ptFormPos.Y;
                Location=ptFormNewPos;
                ptFormPos=ptFormNewPos;
                ptMouseCurrrnetPos=ptMouseNewPos;
            }
        }
        private void floatWindow_MouseDown(object sender,MouseEventArgs e) {
            if(e.Button==MouseButtons.Left) {
                blnMouseDown=true;
                ptMouseCurrrnetPos=MousePosition;
                ptFormPos=Location;
            }
        }
        private void floatWindow_MouseUp(object sender,MouseEventArgs e) {
            if(e.Button==MouseButtons.Left) {
                blnMouseDown=false;
                Properties.Settings.Default.floatWindowX=Location.X;
                Properties.Settings.Default.floatWindowY=Location.Y;
                Properties.Settings.Default.Save();
            }
        }
        private void floatWindow_DoubleClick(object sender,MouseEventArgs e) {
            parent.RestoreWindow();
            Hide();
        }
        private void timerFloatWindow_Tick(object sender,EventArgs e) {
            if(parent.page3data.miss!=-1) lbMissCount.Text="miss次数:"+parent.page3data.miss;
            if(parent.page3data.bomb!=-1) lbBombCount.Text="bomb次数:"+parent.page3data.bomb;
            lbBulletCount.Text="子弹数:"+parent.page3data.bullet;
            lbLife.Text="血量:"+parent.page3data.hp;
            lbDPS.Text="DPS:"+parent.page3data.dps;
            if(parent.gameNum==7) {
                sp1.Text="樱道具";
            }
        }

        private void setBG(object sender,EventArgs e) {
            //      Opacity=parent.trackBarA.Value/100.0f;
            //      BackColor=btnBack.BackColor=btnCountStart.BackColor=Color.FromArgb(parent.trackBarR.Value,parent.trackBarG.Value,parent.trackBarB.Value);
            //      ForeColor=Color.FromArgb(parent.trackBarFontR.Value,parent.trackBarFontG.Value,parent.trackBarFontB.Value);
            //      groupBoxBoss.ForeColor=groupBoxSourceUse.ForeColor=groupBoxOther.ForeColor=Color.FromArgb(parent.trackBarFontR.Value,parent.trackBarFontG.Value,parent.trackBarFontB.Value);
        }

        private void btnBack_Click(object sender,EventArgs e) {
            parent.RestoreWindow();
            Hide();
        }

        private void btnCountStart_Click(object sender,EventArgs e) => MainForm.thCode.StartCount();
        private void btnKill_Click_1(object sender,EventArgs e) => MainForm.thCode.KillSelf();
    }
}
