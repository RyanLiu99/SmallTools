using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Linq;

namespace Org.RyanLiu.SmallTools
{
	public partial class EncodingStringUtilForm: Form
	{
		public EncodingStringUtilForm()
		{
			InitializeComponent();
		}

        private void btnHtmlDecode_Click(object sender, EventArgs e)
        {
            Process(() => this.tbxResult.Text = HttpUtility.HtmlDecode(this.tbxSrc.Text));
        }

        private void btnHtmlEncode_Click(object sender, EventArgs e)
        {
            Process(() => this.tbxResult.Text = HttpUtility.HtmlEncode(this.tbxSrc.Text));         
        }

        private void btnUrlDecode_Click(object sender, EventArgs e)
        {
            Process(() => this.tbxResult.Text = HttpUtility.UrlDecode(this.tbxSrc.Text));
        }

        private void btnUrlEncode_Click(object sender, EventArgs e)
        {
            Process(()=> this.tbxResult.Text = HttpUtility.UrlEncode(this.tbxSrc.Text));          
        }

        private void btnBase64Decode_Click(object sender, EventArgs e)
        {
            Process(() => this.tbxResult.Text = Base64Decode(this.tbxSrc.Text));
        }

        private void btnBase64Encode_Click(object sender, EventArgs e)
        {
            Process(() => this.tbxResult.Text = Base64Encode(this.tbxSrc.Text));
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

      

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void Process(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), ex.Message);
            }
        }

        private void btnFindDuplicateChar_Click(object sender, EventArgs e)
        {
            Process(
                () =>
                {
                    var str = this.tbxSrc.Text.Trim();

                    var q = from c in str where str.IndexOf(c) != str.LastIndexOf(c) select c;
                    this.tbxResult.Text = new string(q.Distinct().ToArray());
                }
            );

        }
	}
}
