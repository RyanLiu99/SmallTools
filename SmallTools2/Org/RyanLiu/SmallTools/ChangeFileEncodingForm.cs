using SmallTools2.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmallTools2.Org.RyanLiu.SmallTools
{
    public partial class ChangeFileEncodingForm : Form
    {
        public ChangeFileEncodingForm()
        {
            InitializeComponent();
        }

        private void brnBrwoserFolder_Click(object sender, EventArgs e)
        {
            var result  = this.folderBrowserDialog1.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.tbxFolder.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void ChangeFileEncodingForm_Load(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowNewFolderButton = false;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            this.tbxMsg.SelectAll();
            this.tbxMsg.Copy();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.tbxMsg.Clear();
        }

        private void ShowMsg(object msg)
        {
            this.tbxMsg.AppendText(msg.ToString() + "\r\n");
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var from = this.cbxEncodingFrom.Text.Trim();
            var to = this.cbxEncocingTo.Text.Trim();

            if(from.Equals(to, StringComparison.InvariantCultureIgnoreCase))
            {
                ShowMsg("from and to are same encoding");
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.btnExecute.Enabled = false;
                FileUtility.ChangeFileEncoding(this.tbxFolder.Text.Trim(),
                    from, to, this.tbxFilePattern.Text.Trim(), ShowMsg);

            }
            catch (Exception ex)
            {
                ShowMsg(ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.btnExecute.Enabled = true;

            }
     
        }
    }
}
