using System;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Org.RyanLiu.SmallTools
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class formGetEmail : System.Windows.Forms.Form
	{
		private  String lineSplitter = "\r\n";
		
		private System.Windows.Forms.TextBox tbxText;
		private System.Windows.Forms.TextBox tbxEmail;
		private System.Windows.Forms.Button btnGetEmail;
		private System.Windows.Forms.Button btnSortEmail;
		private System.Windows.Forms.Button btnWrapText;
		private System.Windows.Forms.Button btnAddColon;
		private System.Windows.Forms.Button btnSemiColon;
		private System.Windows.Forms.Button btnClearText;
		private System.Windows.Forms.Button bteClearEmail;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public formGetEmail()
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
				if (components != null) 
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
			this.tbxText = new System.Windows.Forms.TextBox();
			this.tbxEmail = new System.Windows.Forms.TextBox();
			this.btnGetEmail = new System.Windows.Forms.Button();
			this.btnSortEmail = new System.Windows.Forms.Button();
			this.btnWrapText = new System.Windows.Forms.Button();
			this.btnAddColon = new System.Windows.Forms.Button();
			this.btnSemiColon = new System.Windows.Forms.Button();
			this.btnClearText = new System.Windows.Forms.Button();
			this.bteClearEmail = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbxText
			// 
			this.tbxText.Location = new System.Drawing.Point(20, 37);
			this.tbxText.Multiline = true;
			this.tbxText.Name = "tbxText";
			this.tbxText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbxText.Size = new System.Drawing.Size(233, 364);
			this.tbxText.TabIndex = 0;
			this.tbxText.Text = "get email address from data from outlook express Ryan Liu <ryanliu_99@yahoo.com>";
			this.tbxText.TextChanged += new System.EventHandler(this.tbxText_TextChanged);
			// 
			// tbxEmail
			// 
			this.tbxEmail.Location = new System.Drawing.Point(320, 37);
			this.tbxEmail.Multiline = true;
			this.tbxEmail.Name = "tbxEmail";
			this.tbxEmail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbxEmail.Size = new System.Drawing.Size(240, 364);
			this.tbxEmail.TabIndex = 1;
			this.tbxEmail.Text = "";
			// 
			// btnGetEmail
			// 
			this.btnGetEmail.Location = new System.Drawing.Point(232, 8);
			this.btnGetEmail.Name = "btnGetEmail";
			this.btnGetEmail.Size = new System.Drawing.Size(100, 23);
			this.btnGetEmail.TabIndex = 2;
			this.btnGetEmail.Text = "formGetEmail";
			this.btnGetEmail.Click += new System.EventHandler(this.btnGetEmail_Click);
			// 
			// btnSortEmail
			// 
			this.btnSortEmail.Location = new System.Drawing.Point(312, 409);
			this.btnSortEmail.Name = "btnSortEmail";
			this.btnSortEmail.Size = new System.Drawing.Size(64, 22);
			this.btnSortEmail.TabIndex = 3;
			this.btnSortEmail.Text = "SortEmail";
			this.btnSortEmail.Click += new System.EventHandler(this.btnSortEmail_Click);
			// 
			// btnWrapText
			// 
			this.btnWrapText.Location = new System.Drawing.Point(27, 409);
			this.btnWrapText.Name = "btnWrapText";
			this.btnWrapText.Size = new System.Drawing.Size(93, 22);
			this.btnWrapText.TabIndex = 4;
			this.btnWrapText.Text = "WrapText";
			// 
			// btnAddColon
			// 
			this.btnAddColon.Location = new System.Drawing.Point(407, 409);
			this.btnAddColon.Name = "btnAddColon";
			this.btnAddColon.Size = new System.Drawing.Size(46, 22);
			this.btnAddColon.TabIndex = 5;
			this.btnAddColon.Text = "Add ,";
			this.btnAddColon.Click += new System.EventHandler(this.btnAddColon_Click);
			// 
			// btnSemiColon
			// 
			this.btnSemiColon.Location = new System.Drawing.Point(473, 409);
			this.btnSemiColon.Name = "btnSemiColon";
			this.btnSemiColon.Size = new System.Drawing.Size(40, 22);
			this.btnSemiColon.TabIndex = 6;
			this.btnSemiColon.Text = "Add ;";
			this.btnSemiColon.Click += new System.EventHandler(this.btnSemiColon_Click);
			// 
			// btnClearText
			// 
			this.btnClearText.Location = new System.Drawing.Point(160, 409);
			this.btnClearText.Name = "btnClearText";
			this.btnClearText.Size = new System.Drawing.Size(80, 22);
			this.btnClearText.TabIndex = 7;
			this.btnClearText.Text = "Clear";
			this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
			// 
			// bteClearEmail
			// 
			this.bteClearEmail.Location = new System.Drawing.Point(520, 409);
			this.bteClearEmail.Name = "bteClearEmail";
			this.bteClearEmail.Size = new System.Drawing.Size(40, 22);
			this.bteClearEmail.TabIndex = 8;
			this.bteClearEmail.Text = "Clear";
			this.bteClearEmail.Click += new System.EventHandler(this.bteClearEmail_Click);
			// 
			// formGetEmail
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(573, 436);
			this.Controls.Add(this.bteClearEmail);
			this.Controls.Add(this.btnClearText);
			this.Controls.Add(this.btnSemiColon);
			this.Controls.Add(this.btnAddColon);
			this.Controls.Add(this.btnWrapText);
			this.Controls.Add(this.btnSortEmail);
			this.Controls.Add(this.btnGetEmail);
			this.Controls.Add(this.tbxEmail);
			this.Controls.Add(this.tbxText);
			this.Name = "formGetEmail";
			this.Text = "formGetEmail";
			this.Load += new System.EventHandler(this.FormGetEmail_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Org.RyanLiu.SmallTools.formGetEmail());
		}

		private void btnGetEmail_Click(object sender, System.EventArgs e)
		{
			this.tbxEmail.Text = GetEmail(this.tbxText.Text  );
		}

		/// <summary>
		/// get email address enclosed in <>
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		
		private String GetEmail(String text) 
		{
			int startPos=0;
			int endPos=0;
			String email ;

			String test ;
			
			StringBuilder sb = new StringBuilder(text.Length );
			while( (startPos = text.IndexOf("<", endPos)+1) != 0 ) 
			{
				if( (endPos = text.IndexOf (">", startPos ) ) !=-1 )  
				{
					email = text.Substring (startPos, endPos-startPos);

					if( IsValidEmail(email) )
					{
						sb = sb.Append (email).Append (this.lineSplitter );
					}
					test = sb.ToString ();
				}

			}//end while

			return sb.ToString(); 
		}

		private bool IsValidEmail(String email) 
		{
			return email.IndexOf('@') != -1;
		}

		private void FormGetEmail_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnSortEmail_Click(object sender, System.EventArgs e)
		{
			tbxEmail.Text = SortLines(tbxEmail.Lines );
		}

		private String  SortLines(String[] lines)
		{
			Array.Sort (lines);
			
			return AddEndSymbol(lines, "" );
		}

		private void btnAddColon_Click(object sender, System.EventArgs e)
		{
			tbxEmail.Text = AddEndSymbol(tbxEmail.Lines,",");
		}

		private void btnSemiColon_Click(object sender, System.EventArgs e)
		{
			tbxEmail.Text = AddEndSymbol(tbxEmail.Lines,";");
		}
		
		private String AddEndSymbol(String[] lines, String endSymbol)
		{
			StringBuilder sb = new StringBuilder(this.tbxEmail.Text.Length );
			for(int i=0; i<lines.Length ; i++ ) 
			{
				sb.Append(lines[i]).Append( endSymbol).Append(this.lineSplitter )  ;
			}
			
			return sb.ToString();

		}

		private void btnClearText_Click(object sender, System.EventArgs e)
		{
			this.tbxText.Text ="";
		}

		private void bteClearEmail_Click(object sender, System.EventArgs e)
		{
			this.tbxEmail.Text ="";
		}

		private void tbxText_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
