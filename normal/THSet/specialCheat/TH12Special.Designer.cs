namespace THSet.specialCheat {
    partial class TH12Special {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.g2b = new MaterialSkin.Controls.MaterialRadioButton();
            this.g2g = new MaterialSkin.Controls.MaterialRadioButton();
            this.g2r = new MaterialSkin.Controls.MaterialRadioButton();
            this.g1b = new MaterialSkin.Controls.MaterialRadioButton();
            this.g1g = new MaterialSkin.Controls.MaterialRadioButton();
            this.g1r = new MaterialSkin.Controls.MaterialRadioButton();
            this.g1n = new MaterialSkin.Controls.MaterialRadioButton();
            this.g2n = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.g1n);
            this.groupBox1.Controls.Add(this.g1b);
            this.groupBox1.Controls.Add(this.g1g);
            this.groupBox1.Controls.Add(this.g1r);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "飞碟1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.g2n);
            this.groupBox2.Controls.Add(this.g2b);
            this.groupBox2.Controls.Add(this.g2g);
            this.groupBox2.Controls.Add(this.g2r);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(4, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 56);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "飞碟2";
            // 
            // g2b
            // 
            this.g2b.AutoSize = true;
            this.g2b.Depth = 0;
            this.g2b.Font = new System.Drawing.Font("Roboto", 10F);
            this.g2b.Location = new System.Drawing.Point(135, 17);
            this.g2b.Margin = new System.Windows.Forms.Padding(0);
            this.g2b.MouseLocation = new System.Drawing.Point(-1, -1);
            this.g2b.MouseState = MaterialSkin.MouseState.HOVER;
            this.g2b.Name = "g2b";
            this.g2b.Ripple = true;
            this.g2b.Size = new System.Drawing.Size(44, 30);
            this.g2b.TabIndex = 2;
            this.g2b.TabStop = true;
            this.g2b.Text = "蓝";
            this.g2b.UseVisualStyleBackColor = true;
            this.g2b.CheckedChanged += new System.EventHandler(this.SelectChanged);
            // 
            // g2g
            // 
            this.g2g.AutoSize = true;
            this.g2g.Depth = 0;
            this.g2g.Font = new System.Drawing.Font("Roboto", 10F);
            this.g2g.Location = new System.Drawing.Point(91, 17);
            this.g2g.Margin = new System.Windows.Forms.Padding(0);
            this.g2g.MouseLocation = new System.Drawing.Point(-1, -1);
            this.g2g.MouseState = MaterialSkin.MouseState.HOVER;
            this.g2g.Name = "g2g";
            this.g2g.Ripple = true;
            this.g2g.Size = new System.Drawing.Size(44, 30);
            this.g2g.TabIndex = 1;
            this.g2g.TabStop = true;
            this.g2g.Text = "绿";
            this.g2g.UseVisualStyleBackColor = true;
            this.g2g.CheckedChanged += new System.EventHandler(this.SelectChanged);
            // 
            // g2r
            // 
            this.g2r.AutoSize = true;
            this.g2r.Depth = 0;
            this.g2r.Font = new System.Drawing.Font("Roboto", 10F);
            this.g2r.Location = new System.Drawing.Point(47, 17);
            this.g2r.Margin = new System.Windows.Forms.Padding(0);
            this.g2r.MouseLocation = new System.Drawing.Point(-1, -1);
            this.g2r.MouseState = MaterialSkin.MouseState.HOVER;
            this.g2r.Name = "g2r";
            this.g2r.Ripple = true;
            this.g2r.Size = new System.Drawing.Size(44, 30);
            this.g2r.TabIndex = 0;
            this.g2r.TabStop = true;
            this.g2r.Text = "红";
            this.g2r.UseVisualStyleBackColor = true;
            this.g2r.CheckedChanged += new System.EventHandler(this.SelectChanged);
            // 
            // g1b
            // 
            this.g1b.AutoSize = true;
            this.g1b.Depth = 0;
            this.g1b.Font = new System.Drawing.Font("Roboto", 10F);
            this.g1b.Location = new System.Drawing.Point(135, 17);
            this.g1b.Margin = new System.Windows.Forms.Padding(0);
            this.g1b.MouseLocation = new System.Drawing.Point(-1, -1);
            this.g1b.MouseState = MaterialSkin.MouseState.HOVER;
            this.g1b.Name = "g1b";
            this.g1b.Ripple = true;
            this.g1b.Size = new System.Drawing.Size(44, 30);
            this.g1b.TabIndex = 2;
            this.g1b.TabStop = true;
            this.g1b.Text = "蓝";
            this.g1b.UseVisualStyleBackColor = true;
            this.g1b.CheckedChanged += new System.EventHandler(this.SelectChanged);
            // 
            // g1g
            // 
            this.g1g.AutoSize = true;
            this.g1g.Depth = 0;
            this.g1g.Font = new System.Drawing.Font("Roboto", 10F);
            this.g1g.Location = new System.Drawing.Point(91, 17);
            this.g1g.Margin = new System.Windows.Forms.Padding(0);
            this.g1g.MouseLocation = new System.Drawing.Point(-1, -1);
            this.g1g.MouseState = MaterialSkin.MouseState.HOVER;
            this.g1g.Name = "g1g";
            this.g1g.Ripple = true;
            this.g1g.Size = new System.Drawing.Size(44, 30);
            this.g1g.TabIndex = 1;
            this.g1g.TabStop = true;
            this.g1g.Text = "绿";
            this.g1g.UseVisualStyleBackColor = true;
            this.g1g.CheckedChanged += new System.EventHandler(this.SelectChanged);
            // 
            // g1r
            // 
            this.g1r.AutoSize = true;
            this.g1r.Depth = 0;
            this.g1r.Font = new System.Drawing.Font("Roboto", 10F);
            this.g1r.Location = new System.Drawing.Point(47, 17);
            this.g1r.Margin = new System.Windows.Forms.Padding(0);
            this.g1r.MouseLocation = new System.Drawing.Point(-1, -1);
            this.g1r.MouseState = MaterialSkin.MouseState.HOVER;
            this.g1r.Name = "g1r";
            this.g1r.Ripple = true;
            this.g1r.Size = new System.Drawing.Size(44, 30);
            this.g1r.TabIndex = 0;
            this.g1r.TabStop = true;
            this.g1r.Text = "红";
            this.g1r.UseVisualStyleBackColor = true;
            this.g1r.CheckedChanged += new System.EventHandler(this.SelectChanged);
            // 
            // g1n
            // 
            this.g1n.AutoSize = true;
            this.g1n.Checked = true;
            this.g1n.Depth = 0;
            this.g1n.Font = new System.Drawing.Font("Roboto", 10F);
            this.g1n.Location = new System.Drawing.Point(3, 17);
            this.g1n.Margin = new System.Windows.Forms.Padding(0);
            this.g1n.MouseLocation = new System.Drawing.Point(-1, -1);
            this.g1n.MouseState = MaterialSkin.MouseState.HOVER;
            this.g1n.Name = "g1n";
            this.g1n.Ripple = true;
            this.g1n.Size = new System.Drawing.Size(44, 30);
            this.g1n.TabIndex = 3;
            this.g1n.TabStop = true;
            this.g1n.Text = "无";
            this.g1n.UseVisualStyleBackColor = true;
            // 
            // g2n
            // 
            this.g2n.AutoSize = true;
            this.g2n.Checked = true;
            this.g2n.Depth = 0;
            this.g2n.Font = new System.Drawing.Font("Roboto", 10F);
            this.g2n.Location = new System.Drawing.Point(3, 17);
            this.g2n.Margin = new System.Windows.Forms.Padding(0);
            this.g2n.MouseLocation = new System.Drawing.Point(-1, -1);
            this.g2n.MouseState = MaterialSkin.MouseState.HOVER;
            this.g2n.Name = "g2n";
            this.g2n.Ripple = true;
            this.g2n.Size = new System.Drawing.Size(44, 30);
            this.g2n.TabIndex = 3;
            this.g2n.TabStop = true;
            this.g2n.Text = "无";
            this.g2n.UseVisualStyleBackColor = true;
            // 
            // TH12Special
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TH12Special";
            this.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton g1g;
        private MaterialSkin.Controls.MaterialRadioButton g1r;
        private MaterialSkin.Controls.MaterialRadioButton g1b;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRadioButton g2b;
        private MaterialSkin.Controls.MaterialRadioButton g2g;
        private MaterialSkin.Controls.MaterialRadioButton g2r;
        private MaterialSkin.Controls.MaterialRadioButton g1n;
        private MaterialSkin.Controls.MaterialRadioButton g2n;
    }
}
