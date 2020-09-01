namespace Org.RyanLiu.SmallTools
{
	partial class OpenUrlForm
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
            this.btnOpenUrl = new System.Windows.Forms.Button();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.cbxEncoding = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOpenUrl
            // 
            this.btnOpenUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenUrl.Location = new System.Drawing.Point(518, 5);
            this.btnOpenUrl.Name = "btnOpenUrl";
            this.btnOpenUrl.Size = new System.Drawing.Size(57, 22);
            this.btnOpenUrl.TabIndex = 0;
            this.btnOpenUrl.Text = "Get";
            this.btnOpenUrl.UseVisualStyleBackColor = true;
            this.btnOpenUrl.Click += new System.EventHandler(this.btnOpenUrl_Click);
            // 
            // tbxUrl
            // 
            this.tbxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUrl.Location = new System.Drawing.Point(7, 7);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(505, 20);
            this.tbxUrl.TabIndex = 1;
            this.tbxUrl.Text = "http://";
            // 
            // txtPage
            // 
            this.txtPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPage.Location = new System.Drawing.Point(8, 36);
            this.txtPage.Multiline = true;
            this.txtPage.Name = "txtPage";
            this.txtPage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPage.Size = new System.Drawing.Size(671, 345);
            this.txtPage.TabIndex = 2;
            // 
            // cbxEncoding
            // 
            this.cbxEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEncoding.Items.AddRange(new object[] {
            "utf-8",
            "utf-7",
            "gb2312",
            "ascii",
            "utf-16",
            "latin1",
            "windows-1252",
            "GB18030",
            "UTF-16BE",
            "big5",
            "ujis",
            "sjis",
            "tis620",
            "euckr",
            "gbk",
            "ucs2"});
            this.cbxEncoding.Location = new System.Drawing.Point(578, 6);
            this.cbxEncoding.Name = "cbxEncoding";
            this.cbxEncoding.Size = new System.Drawing.Size(101, 21);
            this.cbxEncoding.TabIndex = 16;
            this.cbxEncoding.Text = "utf-8";
            this.cbxEncoding.SelectedIndexChanged += new System.EventHandler(this.cbxEncoding_SelectedIndexChanged);
            // 
            // OpenUrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 391);
            this.Controls.Add(this.cbxEncoding);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.btnOpenUrl);
            this.Name = "OpenUrlForm";
            this.Text = "OpenUrlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Button btnOpenUrl;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.ComboBox cbxEncoding;
	}
}