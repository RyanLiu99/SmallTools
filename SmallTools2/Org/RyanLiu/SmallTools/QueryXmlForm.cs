using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
//using System.Reactive.Linq;
using System.Xml;

namespace SmallTools2.Org.RyanLiu.SmallTools
{
    public partial class QueryXmlForm : Form
    {
        public QueryXmlForm()
        {
            InitializeComponent();
        }

        static IEnumerable<XElement> SimpleStreamAxis(
                       string inputUrl, string matchName)
        {
            using(XmlReader reader = XmlReader.Create(inputUrl))
            {
                reader.MoveToContent();
                while(reader.Read())
                {
                    switch(reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if(reader.Name == matchName)
                            {
                                XElement el = XElement.ReadFrom(reader)
                                                      as XElement;
                                if(el != null)
                                    yield return el;
                            }
                            break;
                    }
                }
                reader.Close();
            }
        }
        
        private void btnOutput_Click(object sender, EventArgs e)
        {
        }

        //public static void QueryBooks()
        //{
        //    string inputUrl = "books.xml";
        //    var books = from book in SimpleStreamAxis(inputUrl, "option")
        //                where book.Value.EndsWith("2011") //|| book.Value.EndsWith("2012")                       
        //                && !book.Value.Contains("CSS") && !book.Value.Contains("iOS")
        //                && !book.Value.Contains("SharePoint") && !book.Value.Contains("iPhone")
        //                && !book.Value.Contains("Small Business") && !book.Value.Contains("Twitter")
        //                && !book.Value.Contains("CRM") && !book.Value.Contains("Facebook")
        //                && !book.Value.Contains("ActionScript") && !book.Value.Contains("Galaxy")
        //                select book.Value;

        //    //foreach(var book in books)
        //    //{
        //    //    Console.WriteLine(book);
        //    //}

        //    var oBooks = books.ToObservable();
        //    oBooks.Subscribe(Console.WriteLine);
        //}
    }
}
