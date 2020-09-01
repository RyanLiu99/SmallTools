using System;
using System.Drawing;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using  MySQLDriverCS;
using System.Diagnostics;
//using MySQLDriverCS;

namespace Org.RyanLiu.SmallTools
{
	/// <summary>
	/// Summary description for TestConnectionForm.
	/// </summary>
	public class TestConnectionForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbxHost;
		private System.Windows.Forms.Button btnTestSpecificConnection;
		private System.Windows.Forms.TextBox tbxUser;
		private System.Windows.Forms.TextBox tbxPassword;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private IDbConnection systemConnection;
		private System.Windows.Forms.Button btnClosespecificConn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbxDb;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExec;
		private IDbConnection specificConnection;
		private System.Windows.Forms.ComboBox cbxSql;
		private System.Windows.Forms.RadioButton rbtDriverNew;
		private System.Windows.Forms.RadioButton rbtDriverOld;
		private System.Windows.Forms.ComboBox cbxEncoding;
		private System.Windows.Forms.TextBox tbxResult;

		private IDbConnection currentConnection;

		public TestConnectionForm()
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
            this.btnTestSpecificConnection = new System.Windows.Forms.Button();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEncoding = new System.Windows.Forms.ComboBox();
            this.rbtDriverOld = new System.Windows.Forms.RadioButton();
            this.rbtDriverNew = new System.Windows.Forms.RadioButton();
            this.tbxDb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClosespecificConn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxSql = new System.Windows.Forms.ComboBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTestSpecificConnection
            // 
            this.btnTestSpecificConnection.Location = new System.Drawing.Point(33, 186);
            this.btnTestSpecificConnection.Name = "btnTestSpecificConnection";
            this.btnTestSpecificConnection.Size = new System.Drawing.Size(114, 22);
            this.btnTestSpecificConnection.TabIndex = 0;
            this.btnTestSpecificConnection.Text = "Open Connection";
            this.btnTestSpecificConnection.Click += new System.EventHandler(this.btnTestSpecificConnection_Click);
            // 
            // tbxHost
            // 
            this.tbxHost.Location = new System.Drawing.Point(100, 32);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(100, 20);
            this.tbxHost.TabIndex = 1;
            this.tbxHost.Text = "localhost";
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(88, 89);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(100, 20);
            this.tbxUser.TabIndex = 2;
            this.tbxUser.Text = "cati";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(88, 129);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.Text = "cati";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxEncoding);
            this.groupBox1.Controls.Add(this.rbtDriverOld);
            this.groupBox1.Controls.Add(this.rbtDriverNew);
            this.groupBox1.Controls.Add(this.tbxDb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnClosespecificConn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxUser);
            this.groupBox1.Controls.Add(this.tbxPassword);
            this.groupBox1.Controls.Add(this.btnTestSpecificConnection);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 297);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Specify:";
            // 
            // cbxEncoding
            // 
            this.cbxEncoding.Items.AddRange(new object[] {
            "latin1",
            "utf8",
            "gb2312"});
            this.cbxEncoding.Location = new System.Drawing.Point(153, 215);
            this.cbxEncoding.Name = "cbxEncoding";
            this.cbxEncoding.Size = new System.Drawing.Size(80, 21);
            this.cbxEncoding.TabIndex = 12;
            this.cbxEncoding.Text = "latin1";
            // 
            // rbtDriverOld
            // 
            this.rbtDriverOld.Location = new System.Drawing.Point(73, 238);
            this.rbtDriverOld.Name = "rbtDriverOld";
            this.rbtDriverOld.Size = new System.Drawing.Size(74, 15);
            this.rbtDriverOld.TabIndex = 11;
            this.rbtDriverOld.Text = "Old Driver";
            // 
            // rbtDriverNew
            // 
            this.rbtDriverNew.Checked = true;
            this.rbtDriverNew.Location = new System.Drawing.Point(73, 215);
            this.rbtDriverNew.Name = "rbtDriverNew";
            this.rbtDriverNew.Size = new System.Drawing.Size(74, 15);
            this.rbtDriverNew.TabIndex = 10;
            this.rbtDriverNew.TabStop = true;
            this.rbtDriverNew.Text = "new Driver";
            // 
            // tbxDb
            // 
            this.tbxDb.Location = new System.Drawing.Point(88, 56);
            this.tbxDb.Name = "tbxDb";
            this.tbxDb.Size = new System.Drawing.Size(104, 20);
            this.tbxDb.TabIndex = 9;
            this.tbxDb.Text = "cati";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Db:";
            // 
            // btnClosespecificConn
            // 
            this.btnClosespecificConn.Enabled = false;
            this.btnClosespecificConn.Location = new System.Drawing.Point(80, 267);
            this.btnClosespecificConn.Name = "btnClosespecificConn";
            this.btnClosespecificConn.Size = new System.Drawing.Size(53, 25);
            this.btnClosespecificConn.TabIndex = 7;
            this.btnClosespecificConn.Text = "Close it";
            this.btnClosespecificConn.Click += new System.EventHandler(this.btnClosespecificConn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "User:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host:";
            // 
            // tbxResult
            // 
            this.tbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResult.Location = new System.Drawing.Point(320, 22);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxResult.Size = new System.Drawing.Size(417, 288);
            this.tbxResult.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(347, 318);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 22);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxSql
            // 
            this.cbxSql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxSql.Items.AddRange(new object[] {
            "select name from province",
            "select name from project",
            "select name from call_failures",
            "select qn_script from project_qn where id =1",
            "set names latin1",
            "set names utf8",
            "set names gb2312",
            "SET character_set_results = latin1",
            "SET character_set_results = utf8",
            "SET character_set_results = gb2312",
            "SET character_set_results = null"});
            this.cbxSql.Location = new System.Drawing.Point(40, 347);
            this.cbxSql.Name = "cbxSql";
            this.cbxSql.Size = new System.Drawing.Size(560, 21);
            this.cbxSql.TabIndex = 10;
            this.cbxSql.Text = "select name from province";
            // 
            // btnExec
            // 
            this.btnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExec.Location = new System.Drawing.Point(535, 318);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(65, 22);
            this.btnExec.TabIndex = 11;
            this.btnExec.Text = "Execute";
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // TestConnectionForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(744, 397);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.cbxSql);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.tbxHost);
            this.Controls.Add(this.groupBox1);
            this.Name = "TestConnectionForm";
            this.Text = "TestConnectionForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		


		private void btnTestSpecificConnection_Click(object sender, System.EventArgs e)
		{
		

			string host = tbxHost.Text ;
			string password = tbxPassword.Text;
			string user = tbxUser.Text ;
			string db = tbxDb.Text;
			string encoding = this.cbxEncoding.Text.Trim();


			try
			{
				if(this.rbtDriverOld.Checked)
				{
					specificConnection =new MySQLConnection(new MySQLConnectionString(host,db,user,password).AsString);

				}
				else
				{

					string	myConnectionString = "Database=" + db + 
						";Data Source=" +host + ";User Id=" +user
						+ ";Password=" + password + ";old syntax=yes;Allow Zero Datetime=true;CharSet=" + encoding + ";"; //latin1_swedish_ci
				
				
				
					specificConnection = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
			
				}

				specificConnection.Open();

				btnClosespecificConn.Enabled = true;
				MessageBox.Show("Connect to DB OK!"); 	
				this.currentConnection = specificConnection;
				
			}
			catch(Exception ex)
			{
							
				
				MessageBox.Show(ex.ToString());
				
			}
		}

		private void btnClosespecificConn_Click(object sender, System.EventArgs e)
		{
			if(specificConnection !=null) this.specificConnection.Close();
			btnClosespecificConn.Enabled =false;
			specificConnection = null;
			this.currentConnection = null;

		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			this.tbxResult.Clear();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			try
			{
				if(specificConnection !=null) this.specificConnection.Close();

			}
			catch
			{
			}

			

			
			base.OnClosing (e);
		}

		private void btnExec_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.currentConnection == null)
				{
					btnTestSpecificConnection_Click(null, null);
				}
				string sql = this.cbxSql.Text.Trim();

				if(sql.ToUpper().StartsWith("SELECT") || sql.ToUpper().StartsWith("DESC") || sql.ToUpper().StartsWith("SHOW"))
				{
					//DbUtil.ExecNoQuery("SET character_set_results = latin1");
					//DbUtil.ExecNoQuery("SET character_set_results = NULL");
					//DbUtil.ExecNoQuery("SET character_set_results = gb2312");
					this.tbxResult.Text += "\r\n\r\n" + DbUtil.GetOneColumnValues(sql, this.currentConnection);
				}
				else
				{
					this.tbxResult.Text += "\r\n" + sql + "-- lines changed: " + DbUtil.ExecNoQuery(sql, this.currentConnection);
				}
			}
			catch(Exception ex)
			{
				this.tbxResult.Text += ex.ToString();
			}

		}

	

		


	}
}
