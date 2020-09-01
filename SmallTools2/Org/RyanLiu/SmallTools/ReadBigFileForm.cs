using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;

using System.IO;

namespace Org.RyanLiu.SmallTools
{
	/// <summary>
	/// Summary description for ReadBigFileForm.
	/// </summary>
	public class ReadBigFileForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.TextBox tbxFileContent;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnReadMore;
		private System.Windows.Forms.Button btnCloseFile;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.TextBox tbxFileName;

		private FileStream fs ;
		private System.Windows.Forms.Label lblStart;
		private System.Windows.Forms.Label lblEncoding;
		private System.Windows.Forms.TextBox tbxStartPos;
		private System.Windows.Forms.Label lblLength;
		private System.Windows.Forms.TextBox tbxLength;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox tbxSearchStr;

		private byte[] buffer;
		private System.Windows.Forms.ComboBox cbxEncoding;
        private Button btnCut;
        private Button btnPasteFileName;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ReadBigFileForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnCut = new System.Windows.Forms.Button();
            this.cbxEncoding = new System.Windows.Forms.ComboBox();
            this.tbxSearchStr = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.tbxStartPos = new System.Windows.Forms.TextBox();
            this.tbxFileName = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnCloseFile = new System.Windows.Forms.Button();
            this.btnReadMore = new System.Windows.Forms.Button();
            this.tbxFileContent = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPasteFileName = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnPasteFileName);
            this.pnlTop.Controls.Add(this.btnCut);
            this.pnlTop.Controls.Add(this.cbxEncoding);
            this.pnlTop.Controls.Add(this.tbxSearchStr);
            this.pnlTop.Controls.Add(this.btnFind);
            this.pnlTop.Controls.Add(this.btnClear);
            this.pnlTop.Controls.Add(this.lblLength);
            this.pnlTop.Controls.Add(this.tbxLength);
            this.pnlTop.Controls.Add(this.lblEncoding);
            this.pnlTop.Controls.Add(this.lblStart);
            this.pnlTop.Controls.Add(this.tbxStartPos);
            this.pnlTop.Controls.Add(this.tbxFileName);
            this.pnlTop.Controls.Add(this.btnSelectFile);
            this.pnlTop.Controls.Add(this.btnOpenFile);
            this.pnlTop.Controls.Add(this.btnCloseFile);
            this.pnlTop.Controls.Add(this.btnReadMore);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(736, 89);
            this.pnlTop.TabIndex = 0;
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(514, 37);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(40, 21);
            this.btnCut.TabIndex = 16;
            this.btnCut.Text = "Cut";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // cbxEncoding
            // 
            this.cbxEncoding.Items.AddRange(new object[] {
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
            this.cbxEncoding.Location = new System.Drawing.Point(213, 37);
            this.cbxEncoding.Name = "cbxEncoding";
            this.cbxEncoding.Size = new System.Drawing.Size(101, 21);
            this.cbxEncoding.TabIndex = 15;
            this.cbxEncoding.Text = "gb2312";
            this.cbxEncoding.SelectedIndexChanged += new System.EventHandler(this.cbxEncoding_SelectedIndexChanged);
            // 
            // tbxSearchStr
            // 
            this.tbxSearchStr.Location = new System.Drawing.Point(13, 59);
            this.tbxSearchStr.Name = "tbxSearchStr";
            this.tbxSearchStr.Size = new System.Drawing.Size(227, 20);
            this.tbxSearchStr.TabIndex = 13;
            this.tbxSearchStr.Text = "DROP TABLE IF EXISTS `project`";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(253, 59);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(54, 23);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(560, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 21);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblLength
            // 
            this.lblLength.Location = new System.Drawing.Point(327, 67);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 15);
            this.lblLength.TabIndex = 10;
            this.lblLength.Text = "Length";
            // 
            // tbxLength
            // 
            this.tbxLength.Location = new System.Drawing.Point(373, 67);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(67, 20);
            this.tbxLength.TabIndex = 9;
            this.tbxLength.Text = "81920";
            // 
            // lblEncoding
            // 
            this.lblEncoding.Location = new System.Drawing.Point(160, 37);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(47, 15);
            this.lblEncoding.TabIndex = 8;
            this.lblEncoding.Text = "Encoding";
            // 
            // lblStart
            // 
            this.lblStart.Location = new System.Drawing.Point(7, 37);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(60, 15);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Start Pos";
            // 
            // tbxStartPos
            // 
            this.tbxStartPos.Location = new System.Drawing.Point(67, 37);
            this.tbxStartPos.Name = "tbxStartPos";
            this.tbxStartPos.Size = new System.Drawing.Size(73, 20);
            this.tbxStartPos.TabIndex = 5;
            this.tbxStartPos.Text = "0";
            // 
            // tbxFileName
            // 
            this.tbxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFileName.Location = new System.Drawing.Point(7, 7);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(529, 20);
            this.tbxFileName.TabIndex = 4;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFile.Location = new System.Drawing.Point(543, 7);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(27, 22);
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Location = new System.Drawing.Point(508, 64);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(62, 22);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnCloseFile
            // 
            this.btnCloseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseFile.Location = new System.Drawing.Point(663, 7);
            this.btnCloseFile.Name = "btnCloseFile";
            this.btnCloseFile.Size = new System.Drawing.Size(62, 22);
            this.btnCloseFile.TabIndex = 1;
            this.btnCloseFile.Text = "Close File";
            this.btnCloseFile.Click += new System.EventHandler(this.btnCloseFile_Click);
            // 
            // btnReadMore
            // 
            this.btnReadMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadMore.Location = new System.Drawing.Point(570, 67);
            this.btnReadMore.Name = "btnReadMore";
            this.btnReadMore.Size = new System.Drawing.Size(60, 22);
            this.btnReadMore.TabIndex = 0;
            this.btnReadMore.Text = "Read More";
            this.btnReadMore.Click += new System.EventHandler(this.btnReadMore_Click);
            // 
            // tbxFileContent
            // 
            this.tbxFileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFileContent.Location = new System.Drawing.Point(0, 89);
            this.tbxFileContent.Multiline = true;
            this.tbxFileContent.Name = "tbxFileContent";
            this.tbxFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxFileContent.Size = new System.Drawing.Size(736, 292);
            this.tbxFileContent.TabIndex = 1;
            // 
            // btnPasteFileName
            // 
            this.btnPasteFileName.Location = new System.Drawing.Point(576, 8);
            this.btnPasteFileName.Name = "btnPasteFileName";
            this.btnPasteFileName.Size = new System.Drawing.Size(54, 21);
            this.btnPasteFileName.TabIndex = 17;
            this.btnPasteFileName.Text = "Paste";
            this.btnPasteFileName.UseVisualStyleBackColor = true;
            this.btnPasteFileName.Click += new System.EventHandler(this.btnPasteFileName_Click);
            // 
            // ReadBigFileForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(736, 381);
            this.Controls.Add(this.tbxFileContent);
            this.Controls.Add(this.pnlTop);
            this.Name = "ReadBigFileForm";
            this.Text = "ReadBigFileForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void btnReadMore_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.fs == null) this.btnOpenFile_Click(null, null);
				this.fs.Position = long.Parse(this.tbxStartPos.Text.Trim()) ;

				int length = int.Parse(this.tbxLength.Text.Trim());
				buffer = new byte[length];
				int readed = this.fs.Read(buffer,0,length);
			
				Encoding encoding = System.Text.Encoding.GetEncoding(this.cbxEncoding.Text.Trim());
			

				this.tbxFileContent.Text += encoding.GetString(buffer, 0, readed);

				this.tbxStartPos.Text = this.fs.Position.ToString();

				if(this.fs.Length == this.fs.Position )
				{
					MessageBox.Show("End of the file reached.");
				}
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.ToString());
			}	
		}

			private void btnSelectFile_Click(object sender, System.EventArgs e)
		{
			if(this.openFileDialog1.ShowDialog() ==  DialogResult.OK )
			{
				this.tbxFileName.Text = this.openFileDialog1.FileName;
			}
		}

		private void btnOpenFile_Click(object sender, System.EventArgs e)
		{
			btnCloseFile_Click(null, null);

			this.fs = File.Open(this.tbxFileName.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);


		}

		private void btnCloseFile_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.fs !=null)
				{
					fs.Close();
					this.fs = null;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.ToString());
			}	
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			btnCloseFile_Click(null, null);
			base.OnClosing (e);
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			this.tbxFileContent.Clear();
            this.tbxStartPos.Text = "0";
		}

		private void btnFind_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string searchStr = this.tbxSearchStr.Text.Trim();
				if( searchStr.Length ==0) return;

				if(this.fs == null ) this.btnOpenFile_Click(null, null);
				this.fs.Position = long.Parse(this.tbxStartPos.Text.Trim());

				int length = int.Parse(this.tbxLength.Text.Trim());
				buffer = new byte[length];

			
				while(true)
				{
					this.fs.Read(buffer,0,length);
					Encoding encoding = System.Text.Encoding.GetEncoding(this.cbxEncoding.Text.Trim());
					string thisRead =  encoding.GetString(buffer, 0, length);

					this.tbxStartPos.Text = this.fs.Position.ToString();
					Application.DoEvents();

					if(thisRead.IndexOf(searchStr) >0 )
					{
						this.tbxFileContent.Text = thisRead;

					
						break;

					}

					if(this.fs.Length == this.fs.Position )
					{
						MessageBox.Show("End of the file reached.");
						break;
					}
				
		
				} //end while
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.ToString());
			}	
			finally
			{
				this.Cursor = Cursors.Default;
			}
		
		}

		private void btnEncoding_Click(object sender, System.EventArgs e)
		{
			if(this.buffer == null || this.buffer.Length == 0) return;
			try
			{
				int length = int.Parse(this.tbxLength.Text.Trim());
				Encoding encoding = System.Text.Encoding.GetEncoding(this.cbxEncoding.Text.Trim());
				this.tbxFileContent.Text = encoding.GetString(buffer, 0, length);
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.ToString());
			}	
		}

		private void cbxEncoding_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			 this.btnEncoding_Click(null, null);
		}

        private void btnCut_Click(object sender, EventArgs e)
        {
            this.tbxFileContent.Select(0, this.tbxFileContent.Text.Length);
            this.tbxFileContent.Cut();
            
            this.tbxStartPos.Text = "0";
        }

        private void btnPasteFileName_Click(object sender, EventArgs e)
        {
            this.tbxFileName.Select(0, this.tbxFileName.Text.Length);
            this.tbxFileName.Paste();
        }

	}
}
