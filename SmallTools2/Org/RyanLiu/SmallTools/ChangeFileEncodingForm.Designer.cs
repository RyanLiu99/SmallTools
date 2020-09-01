namespace SmallTools2.Org.RyanLiu.SmallTools
{
    partial class ChangeFileEncodingForm
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
            this.tbxFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.brnBrwoserFolder = new System.Windows.Forms.Button();
            this.tbxMsg = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.cbxEncodingFrom = new System.Windows.Forms.ComboBox();
            this.cbxEncocingTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.tbxFilePattern = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxFolder
            // 
            this.tbxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFolder.Location = new System.Drawing.Point(74, 12);
            this.tbxFolder.Name = "tbxFolder";
            this.tbxFolder.Size = new System.Drawing.Size(426, 20);
            this.tbxFolder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "lblFolder";
            // 
            // brnBrwoserFolder
            // 
            this.brnBrwoserFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnBrwoserFolder.Location = new System.Drawing.Point(520, 12);
            this.brnBrwoserFolder.Name = "brnBrwoserFolder";
            this.brnBrwoserFolder.Size = new System.Drawing.Size(75, 23);
            this.brnBrwoserFolder.TabIndex = 2;
            this.brnBrwoserFolder.Text = "Browser ...";
            this.brnBrwoserFolder.UseVisualStyleBackColor = true;
            this.brnBrwoserFolder.Click += new System.EventHandler(this.brnBrwoserFolder_Click);
            // 
            // tbxMsg
            // 
            this.tbxMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMsg.Location = new System.Drawing.Point(13, 70);
            this.tbxMsg.Multiline = true;
            this.tbxMsg.Name = "tbxMsg";
            this.tbxMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxMsg.Size = new System.Drawing.Size(619, 219);
            this.tbxMsg.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(202, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopy.Location = new System.Drawing.Point(12, 295);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(520, 41);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cbxEncodingFrom
            // 
            this.cbxEncodingFrom.Items.AddRange(new object[] {
            "gb2312",
            "utf-8",
            "utf-7",
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
            this.cbxEncodingFrom.Location = new System.Drawing.Point(74, 43);
            this.cbxEncodingFrom.Name = "cbxEncodingFrom";
            this.cbxEncodingFrom.Size = new System.Drawing.Size(101, 21);
            this.cbxEncodingFrom.TabIndex = 16;
            this.cbxEncodingFrom.Text = "gb2312";
            // 
            // cbxEncocingTo
            // 
            this.cbxEncocingTo.Items.AddRange(new object[] {
            "gb2312",
            "utf-8",
            "utf-7",
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
            this.cbxEncocingTo.Location = new System.Drawing.Point(235, 43);
            this.cbxEncocingTo.Name = "cbxEncocingTo";
            this.cbxEncocingTo.Size = new System.Drawing.Size(101, 21);
            this.cbxEncocingTo.TabIndex = 17;
            this.cbxEncocingTo.Text = "utf-8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(199, 46);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 19;
            this.lblTo.Text = "To";
            // 
            // tbxFilePattern
            // 
            this.tbxFilePattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFilePattern.Location = new System.Drawing.Point(427, 46);
            this.tbxFilePattern.Name = "tbxFilePattern";
            this.tbxFilePattern.Size = new System.Drawing.Size(73, 20);
            this.tbxFilePattern.TabIndex = 20;
            this.tbxFilePattern.Text = "*.cs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "File Pattern";
            // 
            // ChangeFileEncodingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxFilePattern);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxEncocingTo);
            this.Controls.Add(this.cbxEncodingFrom);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxMsg);
            this.Controls.Add(this.brnBrwoserFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFolder);
            this.Name = "ChangeFileEncodingForm";
            this.Text = "ChangeFileEncodingForm";
            this.Load += new System.EventHandler(this.ChangeFileEncodingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button brnBrwoserFolder;
        private System.Windows.Forms.TextBox tbxMsg;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ComboBox cbxEncodingFrom;
        private System.Windows.Forms.ComboBox cbxEncocingTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox tbxFilePattern;
        private System.Windows.Forms.Label label3;
    }
}