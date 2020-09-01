using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Org.RyanLiu.SmallTools
{
	public partial class OpenUrlForm: Form
	{
		public OpenUrlForm()
		{
			InitializeComponent();
		}

        private void btnOpenUrl_Click(object sender, EventArgs e)
        {
            string pageData;
            WebClient client = new WebClient();
            string url = this.tbxUrl.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                this.txtPage.Text = "Please provide url";
                return;
            }

            if(!url.StartsWith(@"http://", StringComparison.InvariantCultureIgnoreCase))
            {
                url += @"http://";
            }
            try
            {
                pageData = client.DownloadString(url);
                this.txtPage.Text = pageData;
            }
            catch (Exception ex)
            {
                pageData = ex.Message;
            }
        }

        private void cbxEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encoding encoding = System.Text.Encoding.GetEncoding(this.cbxEncoding.Text.Trim());
        }
	}
}
