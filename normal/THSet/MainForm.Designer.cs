using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace THSet
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("boss1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("spell1");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("boss2");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("spell2");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("boss3");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("spell3");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("前半道中");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("道中boss");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("后半道中");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("关底boss");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Stage1");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Stage2");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Stage3");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Stage4");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Stage5");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Stage6");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Extra");
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.custom = new MaterialSkin.Controls.MaterialRadioButton();
            this._90 = new MaterialSkin.Controls.MaterialRadioButton();
            this._75 = new MaterialSkin.Controls.MaterialRadioButton();
            this._60 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iMaxPoint = new THSet.EditText();
            this.iScore = new THSet.EditText();
            this.iPower = new THSet.EditText();
            this.iBombFragment = new THSet.EditText();
            this.iBomb = new THSet.EditText();
            this.iPlayerFragment = new THSet.EditText();
            this.iPlayer = new THSet.EditText();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.maxPoint = new THSet.EditText();
            this.score = new THSet.EditText();
            this.power = new THSet.EditText();
            this.bombFragment = new THSet.EditText();
            this.bomb = new THSet.EditText();
            this.playerFragment = new THSet.EditText();
            this.player = new THSet.EditText();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.otherLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.otherLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.otherLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bulletLable = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dpsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.hpLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bombLable = new MaterialSkin.Controls.MaterialLabel();
            this.missLable = new MaterialSkin.Controls.MaterialLabel();
            this.fpsButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.customFPS = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bossList = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chapterList = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stageList = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.killSelf = new MaterialSkin.Controls.MaterialFlatButton();
            this.autoBomb = new MaterialSkin.Controls.MaterialCheckBox();
            this.lockBomb = new MaterialSkin.Controls.MaterialCheckBox();
            this.unbeatable = new MaterialSkin.Controls.MaterialCheckBox();
            this.lockPlayer = new MaterialSkin.Controls.MaterialCheckBox();
            this.mainMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.greenLight = new System.Windows.Forms.ToolStripMenuItem();
            this.greenDark = new System.Windows.Forms.ToolStripMenuItem();
            this.blueLight = new System.Windows.Forms.ToolStripMenuItem();
            this.blueDark = new System.Windows.Forms.ToolStripMenuItem();
            this.grayLight = new System.Windows.Forms.ToolStripMenuItem();
            this.grayDark = new System.Windows.Forms.ToolStripMenuItem();
            this.floatWindowColor = new System.Windows.Forms.ToolStripMenuItem();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.timeMAndB = new System.Windows.Forms.Timer(this.components);
            this.timeProcess = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(211, 462);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(100, 36);
            this.materialFlatButton2.TabIndex = 13;
            this.materialFlatButton2.Text = "Secondary";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(311, 462);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.Size = new System.Drawing.Size(80, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "Primary";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 459);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(409, 1);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // custom
            // 
            this.custom.AutoSize = true;
            this.custom.Cursor = System.Windows.Forms.Cursors.Default;
            this.custom.Depth = 0;
            this.custom.Enabled = false;
            this.custom.Font = new System.Drawing.Font("Roboto", 10F);
            this.custom.Location = new System.Drawing.Point(3, 37);
            this.custom.Margin = new System.Windows.Forms.Padding(0);
            this.custom.MouseLocation = new System.Drawing.Point(-1, -1);
            this.custom.MouseState = MaterialSkin.MouseState.HOVER;
            this.custom.Name = "custom";
            this.custom.Ripple = true;
            this.custom.Size = new System.Drawing.Size(74, 30);
            this.custom.TabIndex = 15;
            this.custom.Text = "自定义";
            this.custom.UseVisualStyleBackColor = true;
            this.custom.CheckedChanged += new System.EventHandler(this.setFps);
            // 
            // _90
            // 
            this._90.AutoSize = true;
            this._90.Cursor = System.Windows.Forms.Cursors.Default;
            this._90.Depth = 0;
            this._90.Enabled = false;
            this._90.Font = new System.Drawing.Font("Roboto", 10F);
            this._90.Location = new System.Drawing.Point(138, 7);
            this._90.Margin = new System.Windows.Forms.Padding(0);
            this._90.MouseLocation = new System.Drawing.Point(-1, -1);
            this._90.MouseState = MaterialSkin.MouseState.HOVER;
            this._90.Name = "_90";
            this._90.Ripple = true;
            this._90.Size = new System.Drawing.Size(69, 30);
            this._90.TabIndex = 11;
            this._90.Text = "90FPS";
            this._90.UseVisualStyleBackColor = true;
            this._90.CheckedChanged += new System.EventHandler(this.setFps);
            // 
            // _75
            // 
            this._75.AutoSize = true;
            this._75.Cursor = System.Windows.Forms.Cursors.Default;
            this._75.Depth = 0;
            this._75.Enabled = false;
            this._75.Font = new System.Drawing.Font("Roboto", 10F);
            this._75.Location = new System.Drawing.Point(69, 7);
            this._75.Margin = new System.Windows.Forms.Padding(0);
            this._75.MouseLocation = new System.Drawing.Point(-1, -1);
            this._75.MouseState = MaterialSkin.MouseState.HOVER;
            this._75.Name = "_75";
            this._75.Ripple = true;
            this._75.Size = new System.Drawing.Size(69, 30);
            this._75.TabIndex = 10;
            this._75.Text = "75FPS";
            this._75.UseVisualStyleBackColor = true;
            this._75.CheckedChanged += new System.EventHandler(this.setFps);
            // 
            // _60
            // 
            this._60.AutoSize = true;
            this._60.Checked = true;
            this._60.Cursor = System.Windows.Forms.Cursors.Default;
            this._60.Depth = 0;
            this._60.Enabled = false;
            this._60.Font = new System.Drawing.Font("Roboto", 10F);
            this._60.Location = new System.Drawing.Point(0, 7);
            this._60.Margin = new System.Windows.Forms.Padding(0);
            this._60.MouseLocation = new System.Drawing.Point(-1, -1);
            this._60.MouseState = MaterialSkin.MouseState.HOVER;
            this._60.Name = "_60";
            this._60.Ripple = true;
            this._60.Size = new System.Drawing.Size(69, 30);
            this._60.TabIndex = 9;
            this._60.TabStop = true;
            this._60.Text = "60FPS";
            this._60.UseVisualStyleBackColor = true;
            this._60.CheckedChanged += new System.EventHandler(this.setFps);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 59);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(409, 44);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(14, 102);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(375, 345);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.iMaxPoint);
            this.tabPage1.Controls.Add(this.iScore);
            this.tabPage1.Controls.Add(this.iPower);
            this.tabPage1.Controls.Add(this.iBombFragment);
            this.tabPage1.Controls.Add(this.iBomb);
            this.tabPage1.Controls.Add(this.iPlayerFragment);
            this.tabPage1.Controls.Add(this.iPlayer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "初始值";
            // 
            // iMaxPoint
            // 
            this.iMaxPoint.Location = new System.Drawing.Point(6, 234);
            this.iMaxPoint.Name = "iMaxPoint";
            this.iMaxPoint.number = 0;
            this.iMaxPoint.Size = new System.Drawing.Size(168, 32);
            this.iMaxPoint.TabIndex = 28;
            this.iMaxPoint.TabStop = false;
            // 
            // iScore
            // 
            this.iScore.Location = new System.Drawing.Point(6, 196);
            this.iScore.Name = "iScore";
            this.iScore.number = 0;
            this.iScore.Size = new System.Drawing.Size(168, 32);
            this.iScore.TabIndex = 27;
            this.iScore.TabStop = false;
            // 
            // iPower
            // 
            this.iPower.Location = new System.Drawing.Point(6, 158);
            this.iPower.Name = "iPower";
            this.iPower.number = 0;
            this.iPower.Size = new System.Drawing.Size(168, 32);
            this.iPower.TabIndex = 26;
            this.iPower.TabStop = false;
            // 
            // iBombFragment
            // 
            this.iBombFragment.Location = new System.Drawing.Point(6, 120);
            this.iBombFragment.Name = "iBombFragment";
            this.iBombFragment.number = 0;
            this.iBombFragment.Size = new System.Drawing.Size(168, 32);
            this.iBombFragment.TabIndex = 25;
            this.iBombFragment.TabStop = false;
            // 
            // iBomb
            // 
            this.iBomb.Location = new System.Drawing.Point(6, 82);
            this.iBomb.Name = "iBomb";
            this.iBomb.number = 0;
            this.iBomb.Size = new System.Drawing.Size(168, 32);
            this.iBomb.TabIndex = 24;
            this.iBomb.TabStop = false;
            // 
            // iPlayerFragment
            // 
            this.iPlayerFragment.Location = new System.Drawing.Point(6, 44);
            this.iPlayerFragment.Name = "iPlayerFragment";
            this.iPlayerFragment.number = 0;
            this.iPlayerFragment.Size = new System.Drawing.Size(168, 32);
            this.iPlayerFragment.TabIndex = 23;
            this.iPlayerFragment.TabStop = false;
            // 
            // iPlayer
            // 
            this.iPlayer.Location = new System.Drawing.Point(6, 7);
            this.iPlayer.Name = "iPlayer";
            this.iPlayer.number = 0;
            this.iPlayer.Size = new System.Drawing.Size(168, 32);
            this.iPlayer.TabIndex = 22;
            this.iPlayer.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.maxPoint);
            this.tabPage2.Controls.Add(this.score);
            this.tabPage2.Controls.Add(this.power);
            this.tabPage2.Controls.Add(this.bombFragment);
            this.tabPage2.Controls.Add(this.bomb);
            this.tabPage2.Controls.Add(this.playerFragment);
            this.tabPage2.Controls.Add(this.player);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(367, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "当前值";
            // 
            // maxPoint
            // 
            this.maxPoint.Enabled = false;
            this.maxPoint.Location = new System.Drawing.Point(6, 234);
            this.maxPoint.Name = "maxPoint";
            this.maxPoint.number = 0;
            this.maxPoint.Size = new System.Drawing.Size(168, 32);
            this.maxPoint.TabIndex = 35;
            this.maxPoint.TabStop = false;
            // 
            // score
            // 
            this.score.Enabled = false;
            this.score.Location = new System.Drawing.Point(6, 196);
            this.score.Name = "score";
            this.score.number = 0;
            this.score.Size = new System.Drawing.Size(168, 32);
            this.score.TabIndex = 34;
            this.score.TabStop = false;
            // 
            // power
            // 
            this.power.Enabled = false;
            this.power.Location = new System.Drawing.Point(6, 158);
            this.power.Name = "power";
            this.power.number = 0;
            this.power.Size = new System.Drawing.Size(168, 32);
            this.power.TabIndex = 33;
            this.power.TabStop = false;
            // 
            // bombFragment
            // 
            this.bombFragment.Enabled = false;
            this.bombFragment.Location = new System.Drawing.Point(6, 120);
            this.bombFragment.Name = "bombFragment";
            this.bombFragment.number = 0;
            this.bombFragment.Size = new System.Drawing.Size(168, 32);
            this.bombFragment.TabIndex = 32;
            this.bombFragment.TabStop = false;
            // 
            // bomb
            // 
            this.bomb.Enabled = false;
            this.bomb.Location = new System.Drawing.Point(6, 82);
            this.bomb.Name = "bomb";
            this.bomb.number = 0;
            this.bomb.Size = new System.Drawing.Size(168, 32);
            this.bomb.TabIndex = 31;
            this.bomb.TabStop = false;
            // 
            // playerFragment
            // 
            this.playerFragment.Enabled = false;
            this.playerFragment.Location = new System.Drawing.Point(6, 44);
            this.playerFragment.Name = "playerFragment";
            this.playerFragment.number = 0;
            this.playerFragment.Size = new System.Drawing.Size(168, 32);
            this.playerFragment.TabIndex = 30;
            this.playerFragment.TabStop = false;
            // 
            // player
            // 
            this.player.Enabled = false;
            this.player.Location = new System.Drawing.Point(6, 7);
            this.player.Name = "player";
            this.player.number = 0;
            this.player.Size = new System.Drawing.Size(168, 32);
            this.player.TabIndex = 29;
            this.player.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.otherLabel3);
            this.tabPage3.Controls.Add(this.otherLabel2);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Controls.Add(this.otherLabel1);
            this.tabPage3.Controls.Add(this.bulletLable);
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Controls.Add(this.dpsLabel);
            this.tabPage3.Controls.Add(this.hpLabel);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.bombLable);
            this.tabPage3.Controls.Add(this.missLable);
            this.tabPage3.Controls.Add(this.fpsButton);
            this.tabPage3.Controls.Add(this.customFPS);
            this.tabPage3.Controls.Add(this.custom);
            this.tabPage3.Controls.Add(this._60);
            this.tabPage3.Controls.Add(this._75);
            this.tabPage3.Controls.Add(this._90);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(367, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "基本";
            // 
            // otherLabel3
            // 
            this.otherLabel3.AutoSize = true;
            this.otherLabel3.Depth = 0;
            this.otherLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.otherLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.otherLabel3.Location = new System.Drawing.Point(6, 262);
            this.otherLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.otherLabel3.Name = "otherLabel3";
            this.otherLabel3.Size = new System.Drawing.Size(13, 19);
            this.otherLabel3.TabIndex = 28;
            this.otherLabel3.Text = "-";
            // 
            // otherLabel2
            // 
            this.otherLabel2.AutoSize = true;
            this.otherLabel2.Depth = 0;
            this.otherLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.otherLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.otherLabel2.Location = new System.Drawing.Point(6, 243);
            this.otherLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.otherLabel2.Name = "otherLabel2";
            this.otherLabel2.Size = new System.Drawing.Size(13, 19);
            this.otherLabel2.TabIndex = 27;
            this.otherLabel2.Text = "-";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 186);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(45, 19);
            this.materialLabel4.TabIndex = 26;
            this.materialLabel4.Text = "其它:";
            // 
            // otherLabel1
            // 
            this.otherLabel1.AutoSize = true;
            this.otherLabel1.Depth = 0;
            this.otherLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.otherLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.otherLabel1.Location = new System.Drawing.Point(6, 224);
            this.otherLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.otherLabel1.Name = "otherLabel1";
            this.otherLabel1.Size = new System.Drawing.Size(13, 19);
            this.otherLabel1.TabIndex = 25;
            this.otherLabel1.Text = "-";
            // 
            // bulletLable
            // 
            this.bulletLable.AutoSize = true;
            this.bulletLable.Depth = 0;
            this.bulletLable.Enabled = false;
            this.bulletLable.Font = new System.Drawing.Font("Roboto", 11F);
            this.bulletLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bulletLable.Location = new System.Drawing.Point(6, 205);
            this.bulletLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.bulletLable.Name = "bulletLable";
            this.bulletLable.Size = new System.Drawing.Size(89, 19);
            this.bulletLable.TabIndex = 24;
            this.bulletLable.Text = "子弹数量:   ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 131);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(78, 19);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "boss相关:";
            // 
            // dpsLabel
            // 
            this.dpsLabel.AutoSize = true;
            this.dpsLabel.Depth = 0;
            this.dpsLabel.Enabled = false;
            this.dpsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.dpsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dpsLabel.Location = new System.Drawing.Point(70, 150);
            this.dpsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dpsLabel.Name = "dpsLabel";
            this.dpsLabel.Size = new System.Drawing.Size(53, 19);
            this.dpsLabel.TabIndex = 22;
            this.dpsLabel.Text = "DPS:   ";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Depth = 0;
            this.hpLabel.Enabled = false;
            this.hpLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.hpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hpLabel.Location = new System.Drawing.Point(6, 150);
            this.hpLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(45, 19);
            this.hpLabel.TabIndex = 21;
            this.hpLabel.Text = "HP:   ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "资源消耗:";
            // 
            // bombLable
            // 
            this.bombLable.AutoSize = true;
            this.bombLable.Depth = 0;
            this.bombLable.Enabled = false;
            this.bombLable.Font = new System.Drawing.Font("Roboto", 11F);
            this.bombLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bombLable.Location = new System.Drawing.Point(70, 99);
            this.bombLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.bombLable.Name = "bombLable";
            this.bombLable.Size = new System.Drawing.Size(63, 19);
            this.bombLable.TabIndex = 19;
            this.bombLable.Text = "bomb:   ";
            // 
            // missLable
            // 
            this.missLable.AutoSize = true;
            this.missLable.Depth = 0;
            this.missLable.Enabled = false;
            this.missLable.Font = new System.Drawing.Font("Roboto", 11F);
            this.missLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.missLable.Location = new System.Drawing.Point(6, 99);
            this.missLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.missLable.Name = "missLable";
            this.missLable.Size = new System.Drawing.Size(58, 19);
            this.missLable.TabIndex = 18;
            this.missLable.Text = "miss:   ";
            // 
            // fpsButton
            // 
            this.fpsButton.AutoSize = true;
            this.fpsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fpsButton.Depth = 0;
            this.fpsButton.Enabled = false;
            this.fpsButton.Icon = null;
            this.fpsButton.Location = new System.Drawing.Point(138, 35);
            this.fpsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fpsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.fpsButton.Name = "fpsButton";
            this.fpsButton.Primary = false;
            this.fpsButton.Size = new System.Drawing.Size(51, 36);
            this.fpsButton.TabIndex = 17;
            this.fpsButton.Text = "修改";
            this.fpsButton.UseVisualStyleBackColor = true;
            this.fpsButton.Click += new System.EventHandler(this.fpsButton_Click);
            // 
            // customFPS
            // 
            this.customFPS.Depth = 0;
            this.customFPS.Enabled = false;
            this.customFPS.Hint = "FPS";
            this.customFPS.Location = new System.Drawing.Point(81, 41);
            this.customFPS.MaxLength = 32767;
            this.customFPS.MouseState = MaterialSkin.MouseState.HOVER;
            this.customFPS.Name = "customFPS";
            this.customFPS.PasswordChar = '\0';
            this.customFPS.SelectedText = "";
            this.customFPS.SelectionLength = 0;
            this.customFPS.SelectionStart = 0;
            this.customFPS.Size = new System.Drawing.Size(57, 23);
            this.customFPS.TabIndex = 16;
            this.customFPS.TabStop = false;
            this.customFPS.Text = "60";
            this.customFPS.UseSystemPasswordChar = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bossList);
            this.tabPage4.Controls.Add(this.chapterList);
            this.tabPage4.Controls.Add(this.stageList);
            this.tabPage4.Controls.Add(this.killSelf);
            this.tabPage4.Controls.Add(this.autoBomb);
            this.tabPage4.Controls.Add(this.lockBomb);
            this.tabPage4.Controls.Add(this.unbeatable);
            this.tabPage4.Controls.Add(this.lockPlayer);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(367, 319);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "练习";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bossList
            // 
            this.bossList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bossList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.bossList.Depth = 0;
            this.bossList.Enabled = false;
            this.bossList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.bossList.FullRowSelect = true;
            this.bossList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.bossList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.bossList.Location = new System.Drawing.Point(282, 3);
            this.bossList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bossList.MouseState = MaterialSkin.MouseState.OUT;
            this.bossList.Name = "bossList";
            this.bossList.OwnerDraw = true;
            this.bossList.Size = new System.Drawing.Size(75, 289);
            this.bossList.TabIndex = 7;
            this.bossList.UseCompatibleStateImageBehavior = false;
            this.bossList.View = System.Windows.Forms.View.Details;
            this.bossList.SelectedIndexChanged += new System.EventHandler(this.chapterPracticeSelect);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "boss";
            this.columnHeader3.Width = 75;
            // 
            // chapterList
            // 
            this.chapterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chapterList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.chapterList.Depth = 0;
            this.chapterList.Enabled = false;
            this.chapterList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.chapterList.FullRowSelect = true;
            this.chapterList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.chapterList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.chapterList.Location = new System.Drawing.Point(172, 3);
            this.chapterList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chapterList.MouseState = MaterialSkin.MouseState.OUT;
            this.chapterList.Name = "chapterList";
            this.chapterList.OwnerDraw = true;
            this.chapterList.Size = new System.Drawing.Size(104, 295);
            this.chapterList.TabIndex = 6;
            this.chapterList.UseCompatibleStateImageBehavior = false;
            this.chapterList.View = System.Windows.Forms.View.Details;
            this.chapterList.SelectedIndexChanged += new System.EventHandler(this.chapterPracticeSelect);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "chapter";
            this.columnHeader2.Width = 104;
            // 
            // stageList
            // 
            this.stageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.stageList.Depth = 0;
            this.stageList.Enabled = false;
            this.stageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.stageList.FullRowSelect = true;
            this.stageList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.stageList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17});
            this.stageList.Location = new System.Drawing.Point(98, 3);
            this.stageList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.stageList.MouseState = MaterialSkin.MouseState.OUT;
            this.stageList.Name = "stageList";
            this.stageList.OwnerDraw = true;
            this.stageList.Size = new System.Drawing.Size(75, 344);
            this.stageList.TabIndex = 5;
            this.stageList.UseCompatibleStateImageBehavior = false;
            this.stageList.View = System.Windows.Forms.View.Details;
            this.stageList.SelectedIndexChanged += new System.EventHandler(this.chapterPracticeSelect);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "stage";
            this.columnHeader1.Width = 75;
            // 
            // killSelf
            // 
            this.killSelf.AutoSize = true;
            this.killSelf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.killSelf.Depth = 0;
            this.killSelf.Enabled = false;
            this.killSelf.Icon = null;
            this.killSelf.Location = new System.Drawing.Point(9, 128);
            this.killSelf.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.killSelf.MouseState = MaterialSkin.MouseState.HOVER;
            this.killSelf.Name = "killSelf";
            this.killSelf.Primary = false;
            this.killSelf.Size = new System.Drawing.Size(51, 36);
            this.killSelf.TabIndex = 4;
            this.killSelf.Text = "自爆";
            this.killSelf.UseVisualStyleBackColor = true;
            this.killSelf.Click += new System.EventHandler(this.killSelf_Click);
            // 
            // autoBomb
            // 
            this.autoBomb.AutoSize = true;
            this.autoBomb.Depth = 0;
            this.autoBomb.Enabled = false;
            this.autoBomb.Font = new System.Drawing.Font("Roboto", 10F);
            this.autoBomb.Location = new System.Drawing.Point(0, 92);
            this.autoBomb.Margin = new System.Windows.Forms.Padding(0);
            this.autoBomb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.autoBomb.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoBomb.Name = "autoBomb";
            this.autoBomb.Ripple = true;
            this.autoBomb.Size = new System.Drawing.Size(75, 30);
            this.autoBomb.TabIndex = 3;
            this.autoBomb.Text = "自动雷";
            this.autoBomb.UseVisualStyleBackColor = true;
            this.autoBomb.CheckedChanged += new System.EventHandler(this.autoBomb_CheckedChanged);
            // 
            // lockBomb
            // 
            this.lockBomb.AutoSize = true;
            this.lockBomb.Depth = 0;
            this.lockBomb.Enabled = false;
            this.lockBomb.Font = new System.Drawing.Font("Roboto", 10F);
            this.lockBomb.Location = new System.Drawing.Point(0, 62);
            this.lockBomb.Margin = new System.Windows.Forms.Padding(0);
            this.lockBomb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lockBomb.MouseState = MaterialSkin.MouseState.HOVER;
            this.lockBomb.Name = "lockBomb";
            this.lockBomb.Ripple = true;
            this.lockBomb.Size = new System.Drawing.Size(95, 30);
            this.lockBomb.TabIndex = 2;
            this.lockBomb.Text = "无限bomb";
            this.lockBomb.UseVisualStyleBackColor = true;
            this.lockBomb.CheckedChanged += new System.EventHandler(this.lockBomb_CheckedChanged);
            // 
            // unbeatable
            // 
            this.unbeatable.AutoSize = true;
            this.unbeatable.Depth = 0;
            this.unbeatable.Enabled = false;
            this.unbeatable.Font = new System.Drawing.Font("Roboto", 10F);
            this.unbeatable.Location = new System.Drawing.Point(0, 32);
            this.unbeatable.Margin = new System.Windows.Forms.Padding(0);
            this.unbeatable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.unbeatable.MouseState = MaterialSkin.MouseState.HOVER;
            this.unbeatable.Name = "unbeatable";
            this.unbeatable.Ripple = true;
            this.unbeatable.Size = new System.Drawing.Size(60, 30);
            this.unbeatable.TabIndex = 1;
            this.unbeatable.Text = "无敌";
            this.unbeatable.UseVisualStyleBackColor = true;
            this.unbeatable.CheckedChanged += new System.EventHandler(this.unbeatable_CheckedChanged);
            // 
            // lockPlayer
            // 
            this.lockPlayer.AutoSize = true;
            this.lockPlayer.Depth = 0;
            this.lockPlayer.Enabled = false;
            this.lockPlayer.Font = new System.Drawing.Font("Roboto", 10F);
            this.lockPlayer.Location = new System.Drawing.Point(0, 2);
            this.lockPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.lockPlayer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lockPlayer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lockPlayer.Name = "lockPlayer";
            this.lockPlayer.Ripple = true;
            this.lockPlayer.Size = new System.Drawing.Size(90, 30);
            this.lockPlayer.TabIndex = 0;
            this.lockPlayer.Text = "无限残机";
            this.lockPlayer.UseVisualStyleBackColor = true;
            this.lockPlayer.CheckedChanged += new System.EventHandler(this.lockPlayer_CheckedChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.White;
            this.mainMenu.Depth = 0;
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.floatWindowColor});
            this.mainMenu.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.mainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainMenu.Name = "materialContextMenuStrip1";
            this.mainMenu.Size = new System.Drawing.Size(182, 56);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.AutoSize = false;
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenLight,
            this.greenDark,
            this.blueLight,
            this.blueDark,
            this.grayLight,
            this.grayDark});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item1ToolStripMenuItem.Text = "主题色";
            // 
            // greenLight
            // 
            this.greenLight.Name = "greenLight";
            this.greenLight.Size = new System.Drawing.Size(116, 22);
            this.greenLight.Text = "绿(亮)";
            this.greenLight.Click += new System.EventHandler(this.greenLight_Click);
            // 
            // greenDark
            // 
            this.greenDark.Name = "greenDark";
            this.greenDark.Size = new System.Drawing.Size(116, 22);
            this.greenDark.Text = "绿(暗)";
            this.greenDark.Click += new System.EventHandler(this.greenDark_Click);
            // 
            // blueLight
            // 
            this.blueLight.Name = "blueLight";
            this.blueLight.Size = new System.Drawing.Size(116, 22);
            this.blueLight.Text = "蓝(亮)";
            this.blueLight.Click += new System.EventHandler(this.blueLight_Click);
            // 
            // blueDark
            // 
            this.blueDark.Name = "blueDark";
            this.blueDark.Size = new System.Drawing.Size(116, 22);
            this.blueDark.Text = "蓝(暗)";
            this.blueDark.Click += new System.EventHandler(this.blueDark_Click);
            // 
            // grayLight
            // 
            this.grayLight.Name = "grayLight";
            this.grayLight.Size = new System.Drawing.Size(116, 22);
            this.grayLight.Text = "灰(亮)";
            this.grayLight.Click += new System.EventHandler(this.grayLight_Click);
            // 
            // grayDark
            // 
            this.grayDark.Name = "grayDark";
            this.grayDark.Size = new System.Drawing.Size(116, 22);
            this.grayDark.Text = "灰(暗)";
            this.grayDark.Click += new System.EventHandler(this.grayDark_Click);
            // 
            // floatWindowColor
            // 
            this.floatWindowColor.Name = "floatWindowColor";
            this.floatWindowColor.Size = new System.Drawing.Size(181, 22);
            this.floatWindowColor.Text = "悬浮窗颜色设置";
            this.floatWindowColor.Click += new System.EventHandler(this.floatWindowColor_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Enabled = false;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(127, 462);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(84, 36);
            this.materialFlatButton3.TabIndex = 19;
            this.materialFlatButton3.Text = "DISABLED";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // timeMAndB
            // 
            this.timeMAndB.Interval = 1000;
            this.timeMAndB.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeProcess
            // 
            this.timeProcess.Interval = 2000;
            this.timeProcess.Tick += new System.EventHandler(this.timeProcess_Tick);
            // 
            // timerEnemy
            // 
            this.timerEnemy.Interval = 10;
            this.timerEnemy.Tick += new System.EventHandler(this.timerEnemy_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 505);
            this.ContextMenuStrip = this.mainMenu;
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "MainForm";
            this.Text = "MaterialSkin Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRadioButton _60;
        private MaterialRadioButton _90;
        private MaterialFlatButton materialFlatButton2;
        private MaterialRadioButton custom;
        private MaterialDivider materialDivider1;
        private MaterialTabSelector materialTabSelector1;
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialContextMenuStrip mainMenu;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialFlatButton materialFlatButton3;
        private EditText iPlayerFragment;
        private EditText iPlayer;
        private EditText iMaxPoint;
        private EditText iScore;
        private EditText iPower;
        private EditText iBombFragment;
        private EditText iBomb;
        private EditText maxPoint;
        private EditText score;
        private EditText power;
        private EditText bombFragment;
        private EditText bomb;
        private EditText playerFragment;
        private EditText player;
        private MaterialRadioButton _75;
        private MaterialFlatButton fpsButton;
        private MaterialSingleLineTextField customFPS;
        private MaterialLabel materialLabel3;
        private MaterialLabel dpsLabel;
        private MaterialLabel hpLabel;
        private MaterialLabel materialLabel1;
        private MaterialLabel bombLable;
        private MaterialLabel missLable;
        private MaterialLabel otherLabel3;
        private MaterialLabel otherLabel2;
        private MaterialLabel materialLabel4;
        private MaterialLabel otherLabel1;
        private MaterialLabel bulletLable;
        private TabPage tabPage4;
        private MaterialCheckBox autoBomb;
        private MaterialCheckBox lockBomb;
        private MaterialCheckBox unbeatable;
        private MaterialCheckBox lockPlayer;
        private MaterialFlatButton killSelf;
        private MaterialListView stageList;
        private MaterialListView bossList;
        private ColumnHeader columnHeader3;
        private MaterialListView chapterList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ToolStripMenuItem greenLight;
        private ToolStripMenuItem greenDark;
        private ToolStripMenuItem blueLight;
        private ToolStripMenuItem blueDark;
        private ToolStripMenuItem floatWindowColor;
        private ToolStripMenuItem grayLight;
        private ToolStripMenuItem grayDark;
        private Timer timeMAndB;
        private Timer timeProcess;
        private Timer timerEnemy;
    }
}