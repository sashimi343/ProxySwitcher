namespace ProxySwitcher
{
    partial class ProxySwitcherForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.toggleProxyButton = new System.Windows.Forms.Button();
            this.proxyPortLabel = new System.Windows.Forms.Label();
            this.proxyPortForm = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.proxyPortForm)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleProxyButton
            // 
            this.toggleProxyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleProxyButton.Location = new System.Drawing.Point(12, 41);
            this.toggleProxyButton.Name = "toggleProxyButton";
            this.toggleProxyButton.Size = new System.Drawing.Size(226, 100);
            this.toggleProxyButton.TabIndex = 0;
            this.toggleProxyButton.Text = "Proxy is Off";
            this.toggleProxyButton.UseVisualStyleBackColor = true;
            this.toggleProxyButton.Click += new System.EventHandler(this.toggleProxyButton_Click);
            // 
            // proxyPortLabel
            // 
            this.proxyPortLabel.AutoSize = true;
            this.proxyPortLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.proxyPortLabel.Location = new System.Drawing.Point(9, 14);
            this.proxyPortLabel.Name = "proxyPortLabel";
            this.proxyPortLabel.Size = new System.Drawing.Size(90, 16);
            this.proxyPortLabel.TabIndex = 4;
            this.proxyPortLabel.Text = "Proxy Port: ";
            // 
            // proxyPortForm
            // 
            this.proxyPortForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyPortForm.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.proxyPortForm.Location = new System.Drawing.Point(105, 12);
            this.proxyPortForm.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.proxyPortForm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.proxyPortForm.Name = "proxyPortForm";
            this.proxyPortForm.Size = new System.Drawing.Size(133, 23);
            this.proxyPortForm.TabIndex = 5;
            this.proxyPortForm.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // ProxySwitcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 153);
            this.Controls.Add(this.proxyPortForm);
            this.Controls.Add(this.proxyPortLabel);
            this.Controls.Add(this.toggleProxyButton);
            this.Name = "ProxySwitcherForm";
            this.Text = "Proxy Switcher";
            ((System.ComponentModel.ISupportInitialize)(this.proxyPortForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toggleProxyButton;
        private System.Windows.Forms.Label proxyPortLabel;
        private System.Windows.Forms.NumericUpDown proxyPortForm;
    }
}

