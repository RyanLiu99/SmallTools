using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallTools2.Org.RyanLiu.SmallTools
{
  
    public partial class PropertyGeneratorForm : Form
    {
       // private readonly List<Property> Properties = new List<Property>();
        public PropertyGeneratorForm()
        {
            InitializeComponent();

            //this.dgProperties.DataSource = Properties;
            //this.dgProperties.ReadOnly = false;
            //this.dgProperties.AllowUserToAddRows = true;

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            this.tbxResult.SelectAll();
            this.tbxResult.Copy();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.tbxResult.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //this.Properties.ForEach(p =>
            //{
            //    this.tbxResult.AppendText(p.Name + " " + p.Type + "\r\n");
            //});

            foreach (DataGridViewRow row in this.dgProperties.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    this.tbxResult.AppendText(cell.Value + " " );
                }
                this.tbxResult.AppendText("\r\n");
            }
        }

        //public class Property
        //{
        //    public string Name { get; set; }
        //    public string Type { get; set; }

        //    public Property(string name, string type)
        //    {
        //        Name = name;
        //        Type = type;
        //    }
        //}
    }
}
