using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public partial class floatWindow:Form {
        private int lastLife = 0;
        private int thisLife = 0;
        private Point ptMouseCurrrnetPos, ptMouseNewPos, ptFormPos, ptFormNewPos;
        private bool blnMouseDown = false;
        private MainForm parent;
        public floatWindow(MainForm pMain) {
            InitializeComponent();
            parent=pMain;
        }

        private void frmTopMost_Load(object sender,EventArgs e) {
            Show();
        }
        private void frmTopMost_MouseMove(object sender,MouseEventArgs e) {
            if(blnMouseDown) {
                ptMouseNewPos=MousePosition;
                ptFormNewPos.X=ptMouseNewPos.X-ptMouseCurrrnetPos.X+ptFormPos.X;
                ptFormNewPos.Y=ptMouseNewPos.Y-ptMouseCurrrnetPos.Y+ptFormPos.Y;
                Location=ptFormNewPos;
                ptFormPos=ptFormNewPos;
                ptMouseCurrrnetPos=ptMouseNewPos;
            }
        }
        private void frmTopMost_MouseDown(object sender,MouseEventArgs e) {
            if(e.Button==MouseButtons.Left) {
                blnMouseDown=true;
                ptMouseCurrrnetPos=MousePosition;
                ptFormPos=Location;
            }
        }
        private void frmTopMost_MouseUp(object sender,MouseEventArgs e) {
            if(e.Button==MouseButtons.Left)
                blnMouseDown=false;
        }
        private void frmTopMost_DoubleClick(object sender,MouseEventArgs e) {
            parent.RestoreWindow();
            Hide();
        }
        private void btnKill_Click(object sender,EventArgs e) => parent.tc.killSelf();
        private void timerMissAndBomb_Tick(object sender,EventArgs e) {
            lbMissCount.Text="miss次数:"+parent.tc.getMissCount();
            lbBombCount.Text="bomb次数:"+parent.tc.getBombCount();
        }
        private void timerEnemy_Tick(object sender,EventArgs e) {
            lbBulletCount.Text="子弹数:"+parent.tc.getBulletCount();
            lbLife.Text="血量:"+parent.tc.getBossLife();
        }

        private void setBG(object sender,EventArgs e) {
            Opacity=parent.trackBarA.Value/100.0f;
            BackColor=btnBack.BackColor=btnKill.BackColor=btnCountStart.BackColor=Color.FromArgb(parent.trackBarR.Value,parent.trackBarG.Value,parent.trackBarB.Value);
            ForeColor=Color.FromArgb(parent.trackBarFontR.Value,parent.trackBarFontG.Value,parent.trackBarFontB.Value);
            groupBoxBoss.ForeColor=groupBoxSourceUse.ForeColor=groupBoxOther.ForeColor=Color.FromArgb(parent.trackBarFontR.Value,parent.trackBarFontG.Value,parent.trackBarFontB.Value);
        }

        private void btnBack_Click(object sender,EventArgs e) {
            parent.RestoreWindow();
            Hide();
        }

        private void timerDPS_Tick(object sender,EventArgs e) {
            thisLife=parent.tc.getBossLife();
            lbDPS.Text="DPS:"+(lastLife-thisLife);
            lastLife=thisLife;
        }
        private void btnCountStart_Click(object sender,EventArgs e) => parent.tc.StartCount();
        private void btnKill_Click_1(object sender,EventArgs e) => parent.tc.killSelf();



    }
}
