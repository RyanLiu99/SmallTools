using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using SmallTools2.Org.RyanLiu.SmallTools;

namespace Org.RyanLiu.SmallTools
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btbGetEmail;
		private System.Windows.Forms.Button btnBreakLines;
		private System.Windows.Forms.Button btnReadBigFile;
        private System.Windows.Forms.Button btnTestDb;
        private Button btnUnZipFile;
        private Button bthCoding;
        private Button btnOpenUrl;
        private Button btnXml;
        private Button btnChangeFilesEncoding;
        private SaveFileDialog saveFileDialog1;
        private Button btnCPropertyGenerator;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public MainForm()
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
            this.btbGetEmail = new System.Windows.Forms.Button();
            this.btnBreakLines = new System.Windows.Forms.Button();
            this.btnReadBigFile = new System.Windows.Forms.Button();
            this.btnTestDb = new System.Windows.Forms.Button();
            this.btnUnZipFile = new System.Windows.Forms.Button();
            this.bthCoding = new System.Windows.Forms.Button();
            this.btnOpenUrl = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnChangeFilesEncoding = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnCPropertyGenerator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btbGetEmail
            // 
            this.btbGetEmail.Location = new System.Drawing.Point(16, 16);
            this.btbGetEmail.Name = "btbGetEmail";
            this.btbGetEmail.Size = new System.Drawing.Size(111, 24);
            this.btbGetEmail.TabIndex = 0;
            this.btbGetEmail.Text = "Get Email";
            this.btbGetEmail.Click += new System.EventHandler(this.btbGetEmail_Click);
            // 
            // btnBreakLines
            // 
            this.btnBreakLines.Location = new System.Drawing.Point(16, 56);
            this.btnBreakLines.Name = "btnBreakLines";
            this.btnBreakLines.Size = new System.Drawing.Size(114, 24);
            this.btnBreakLines.TabIndex = 1;
            this.btnBreakLines.Text = "Break Lines Add sth";
            this.btnBreakLines.Click += new System.EventHandler(this.btnBreakLines_Click);
            // 
            // btnReadBigFile
            // 
            this.btnReadBigFile.Location = new System.Drawing.Point(162, 56);
            this.btnReadBigFile.Name = "btnReadBigFile";
            this.btnReadBigFile.Size = new System.Drawing.Size(86, 22);
            this.btnReadBigFile.TabIndex = 2;
            this.btnReadBigFile.Text = "Read big file";
            this.btnReadBigFile.Click += new System.EventHandler(this.btnReadBigFile_Click);
            // 
            // btnTestDb
            // 
            this.btnTestDb.Location = new System.Drawing.Point(162, 18);
            this.btnTestDb.Name = "btnTestDb";
            this.btnTestDb.Size = new System.Drawing.Size(94, 22);
            this.btnTestDb.TabIndex = 3;
            this.btnTestDb.Text = "Test MySql";
            this.btnTestDb.Click += new System.EventHandler(this.btnTestDb_Click);
            // 
            // btnUnZipFile
            // 
            this.btnUnZipFile.Location = new System.Drawing.Point(16, 101);
            this.btnUnZipFile.Name = "btnUnZipFile";
            this.btnUnZipFile.Size = new System.Drawing.Size(111, 22);
            this.btnUnZipFile.TabIndex = 4;
            this.btnUnZipFile.Text = "Unzip File ...";
            this.btnUnZipFile.Click += new System.EventHandler(this.btnUnZipFile_Click);
            // 
            // bthCoding
            // 
            this.bthCoding.Location = new System.Drawing.Point(153, 101);
            this.bthCoding.Name = "bthCoding";
            this.bthCoding.Size = new System.Drawing.Size(153, 22);
            this.bthCoding.TabIndex = 5;
            this.bthCoding.Text = "Encoding/Decoding Str Util";
            this.bthCoding.Click += new System.EventHandler(this.bthCoding_Click);
            // 
            // btnOpenUrl
            // 
            this.btnOpenUrl.Location = new System.Drawing.Point(314, 18);
            this.btnOpenUrl.Name = "btnOpenUrl";
            this.btnOpenUrl.Size = new System.Drawing.Size(86, 22);
            this.btnOpenUrl.TabIndex = 6;
            this.btnOpenUrl.Text = "Open URL";
            this.btnOpenUrl.Click += new System.EventHandler(this.btnOpenUrl_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(16, 141);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(114, 20);
            this.btnXml.TabIndex = 7;
            this.btnXml.Text = "Query Books";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnChangeFilesEncoding
            // 
            this.btnChangeFilesEncoding.Location = new System.Drawing.Point(153, 139);
            this.btnChangeFilesEncoding.Name = "btnChangeFilesEncoding";
            this.btnChangeFilesEncoding.Size = new System.Drawing.Size(135, 22);
            this.btnChangeFilesEncoding.TabIndex = 8;
            this.btnChangeFilesEncoding.Text = "Change Files Encoding";
            this.btnChangeFilesEncoding.Click += new System.EventHandler(this.btnChangeFilesEncoding_Click);
            // 
            // btnCPropertyGenerator
            // 
            this.btnCPropertyGenerator.Location = new System.Drawing.Point(297, 58);
            this.btnCPropertyGenerator.Name = "btnCPropertyGenerator";
            this.btnCPropertyGenerator.Size = new System.Drawing.Size(119, 22);
            this.btnCPropertyGenerator.TabIndex = 9;
            this.btnCPropertyGenerator.Text = "Property Generator";
            this.btnCPropertyGenerator.Click += new System.EventHandler(this.btnCPropertyGenerator_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(428, 189);
            this.Controls.Add(this.btnCPropertyGenerator);
            this.Controls.Add(this.btnChangeFilesEncoding);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnOpenUrl);
            this.Controls.Add(this.bthCoding);
            this.Controls.Add(this.btnUnZipFile);
            this.Controls.Add(this.btnTestDb);
            this.Controls.Add(this.btnReadBigFile);
            this.Controls.Add(this.btnBreakLines);
            this.Controls.Add(this.btbGetEmail);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Org.RyanLiu.SmallTools.MainForm());
		}

		private void btnBreakLines_Click(object sender, System.EventArgs e)
		{
			new BreakLinesForm().Show(); 
		}

		private void btbGetEmail_Click(object sender, System.EventArgs e)
		{
			new GetEmailForm().Show();
		}

		private void btnReadBigFile_Click(object sender, System.EventArgs e)
		{
			new ReadBigFileForm().Show();
		}

		private void btnTestDb_Click(object sender, System.EventArgs e)
		{
			new TestConnectionForm().Show();
		}

        private void btnUnZipFile_Click(object sender, EventArgs e)
        {
            UnZipForm f = new UnZipForm();
            f.Show(this);
        }

        private void bthCoding_Click(object sender, EventArgs e)
        {
            EncodingStringUtilForm f = new EncodingStringUtilForm();
            f.Show(this);

        }

        private void btnOpenUrl_Click(object sender, EventArgs e)
        {
            var f = new OpenUrlForm();
            f.Show(this);

        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            //QueryXmlForm.QueryBooks();
        }

        private void btnChangeFilesEncoding_Click(object sender, EventArgs e)
        {
            new ChangeFileEncodingForm().Show();
        }

        private void btnCPropertyGenerator_Click(object sender, EventArgs e)
        {
            new PropertyGeneratorForm().Show() ;
        }
    }
}
