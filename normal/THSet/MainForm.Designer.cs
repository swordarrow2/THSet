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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("boss1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("spell1");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("boss2");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("spell2");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("boss3");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("spell3");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("前半道中");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("道中boss");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("太田飞行阵");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("后半道中");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("关底boss");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("stage1");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("stage2");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("stage3");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("stage4");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("stage5");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("stage6");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("extra");
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.custom = new MaterialSkin.Controls.MaterialRadioButton();
            this._90 = new MaterialSkin.Controls.MaterialRadioButton();
            this._75 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.materialListView3 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.killSelf = new MaterialSkin.Controls.MaterialFlatButton();
            this.autoBomb = new MaterialSkin.Controls.MaterialCheckBox();
            this.lockBomb = new MaterialSkin.Controls.MaterialCheckBox();
            this.unbeatable = new MaterialSkin.Controls.MaterialCheckBox();
            this.lockPlayer = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(233, 462);
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
            this.materialFlatButton1.Location = new System.Drawing.Point(333, 462);
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
            this.materialDivider1.Size = new System.Drawing.Size(431, 1);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // custom
            // 
            this.custom.AutoSize = true;
            this.custom.Cursor = System.Windows.Forms.Cursors.Default;
            this.custom.Depth = 0;
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
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSize = true;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(190, 78);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Primary = true;
            this.materialButton1.Size = new System.Drawing.Size(125, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Change Theme";
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // _60
            // 
            this._60.AutoSize = true;
            this._60.Checked = true;
            this._60.Cursor = System.Windows.Forms.Cursors.Default;
            this._60.Depth = 0;
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
            this.materialTabSelector1.Size = new System.Drawing.Size(431, 44);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
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
            this.materialTabControl1.Size = new System.Drawing.Size(397, 345);
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
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(389, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "初始值";
            // 
            // iMaxPoint
            // 
            this.iMaxPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iMaxPoint.Location = new System.Drawing.Point(6, 234);
            this.iMaxPoint.Name = "iMaxPoint";
            this.iMaxPoint.number = 0;
            this.iMaxPoint.Size = new System.Drawing.Size(168, 32);
            this.iMaxPoint.TabIndex = 28;
            this.iMaxPoint.TabStop = false;
            // 
            // iScore
            // 
            this.iScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iScore.Location = new System.Drawing.Point(6, 196);
            this.iScore.Name = "iScore";
            this.iScore.number = 0;
            this.iScore.Size = new System.Drawing.Size(168, 32);
            this.iScore.TabIndex = 27;
            this.iScore.TabStop = false;
            // 
            // iPower
            // 
            this.iPower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iPower.Location = new System.Drawing.Point(6, 158);
            this.iPower.Name = "iPower";
            this.iPower.number = 0;
            this.iPower.Size = new System.Drawing.Size(168, 32);
            this.iPower.TabIndex = 26;
            this.iPower.TabStop = false;
            // 
            // iBombFragment
            // 
            this.iBombFragment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iBombFragment.Location = new System.Drawing.Point(6, 120);
            this.iBombFragment.Name = "iBombFragment";
            this.iBombFragment.number = 0;
            this.iBombFragment.Size = new System.Drawing.Size(168, 32);
            this.iBombFragment.TabIndex = 25;
            this.iBombFragment.TabStop = false;
            // 
            // iBomb
            // 
            this.iBomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iBomb.Location = new System.Drawing.Point(6, 82);
            this.iBomb.Name = "iBomb";
            this.iBomb.number = 0;
            this.iBomb.Size = new System.Drawing.Size(168, 32);
            this.iBomb.TabIndex = 24;
            this.iBomb.TabStop = false;
            // 
            // iPlayerFragment
            // 
            this.iPlayerFragment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iPlayerFragment.Location = new System.Drawing.Point(6, 44);
            this.iPlayerFragment.Name = "iPlayerFragment";
            this.iPlayerFragment.number = 0;
            this.iPlayerFragment.Size = new System.Drawing.Size(168, 32);
            this.iPlayerFragment.TabIndex = 23;
            this.iPlayerFragment.TabStop = false;
            // 
            // iPlayer
            // 
            this.iPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iPlayer.Location = new System.Drawing.Point(6, 7);
            this.iPlayer.Name = "iPlayer";
            this.iPlayer.number = 0;
            this.iPlayer.Size = new System.Drawing.Size(168, 32);
            this.iPlayer.TabIndex = 22;
            this.iPlayer.TabStop = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(190, 120);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(181, 36);
            this.materialRaisedButton1.TabIndex = 21;
            this.materialRaisedButton1.Text = "Change color scheme";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
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
            this.tabPage2.Size = new System.Drawing.Size(389, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "当前值";
            // 
            // maxPoint
            // 
            this.maxPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxPoint.Location = new System.Drawing.Point(6, 234);
            this.maxPoint.Name = "maxPoint";
            this.maxPoint.number = 0;
            this.maxPoint.Size = new System.Drawing.Size(168, 32);
            this.maxPoint.TabIndex = 35;
            this.maxPoint.TabStop = false;
            // 
            // score
            // 
            this.score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.score.Location = new System.Drawing.Point(6, 196);
            this.score.Name = "score";
            this.score.number = 0;
            this.score.Size = new System.Drawing.Size(168, 32);
            this.score.TabIndex = 34;
            this.score.TabStop = false;
            // 
            // power
            // 
            this.power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.power.Location = new System.Drawing.Point(6, 158);
            this.power.Name = "power";
            this.power.number = 0;
            this.power.Size = new System.Drawing.Size(168, 32);
            this.power.TabIndex = 33;
            this.power.TabStop = false;
            // 
            // bombFragment
            // 
            this.bombFragment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bombFragment.Location = new System.Drawing.Point(6, 120);
            this.bombFragment.Name = "bombFragment";
            this.bombFragment.number = 0;
            this.bombFragment.Size = new System.Drawing.Size(168, 32);
            this.bombFragment.TabIndex = 32;
            this.bombFragment.TabStop = false;
            // 
            // bomb
            // 
            this.bomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bomb.Location = new System.Drawing.Point(6, 82);
            this.bomb.Name = "bomb";
            this.bomb.number = 0;
            this.bomb.Size = new System.Drawing.Size(168, 32);
            this.bomb.TabIndex = 31;
            this.bomb.TabStop = false;
            // 
            // playerFragment
            // 
            this.playerFragment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerFragment.Location = new System.Drawing.Point(6, 44);
            this.playerFragment.Name = "playerFragment";
            this.playerFragment.number = 0;
            this.playerFragment.Size = new System.Drawing.Size(168, 32);
            this.playerFragment.TabIndex = 30;
            this.playerFragment.TabStop = false;
            // 
            // player
            // 
            this.player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.tabPage3.Size = new System.Drawing.Size(389, 319);
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
            this.dpsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.dpsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dpsLabel.Location = new System.Drawing.Point(70, 150);
            this.dpsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dpsLabel.Name = "dpsLabel";
            this.dpsLabel.Size = new System.Drawing.Size(52, 19);
            this.dpsLabel.TabIndex = 22;
            this.dpsLabel.Text = "DPF:   ";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Depth = 0;
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
            this.tabPage4.Controls.Add(this.materialListView3);
            this.tabPage4.Controls.Add(this.materialListView2);
            this.tabPage4.Controls.Add(this.materialListView1);
            this.tabPage4.Controls.Add(this.killSelf);
            this.tabPage4.Controls.Add(this.autoBomb);
            this.tabPage4.Controls.Add(this.lockBomb);
            this.tabPage4.Controls.Add(this.unbeatable);
            this.tabPage4.Controls.Add(this.lockPlayer);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(389, 319);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "练习";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialListView3
            // 
            this.materialListView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.materialListView3.Depth = 0;
            this.materialListView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView3.FullRowSelect = true;
            this.materialListView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView3.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.materialListView3.Location = new System.Drawing.Point(282, 3);
            this.materialListView3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView3.Name = "materialListView3";
            this.materialListView3.OwnerDraw = true;
            this.materialListView3.Size = new System.Drawing.Size(75, 313);
            this.materialListView3.TabIndex = 7;
            this.materialListView3.UseCompatibleStateImageBehavior = false;
            this.materialListView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "boss";
            this.columnHeader3.Width = 75;
            // 
            // materialListView2
            // 
            this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.materialListView2.Depth = 0;
            this.materialListView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView2.FullRowSelect = true;
            this.materialListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11});
            this.materialListView2.Location = new System.Drawing.Point(172, 3);
            this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView2.Name = "materialListView2";
            this.materialListView2.OwnerDraw = true;
            this.materialListView2.Size = new System.Drawing.Size(104, 295);
            this.materialListView2.TabIndex = 6;
            this.materialListView2.UseCompatibleStateImageBehavior = false;
            this.materialListView2.View = System.Windows.Forms.View.Details;
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.materialListView1.Location = new System.Drawing.Point(98, 3);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(75, 344);
            this.materialListView1.TabIndex = 5;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
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
            // 
            // autoBomb
            // 
            this.autoBomb.AutoSize = true;
            this.autoBomb.Depth = 0;
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
            // 
            // lockBomb
            // 
            this.lockBomb.AutoSize = true;
            this.lockBomb.Depth = 0;
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
            // 
            // unbeatable
            // 
            this.unbeatable.AutoSize = true;
            this.unbeatable.Depth = 0;
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
            // 
            // lockPlayer
            // 
            this.lockPlayer.AutoSize = true;
            this.lockPlayer.Depth = 0;
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
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.disabledItemToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.item3ToolStripMenuItem});
            this.materialContextMenuStrip1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(166, 130);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.AutoSize = false;
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItem1ToolStripMenuItem,
            this.subItem2ToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item1ToolStripMenuItem.Text = "Item 1";
            // 
            // subItem1ToolStripMenuItem
            // 
            this.subItem1ToolStripMenuItem.AutoSize = false;
            this.subItem1ToolStripMenuItem.Name = "subItem1ToolStripMenuItem";
            this.subItem1ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem1ToolStripMenuItem.Text = "SubItem 1";
            // 
            // subItem2ToolStripMenuItem
            // 
            this.subItem2ToolStripMenuItem.AutoSize = false;
            this.subItem2ToolStripMenuItem.Name = "subItem2ToolStripMenuItem";
            this.subItem2ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem2ToolStripMenuItem.Text = "SubItem 2";
            // 
            // disabledItemToolStripMenuItem
            // 
            this.disabledItemToolStripMenuItem.AutoSize = false;
            this.disabledItemToolStripMenuItem.Enabled = false;
            this.disabledItemToolStripMenuItem.Name = "disabledItemToolStripMenuItem";
            this.disabledItemToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.disabledItemToolStripMenuItem.Text = "Disabled item";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.AutoSize = false;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.AutoSize = false;
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item3ToolStripMenuItem.Text = "Item 3";
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Enabled = false;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(149, 462);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(84, 36);
            this.materialFlatButton3.TabIndex = 19;
            this.materialFlatButton3.Text = "DISABLED";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "chapter";
            this.columnHeader2.Width = 104;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 505);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "MainForm";
            this.Text = "MaterialSkin Demo";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialButton1;
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
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
		private MaterialRaisedButton materialRaisedButton1;
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
        private MaterialListView materialListView1;
        private MaterialListView materialListView3;
        private ColumnHeader columnHeader3;
        private MaterialListView materialListView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}