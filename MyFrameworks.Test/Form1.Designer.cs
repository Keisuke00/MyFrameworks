namespace MyFrameworks.Test
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.planeComboBox1 = new MyFrameworks.Controls.ComboBoxes.PlaneComboBoxes.PlaneComboBox();
            this.SuspendLayout();
            // 
            // planeComboBox1
            // 
            this.planeComboBox1.FormattingEnabled = true;
            this.planeComboBox1.Location = new System.Drawing.Point(12, 12);
            this.planeComboBox1.Name = "planeComboBox1";
            this.planeComboBox1.Size = new System.Drawing.Size(121, 20);
            this.planeComboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.planeComboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ComboBoxes.PlaneComboBoxes.PlaneComboBox planeComboBox1;

    }
}

