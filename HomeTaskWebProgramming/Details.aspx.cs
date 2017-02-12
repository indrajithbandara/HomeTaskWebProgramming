using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace HomeTaskWebProgramming
{
    public partial class Details : System.Web.UI.Page
    {
        public List<Client> cl = new List<Client>();
//        public Client temp;
        protected void Page_Load(object sender, EventArgs e)
        {
            var temp = new Client();
            //            writeToXml("clients.xml");
            var path = Server.MapPath(@"~/XmlFiles/clients.xml");

            cl = ReadFromXml(path);

            temp.Ipadder = HttpContext.Current.Request.UserHostAddress.ToString();
            temp.browser = HttpContext.Current.Request.Browser.ToString();

            temp.status = "Active";
//            Label1.Text = Session["name"].ToString();
            temp.name = "ABC";
//            if (Session["name"].ToString() != null)
//                Console.WriteLine(Session["name"].ToString());
//            Console.Read();
//            string name = Session["name"].ToString();
//            temp.name = name;
            cl.Add(temp);


//            var temp2 = new Client();
//            temp2.Ipadder = HttpContext.Current.Request.UserHostAddress;
//            temp2.status = "Not Active";
//            temp2.name = "HAMZA";

//            cl.Add(temp2);
//
//            var temp3 = new Client();
//            temp3.Ipadder = "52.35.88.25";
//            temp3.status = "Not Active";
//            temp3.name = "Asas";
//
//            cl.Add(temp3);


            //+The file is written
            WriteToXml(path);
//            Console.WriteLine("I am here");

            TableHeaderRow hr = new TableHeaderRow();
            TableCell hrc1 = new TableCell();
            TableCell hrc2 = new TableCell();
            TableCell hrc3 = new TableCell();
            TableCell hrc4 = new TableCell();
            TableCell hrc5 = new TableCell();

            hrc1.Text = "Client #";
            hrc1.Text = "Client #";
            hrc2.Text = "Name";
            hrc3.Text = "Ip Adress";
            hrc4.Text = "Browser";
            hrc5.Text = "Status";

            hr.Cells.Add(hrc1);
            hr.Cells.Add(hrc2);
            hr.Cells.Add(hrc3);
            hr.Cells.Add(hrc4);
            hr.Cells.Add(hrc5);

            Table1.Rows.Add(hr);

            int i = 0;
            foreach (var entry in cl)
            {
                i++;
                TableRow tr = new TableRow();
                TableCell c1 = new TableCell();
                TableCell c2 = new TableCell();
                TableCell c3 = new TableCell();
                TableCell c4 = new TableCell();
                TableCell c5 = new TableCell();


                c1.Text = i.ToString();
                c2.Text = entry.name;
                c3.Text = entry.Ipadder;
                c4.Text = entry.browser;
                c5.Text = entry.status;
               

                tr.Cells.Add(c1);
                tr.Cells.Add(c2);
                tr.Cells.Add(c3);
                tr.Cells.Add(c4);
                Table1.Rows.Add(tr);
            }
        }


        public void WriteToXml(string file)
        {
            var xls = new XmlSerializer(typeof(List<Client>));
            TextWriter tw = new StreamWriter(file);
            xls.Serialize(tw, cl);
            tw.Close();
        }

        public static List<Client> ReadFromXml(string filePath)
        {
            var deserializer = new XmlSerializer(typeof(List<Client>));
            TextReader tr = new StreamReader(filePath);
            var temp = (List<Client>) deserializer.Deserialize(tr);
            tr.Close();
            return temp;
        }

        private string GetUserIP()
        {
            string ipList = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipList))
            {
                return ipList.Split(',')[0];
            }

            return Request.ServerVariables["REMOTE_ADDR"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
        }
    }
}

public class Client
{
    public string name { get; set; }
    public string browser { get; set; }
    public string Ipadder { get; set; }
    public string status { get; set; }

    public Client(string name, string browser,string ipadder, string status)
    {
        name = name;
        browser = browser;
        Ipadder = ipadder;
        this.status = status;
    }

    public Client()
    {
        name = "";
        Ipadder = "";
        browser = "";
        status = "Not Active";
    }
}