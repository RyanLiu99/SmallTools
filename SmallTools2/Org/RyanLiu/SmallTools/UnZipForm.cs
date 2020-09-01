using System;
using System.Windows.Forms;
using System.IO;

using ICSharpCode.SharpZipLib.Zip;

namespace Org.RyanLiu.SmallTools
{
	public partial class UnZipForm: Form
	{
		public UnZipForm()
		{
			InitializeComponent();
            
		}

        private void UnZip(string zipFile, string targetFolder)
        {
            if (zipFile.Length == 0 || targetFolder.Length == 0) return;

            ZipInputStream zis = null;
            try
            {
                ZipEntry theEntry;


                int size = 8192;
                byte[] data = new byte[size];



                zis = new ZipInputStream(File.OpenRead(zipFile));



                while ((theEntry = zis.GetNextEntry()) != null)
                {
                    try //catch each entry problem, to continue
                    {
                        //for each entry, it is a db table
                        //Debug.WriteLine(theEntry.Name);


                        string dbTableName = theEntry.Name;


                        FileStream streamWriter = File.Create(targetFolder + Path.DirectorySeparatorChar.ToString() + dbTableName);

                        while (true)
                        {
                            size = zis.Read(data, 0, data.Length);
                            if (size > 0)
                            {
                                streamWriter.Write(data, 0, size);
                            }
                            else
                            {
                                break;
                            }
                        }//end output a table

                        streamWriter.Close();

                        



                    }
                    catch (Exception entryEx)
                    {
                        this.tbxOutput.Text += "\r\n entry error: " + theEntry.Name + ", " + entryEx.Message;
                    }
                }//end while entry


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "error" + ex.Message);
                this.tbxOutput.Text += "\r\n\r\n\r\n" + ex.ToString();

                this.tbxOutput.Select(this.tbxOutput.Text.Length, 0);
                this.tbxOutput.ScrollToCaret();
            }

            finally
            {
                if (zis != null) zis.Close();
            }
        }



        private void btnUnZip_Click(object sender, EventArgs e)
        {

            this.UnZip(this.tbxZipFile.Text, this.tbxUnZipFolder.Text);


        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult r = this.openFileDialog1.ShowDialog(this);
            if (r == DialogResult.Cancel) return;

            this.tbxZipFile.Text = this.openFileDialog1.FileName;
        }

        private void btnSelectDestFolder_Click(object sender, EventArgs e)
        {
           DialogResult r = this.folderBrowserDialog1.ShowDialog(this);
            if (r == DialogResult.Cancel) return;

            this.tbxUnZipFolder.Text = this.folderBrowserDialog1.SelectedPath;

           
        }

     

 

        
	}
}
