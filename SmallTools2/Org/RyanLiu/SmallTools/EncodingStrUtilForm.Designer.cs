namespace Org.RyanLiu.SmallTools
{
	partial class EncodingStringUtilForm
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
            this.btnHtmlDecode = new System.Windows.Forms.Button();
            this.tbxSrc = new System.Windows.Forms.TextBox();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHtmlEncode = new System.Windows.Forms.Button();
            this.btnUrlEncode = new System.Windows.Forms.Button();
            this.btnUrlDecode = new System.Windows.Forms.Button();
            this.btnBase64Decode = new System.Windows.Forms.Button();
            this.btnBase64Encode = new System.Windows.Forms.Button();
            this.btnFindDuplicateChar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHtmlDecode
            // 
            this.btnHtmlDecode.Location = new System.Drawing.Point(17, 70);
            this.btnHtmlDecode.Name = "btnHtmlDecode";
            this.btnHtmlDecode.Size = new System.Drawing.Size(103, 25);
            this.btnHtmlDecode.TabIndex = 0;
            this.btnHtmlDecode.Text = "HTML decode";
            this.btnHtmlDecode.UseVisualStyleBackColor = true;
            this.btnHtmlDecode.Click += new System.EventHandler(this.btnHtmlDecode_Click);
            // 
            // tbxSrc
            // 
            this.tbxSrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSrc.Location = new System.Drawing.Point(12, 20);
            this.tbxSrc.Multiline = true;
            this.tbxSrc.Name = "tbxSrc";
            this.tbxSrc.Size = new System.Drawing.Size(761, 43);
            this.tbxSrc.TabIndex = 2;
            // 
            // tbxResult
            // 
            this.tbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResult.Location = new System.Drawing.Point(17, 109);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(761, 277);
            this.tbxResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source";
            // 
            // btnHtmlEncode
            // 
            this.btnHtmlEncode.Location = new System.Drawing.Point(126, 69);
            this.btnHtmlEncode.Name = "btnHtmlEncode";
            this.btnHtmlEncode.Size = new System.Drawing.Size(103, 25);
            this.btnHtmlEncode.TabIndex = 5;
            this.btnHtmlEncode.Text = "HTML encode";
            this.btnHtmlEncode.UseVisualStyleBackColor = true;
            this.btnHtmlEncode.Click += new System.EventHandler(this.btnHtmlEncode_Click);
            // 
            // btnUrlEncode
            // 
            this.btnUrlEncode.Location = new System.Drawing.Point(342, 68);
            this.btnUrlEncode.Name = "btnUrlEncode";
            this.btnUrlEncode.Size = new System.Drawing.Size(103, 25);
            this.btnUrlEncode.TabIndex = 7;
            this.btnUrlEncode.Text = "URL encode";
            this.btnUrlEncode.UseVisualStyleBackColor = true;
            this.btnUrlEncode.Click += new System.EventHandler(this.btnUrlEncode_Click);
            // 
            // btnUrlDecode
            // 
            this.btnUrlDecode.Location = new System.Drawing.Point(235, 69);
            this.btnUrlDecode.Name = "btnUrlDecode";
            this.btnUrlDecode.Size = new System.Drawing.Size(103, 25);
            this.btnUrlDecode.TabIndex = 6;
            this.btnUrlDecode.Text = "URL decode";
            this.btnUrlDecode.UseVisualStyleBackColor = true;
            this.btnUrlDecode.Click += new System.EventHandler(this.btnUrlDecode_Click);
            // 
            // btnBase64Decode
            // 
            this.btnBase64Decode.Location = new System.Drawing.Point(449, 70);
            this.btnBase64Decode.Name = "btnBase64Decode";
            this.btnBase64Decode.Size = new System.Drawing.Size(103, 25);
            this.btnBase64Decode.TabIndex = 9;
            this.btnBase64Decode.Text = "Base64 decode";
            this.btnBase64Decode.UseVisualStyleBackColor = true;
            this.btnBase64Decode.Click += new System.EventHandler(this.btnBase64Decode_Click);
            // 
            // btnBase64Encode
            // 
            this.btnBase64Encode.Location = new System.Drawing.Point(558, 68);
            this.btnBase64Encode.Name = "btnBase64Encode";
            this.btnBase64Encode.Size = new System.Drawing.Size(103, 25);
            this.btnBase64Encode.TabIndex = 8;
            this.btnBase64Encode.Text = "Base64 Encode";
            this.btnBase64Encode.UseVisualStyleBackColor = true;
            this.btnBase64Encode.Click += new System.EventHandler(this.btnBase64Encode_Click);
            // 
            // btnFindDuplicateChar
            // 
            this.btnFindDuplicateChar.Location = new System.Drawing.Point(667, 68);
            this.btnFindDuplicateChar.Name = "btnFindDuplicateChar";
            this.btnFindDuplicateChar.Size = new System.Drawing.Size(92, 25);
            this.btnFindDuplicateChar.TabIndex = 10;
            this.btnFindDuplicateChar.Text = "Find dup char";
            this.btnFindDuplicateChar.UseVisualStyleBackColor = true;
            this.btnFindDuplicateChar.Click += new System.EventHandler(this.btnFindDuplicateChar_Click);
            // 
            // EncodingStringUtilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 400);
            this.Controls.Add(this.btnFindDuplicateChar);
            this.Controls.Add(this.btnBase64Decode);
            this.Controls.Add(this.btnBase64Encode);
            this.Controls.Add(this.btnUrlEncode);
            this.Controls.Add(this.btnUrlDecode);
            this.Controls.Add(this.btnHtmlEncode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.tbxSrc);
            this.Controls.Add(this.btnHtmlDecode);
            this.Name = "EncodingStringUtilForm";
            this.Text = "EncodingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Button btnHtmlDecode;
        private System.Windows.Forms.TextBox tbxSrc;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHtmlEncode;
        private System.Windows.Forms.Button btnUrlEncode;
        private System.Windows.Forms.Button btnUrlDecode;
        private System.Windows.Forms.Button btnBase64Decode;
        private System.Windows.Forms.Button btnBase64Encode;
        private System.Windows.Forms.Button btnFindDuplicateChar;
	}
}