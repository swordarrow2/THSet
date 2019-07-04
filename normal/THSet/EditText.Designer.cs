namespace THSet {
    partial class EditText {
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
            this.button = new MaterialSkin.Controls.MaterialFlatButton();
            this.MDText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.AutoSize = true;
            this.button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button.Depth = 0;
            this.button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button.Icon = null;
            this.button.Location = new System.Drawing.Point(113, -1);
            this.button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button.MouseState = MaterialSkin.MouseState.HOVER;
            this.button.Name = "button";
            this.button.Primary = true;
            this.button.Size = new System.Drawing.Size(51, 36);
            this.button.TabIndex = 1;
            this.button.Text = "修改";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // MDText
            // 
            this.MDText.Depth = 0;
            this.MDText.Hint = "";
            this.MDText.Location = new System.Drawing.Point(3, 3);
            this.MDText.MaxLength = 32767;
            this.MDText.MouseState = MaterialSkin.MouseState.HOVER;
            this.MDText.Name = "MDText";
            this.MDText.PasswordChar = '\0';
            this.MDText.SelectedText = "";
            this.MDText.SelectionLength = 0;
            this.MDText.SelectionStart = 0;
            this.MDText.Size = new System.Drawing.Size(113, 23);
            this.MDText.TabIndex = 0;
            this.MDText.TabStop = false;
            this.MDText.UseSystemPasswordChar = false;
            // 
            // EditText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button);
            this.Controls.Add(this.MDText);
            this.Name = "EditText";
            this.Size = new System.Drawing.Size(168, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField MDText;
        private MaterialSkin.Controls.MaterialFlatButton button;
    }
}
