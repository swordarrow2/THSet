namespace THSet.specialCheat {
    partial class TH10Special {
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
            this.editText1 = new THSet.EditText();
            this.SuspendLayout();
            // 
            // editText1
            // 
            this.editText1.Location = new System.Drawing.Point(4, 4);
            this.editText1.Name = "editText1";
            this.editText1.number = 0;
            this.editText1.Size = new System.Drawing.Size(170, 34);
            this.editText1.TabIndex = 0;
            this.editText1.TabStop = false;
            // 
            // TH10Special
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editText1);
            this.Name = "TH10Special";
            this.Size = new System.Drawing.Size(170, 41);
            this.ResumeLayout(false);

        }

        #endregion

        private EditText editText1;
    }
}
