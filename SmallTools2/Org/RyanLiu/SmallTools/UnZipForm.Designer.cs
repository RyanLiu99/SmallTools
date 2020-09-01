namespace Org.RyanLiu.SmallTools
{
	partial class UnZipForm
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
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.btnSelectDestFolder = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.tbxUnZipFolder = new System.Windows.Forms.TextBox();
            this.tbxZipFile = new System.Windows.Forms.TextBox();
            this.btnUnZip = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // tbxOutput
            // 
            this.tbxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOutput.Location = new System.Drawing.Point(12, 96);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(453, 226);
            this.tbxOutput.TabIndex = 0;
            // 
            // btnSelectDestFolder
            // 
            this.btnSelectDestFolder.Location = new System.Drawing.Point(4, 39);
            this.btnSelectDestFolder.Name = "btnSelectDestFolder";
            this.btnSelectDestFolder.Size = new System.Drawing.Size(122, 24);
            this.btnSelectDestFolder.TabIndex = 13;
            this.btnSelectDestFolder.Text = "Select Folder...";
            this.btnSelectDestFolder.Click += new System.EventHandler(this.btnSelectDestFolder_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(4, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(105, 24);
            this.btnSelectFile.TabIndex = 12;
            this.btnSelectFile.Text = "Select File...";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // tbxUnZipFolder
            // 
            this.tbxUnZipFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUnZipFolder.Location = new System.Drawing.Point(151, 39);
            this.tbxUnZipFolder.Name = "tbxUnZipFolder";
            this.tbxUnZipFolder.Size = new System.Drawing.Size(323, 21);
            this.tbxUnZipFolder.TabIndex = 11;
            // 
            // tbxZipFile
            // 
            this.tbxZipFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxZipFile.Location = new System.Drawing.Point(138, 12);
            this.tbxZipFile.Name = "tbxZipFile";
            this.tbxZipFile.Size = new System.Drawing.Size(336, 21);
            this.tbxZipFile.TabIndex = 10;
            // 
            // btnUnZip
            // 
            this.btnUnZip.Location = new System.Drawing.Point(127, 66);
            this.btnUnZip.Name = "btnUnZip";
            this.btnUnZip.Size = new System.Drawing.Size(112, 24);
            this.btnUnZip.TabIndex = 9;
            this.btnUnZip.Text = "Unzip file ...";
            this.btnUnZip.Click += new System.EventHandler(this.btnUnZip_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Select a zip file ...";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select a (empty) folder for unzip ...";
            // 
            // UnZipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 334);
            this.Controls.Add(this.btnSelectDestFolder);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.tbxUnZipFolder);
            this.Controls.Add(this.tbxZipFile);
            this.Controls.Add(this.btnUnZip);
            this.Controls.Add(this.tbxOutput);
            this.Name = "UnZipForm";
            this.Text = "UnZipForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Button btnSelectDestFolder;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox tbxUnZipFolder;
        private System.Windows.Forms.TextBox tbxZipFile;
        private System.Windows.Forms.Button btnUnZip;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}