using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Org.RyanLiu.StringDate;
using System.Text;
using System.Linq;

namespace Org.RyanLiu.SmallTools
{
	/// <summary>
	/// Summary description for BreakLinesForm.
	/// </summary>
	public class BreakLinesForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox tbxSrc;
		private System.Windows.Forms.TextBox tbxBroke;
		private System.Windows.Forms.Button btnBreaak;
		private System.Windows.Forms.TextBox tbxSplitStr;
		private System.Windows.Forms.Button btnClearSrc;
		private System.Windows.Forms.Button btnClearResult;
		private System.Windows.Forms.Button btnCopytAll;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox tbxAddText;
		private System.Windows.Forms.Button btnAddBefore;
		private System.Windows.Forms.Button btnAddAfter;
        private CheckBox cbxRemoveIt;
        private Panel pnlBottom;
        private Button btnTakeLeft;
        private Button btnTakeRight;
        private Button btnLinesAddBefore;
        private Button btnLinesAddAfter;
        private Label label1;
        private Button btnFormatException;
        private Button btnToOneLine;
        private Button btnMoveResultToLeft;
        private Button btnRemoveLineStartsWith;
        private Label label2;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public BreakLinesForm()
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
            this.tbxSrc = new System.Windows.Forms.TextBox();
            this.tbxBroke = new System.Windows.Forms.TextBox();
            this.btnBreaak = new System.Windows.Forms.Button();
            this.tbxSplitStr = new System.Windows.Forms.TextBox();
            this.btnClearSrc = new System.Windows.Forms.Button();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.btnCopytAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxAddText = new System.Windows.Forms.TextBox();
            this.btnAddAfter = new System.Windows.Forms.Button();
            this.btnAddBefore = new System.Windows.Forms.Button();
            this.cbxRemoveIt = new System.Windows.Forms.CheckBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnTakeLeft = new System.Windows.Forms.Button();
            this.btnTakeRight = new System.Windows.Forms.Button();
            this.btnLinesAddBefore = new System.Windows.Forms.Button();
            this.btnLinesAddAfter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFormatException = new System.Windows.Forms.Button();
            this.btnToOneLine = new System.Windows.Forms.Button();
            this.btnMoveResultToLeft = new System.Windows.Forms.Button();
            this.btnRemoveLineStartsWith = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSrc
            // 
            this.tbxSrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxSrc.Location = new System.Drawing.Point(14, 62);
            this.tbxSrc.Multiline = true;
            this.tbxSrc.Name = "tbxSrc";
            this.tbxSrc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxSrc.Size = new System.Drawing.Size(417, 366);
            this.tbxSrc.TabIndex = 0;
            // 
            // tbxBroke
            // 
            this.tbxBroke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBroke.Location = new System.Drawing.Point(558, 55);
            this.tbxBroke.Multiline = true;
            this.tbxBroke.Name = "tbxBroke";
            this.tbxBroke.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxBroke.Size = new System.Drawing.Size(475, 373);
            this.tbxBroke.TabIndex = 1;
            // 
            // btnBreaak
            // 
            this.btnBreaak.Location = new System.Drawing.Point(442, 105);
            this.btnBreaak.Name = "btnBreaak";
            this.btnBreaak.Size = new System.Drawing.Size(110, 56);
            this.btnBreaak.TabIndex = 2;
            this.btnBreaak.Text = ">&Break to multiple lines";
            this.btnBreaak.Click += new System.EventHandler(this.btnBreaak_Click);
            // 
            // tbxSplitStr
            // 
            this.tbxSplitStr.Location = new System.Drawing.Point(459, 22);
            this.tbxSplitStr.Name = "tbxSplitStr";
            this.tbxSplitStr.Size = new System.Drawing.Size(65, 22);
            this.tbxSplitStr.TabIndex = 4;
            this.tbxSplitStr.Text = "at ";
            // 
            // btnClearSrc
            // 
            this.btnClearSrc.Location = new System.Drawing.Point(14, 16);
            this.btnClearSrc.Name = "btnClearSrc";
            this.btnClearSrc.Size = new System.Drawing.Size(77, 28);
            this.btnClearSrc.TabIndex = 5;
            this.btnClearSrc.Text = "C&lear";
            this.btnClearSrc.Click += new System.EventHandler(this.btnClearSrc_Click);
            // 
            // btnClearResult
            // 
            this.btnClearResult.Location = new System.Drawing.Point(692, 3);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(66, 28);
            this.btnClearResult.TabIndex = 6;
            this.btnClearResult.Text = "Clear";
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // btnCopytAll
            // 
            this.btnCopytAll.Location = new System.Drawing.Point(585, 3);
            this.btnCopytAll.Name = "btnCopytAll";
            this.btnCopytAll.Size = new System.Drawing.Size(88, 28);
            this.btnCopytAll.TabIndex = 7;
            this.btnCopytAll.Text = "Copy All";
            this.btnCopytAll.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(790, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxAddText
            // 
            this.tbxAddText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAddText.Location = new System.Drawing.Point(649, 21);
            this.tbxAddText.Name = "tbxAddText";
            this.tbxAddText.Size = new System.Drawing.Size(203, 22);
            this.tbxAddText.TabIndex = 9;
            this.tbxAddText.Text = "alter table ";
            // 
            // btnAddAfter
            // 
            this.btnAddAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAfter.Location = new System.Drawing.Point(857, 18);
            this.btnAddAfter.Name = "btnAddAfter";
            this.btnAddAfter.Size = new System.Drawing.Size(77, 28);
            this.btnAddAfter.TabIndex = 10;
            this.btnAddAfter.Text = "Add After";
            this.btnAddAfter.Click += new System.EventHandler(this.btnAddAfter_Click);
            // 
            // btnAddBefore
            // 
            this.btnAddBefore.Location = new System.Drawing.Point(539, 17);
            this.btnAddBefore.Name = "btnAddBefore";
            this.btnAddBefore.Size = new System.Drawing.Size(104, 27);
            this.btnAddBefore.TabIndex = 11;
            this.btnAddBefore.Text = "Add Before";
            this.btnAddBefore.Click += new System.EventHandler(this.btnAddBefore_Click);
            // 
            // cbxRemoveIt
            // 
            this.cbxRemoveIt.AutoSize = true;
            this.cbxRemoveIt.Location = new System.Drawing.Point(447, 165);
            this.cbxRemoveIt.Name = "cbxRemoveIt";
            this.cbxRemoveIt.Size = new System.Drawing.Size(93, 21);
            this.cbxRemoveIt.TabIndex = 12;
            this.cbxRemoveIt.Text = "Remvoe it";
            this.cbxRemoveIt.UseVisualStyleBackColor = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnClearResult);
            this.pnlBottom.Controls.Add(this.btnCopytAll);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 451);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1049, 38);
            this.pnlBottom.TabIndex = 13;
            // 
            // btnTakeLeft
            // 
            this.btnTakeLeft.Location = new System.Drawing.Point(442, 202);
            this.btnTakeLeft.Name = "btnTakeLeft";
            this.btnTakeLeft.Size = new System.Drawing.Size(97, 28);
            this.btnTakeLeft.TabIndex = 14;
            this.btnTakeLeft.Text = ">Take Left";
            this.btnTakeLeft.Click += new System.EventHandler(this.btnTakeLeft_Click);
            // 
            // btnTakeRight
            // 
            this.btnTakeRight.Location = new System.Drawing.Point(442, 236);
            this.btnTakeRight.Name = "btnTakeRight";
            this.btnTakeRight.Size = new System.Drawing.Size(97, 27);
            this.btnTakeRight.TabIndex = 15;
            this.btnTakeRight.Text = ">Take Right";
            this.btnTakeRight.Click += new System.EventHandler(this.btnTakeRight_Click);
            // 
            // btnLinesAddBefore
            // 
            this.btnLinesAddBefore.Location = new System.Drawing.Point(437, 330);
            this.btnLinesAddBefore.Name = "btnLinesAddBefore";
            this.btnLinesAddBefore.Size = new System.Drawing.Size(97, 28);
            this.btnLinesAddBefore.TabIndex = 16;
            this.btnLinesAddBefore.Text = ">Add before";
            this.btnLinesAddBefore.Click += new System.EventHandler(this.btnLinesAddBefore_Click);
            // 
            // btnLinesAddAfter
            // 
            this.btnLinesAddAfter.Location = new System.Drawing.Point(439, 364);
            this.btnLinesAddAfter.Name = "btnLinesAddAfter";
            this.btnLinesAddAfter.Size = new System.Drawing.Size(97, 28);
            this.btnLinesAddAfter.TabIndex = 17;
            this.btnLinesAddAfter.Text = ">Add after";
            this.btnLinesAddAfter.Click += new System.EventHandler(this.btnLinesAddAfter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = ">add Line to Line";
            // 
            // btnFormatException
            // 
            this.btnFormatException.Location = new System.Drawing.Point(110, 17);
            this.btnFormatException.Name = "btnFormatException";
            this.btnFormatException.Size = new System.Drawing.Size(131, 28);
            this.btnFormatException.TabIndex = 19;
            this.btnFormatException.Text = "Format &Exception text";
            this.btnFormatException.Click += new System.EventHandler(this.btnFormatException_Click);
            // 
            // btnToOneLine
            // 
            this.btnToOneLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToOneLine.Location = new System.Drawing.Point(938, 18);
            this.btnToOneLine.Name = "btnToOneLine";
            this.btnToOneLine.Size = new System.Drawing.Size(106, 28);
            this.btnToOneLine.TabIndex = 20;
            this.btnToOneLine.Text = "To One line";
            this.btnToOneLine.Click += new System.EventHandler(this.btnToOneLine_Click);
            // 
            // btnMoveResultToLeft
            // 
            this.btnMoveResultToLeft.Location = new System.Drawing.Point(439, 412);
            this.btnMoveResultToLeft.Name = "btnMoveResultToLeft";
            this.btnMoveResultToLeft.Size = new System.Drawing.Size(105, 26);
            this.btnMoveResultToLeft.TabIndex = 22;
            this.btnMoveResultToLeft.Text = "< Move Result to Left ";
            this.btnMoveResultToLeft.UseVisualStyleBackColor = true;
            this.btnMoveResultToLeft.Click += new System.EventHandler(this.btnMoveResultToLeft_Click);
            // 
            // btnRemoveLineStartsWith
            // 
            this.btnRemoveLineStartsWith.Location = new System.Drawing.Point(442, 47);
            this.btnRemoveLineStartsWith.Name = "btnRemoveLineStartsWith";
            this.btnRemoveLineStartsWith.Size = new System.Drawing.Size(115, 52);
            this.btnRemoveLineStartsWith.TabIndex = 24;
            this.btnRemoveLineStartsWith.Text = ">Remove Lines start with";
            this.btnRemoveLineStartsWith.UseVisualStyleBackColor = true;
            this.btnRemoveLineStartsWith.Click += new System.EventHandler(this.btnRemoveLineStartsWith_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Keyword";
            // 
            // BreakLinesForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1049, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveLineStartsWith);
            this.Controls.Add(this.cbxRemoveIt);
            this.Controls.Add(this.btnMoveResultToLeft);
            this.Controls.Add(this.btnToOneLine);
            this.Controls.Add(this.tbxSplitStr);
            this.Controls.Add(this.btnFormatException);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLinesAddAfter);
            this.Controls.Add(this.btnLinesAddBefore);
            this.Controls.Add(this.btnTakeRight);
            this.Controls.Add(this.btnTakeLeft);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.btnAddBefore);
            this.Controls.Add(this.btnAddAfter);
            this.Controls.Add(this.tbxAddText);
            this.Controls.Add(this.btnClearSrc);
            this.Controls.Add(this.btnBreaak);
            this.Controls.Add(this.tbxBroke);
            this.Controls.Add(this.tbxSrc);
            this.Name = "BreakLinesForm";
            this.Text = "BreakLinesForm";
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void btnClearSrc_Click(object sender, System.EventArgs e)
		{
			this.tbxSrc.Clear();  
		}

		private void btnClearResult_Click(object sender, System.EventArgs e)
		{
			this.tbxBroke.Clear();
		}

		private void btnBreaak_Click(object sender, System.EventArgs e)
		{
			string splitStr = this.tbxSplitStr.Text;

            bool removeIt = this.cbxRemoveIt.Checked;
 
			if(splitStr == null || splitStr=="") 
			{
				MessageBox.Show ("Give split string!");
				return;
			}
			
			string src = this.tbxSrc.Text;
            this.tbxBroke.Clear();

            int lastLineEnd=-1;
			int searchStartPos =0;
			int foundPos=0;
	
			string line=""; //line before foundPos
			int lineLength=0;
			
			while ( (foundPos=src.IndexOf(splitStr, searchStartPos)  ) != -1 )
			{
                
				lineLength = foundPos - lastLineEnd + splitStr.Length -1;

                if (removeIt)
                {
                    line = src.Substring(lastLineEnd + 1, lineLength - splitStr.Length);
                }
                else
                {
                    line = src.Substring(lastLineEnd + 1 , lineLength);
                }
				this.tbxBroke.Text += "\r\n" + line;
					
				lastLineEnd = foundPos + splitStr.Length-1;
				searchStartPos = foundPos + splitStr.Length; 

			}
			
			//add last line
			this.tbxBroke.Text += "\r\n" + src.Substring(lastLineEnd+1);


		}

		private void btnCopyAll_Click(object sender, System.EventArgs e)
		{
			this.tbxBroke.SelectAll(); 
			this.tbxBroke.Copy();
			
			//this.tbxBroke.Select(0, tbxBroke.Text.Length );
			
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnAddBefore_Click(object sender, System.EventArgs e)
		{
			this.tbxBroke.Text  = StringDateUtil.AddSymbol(this.tbxBroke.Lines, this.tbxAddText.Text, true);
		}


		private void btnAddAfter_Click(object sender, System.EventArgs e)
		{
			this.tbxBroke.Text  = StringDateUtil.AddSymbol(this.tbxBroke.Lines, this.tbxAddText.Text, false);
		
		}

        private void btnTakeLeft_Click(object sender, EventArgs e)
        {
            this.TakeHalf(true);
            
        }

        private void TakeHalf(bool takeLeft)
        {
            try
            {
                string splitStr = this.tbxSplitStr.Text;

                bool removeIt = this.cbxRemoveIt.Checked;

                if (splitStr == null || splitStr == "")
                {
                    MessageBox.Show("Give split string!");
                    return;
                }

                string[] lines = this.tbxSrc.Lines;

                StringBuilder sb = new StringBuilder();
                foreach (string line in lines)
                {
                    string[] ss = line.Split(new string[] { splitStr }, StringSplitOptions.None);
                    if (takeLeft) sb.Append(ss[0]);
                    else
                    {
                        if (ss.Length > 1) sb.Append(ss[1]);
                    }
                    sb.Append("\r\n");

                }

                this.tbxBroke.Text = sb.ToString();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnTakeRight_Click(object sender, EventArgs e)
        {
            this.TakeHalf(false);
        }

        private void btnLinesAddBefore_Click(object sender, EventArgs e)
        {
            AppendLineToLine(true);
        }

        private void btnLinesAddAfter_Click(object sender, EventArgs e)
        {
            AppendLineToLine(false);
        }

	    private void AppendLineToLine(bool left)
	    {
            StringBuilder sb = new StringBuilder();

            int resultLinesCount = this.tbxBroke.Lines.Length;

            for (int i = 0; i < this.tbxSrc.Lines.Length; i++)
            {
                var srcLine = this.tbxSrc.Lines[i];
                if (i < resultLinesCount)
                {
                    var resultLine = this.tbxBroke.Lines[i];
                    if (left) sb.Append(srcLine);
                    sb.Append(resultLine);

                    if (!left) sb.Append(srcLine);
                    sb.AppendLine();
                }
                else
                {
                    sb.AppendLine(srcLine);   
                }
            }

            this.tbxBroke.Text = sb.ToString();

	    }

        private void btnFormatException_Click(object sender, EventArgs e)
        {
            this.btnClearSrc_Click(btnClearSrc, null);
            this.btnClearResult_Click(btnClearResult, null);
            this.tbxSrc.Paste();
            this.btnBreaak_Click(btnBreaak, null);
        }

        private void btnToOneLine_Click(object sender, EventArgs e)
        {
            this.tbxBroke.Text = this.tbxBroke.Text.Replace("\r", string.Empty).Replace("\n", string.Empty);
        }

        private void btnMoveResultToLeft_Click(object sender, EventArgs e)
        {
            this.tbxSrc.Text = this.tbxBroke.Text;
            this.tbxBroke.Clear();
        }

        private void btnRemoveLineStartsWith_Click(object sender, EventArgs e)
        {
            try
            {
                string splitStr = this.tbxSplitStr.Text;
                if (splitStr == null || splitStr == "")
                {
                    MessageBox.Show("Give start with string!");
                    return;
                }

                string[] lines = this.tbxSrc.Lines;
                var q = from line in lines where !line.StartsWith(splitStr) 
                        && !string.IsNullOrWhiteSpace(line)
                        select line;

                this.tbxBroke.Text = string.Join("\r\n", q);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
