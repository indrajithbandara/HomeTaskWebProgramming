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
        public static List<Client> cl = new List<Client>();
//        public Client temp;
        protected void Page_Load(object sender, EventArgs e)
        {
            var temp = new Client();
            //            writeToXml("clients.xml");
            var path = Server.MapPath(@"~/xml/clients.xml");
            cl = ReadFromXml(path);


            if (!IsPostBack)
            {
                if (HttpContext.Current.Request.UserHostAddress != null)
                    temp.Ipadder = HttpContext.Current.Request.UserHostAddress.ToString();
                temp.browser = HttpContext.Current.Request.Browser.ToString();
                temp.status = "Active";
                temp.name = Session["name"].ToString();
                cl.Add(temp);

                //will write the list to the file
                WriteToXml(path);
            }

            //+The file is written

            TableHeaderRow hr = new TableHeaderRow();
            TableCell hrc1 = new TableCell();
            TableCell hrc2 = new TableCell();
            TableCell hrc3 = new TableCell();
            TableCell hrc4 = new TableCell();

            hrc1.Text = "Client #";
            hrc2.Text = "Name";
            hrc3.Text = "Ip Address";
            hrc4.Text = "Status";

            hr.Cells.Add(hrc1);
            hr.Cells.Add(hrc2);
            hr.Cells.Add(hrc3);
            hr.Cells.Add(hrc4);

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

                c1.Text = i.ToString();
                c2.Text = entry.name;
                c3.Text = entry.Ipadder;
                c4.Text = entry.status;


                tr.Cells.Add(c1);
                tr.Cells.Add(c2);
                tr.Cells.Add(c3);
                tr.Cells.Add(c4);
                Table1.Rows.Add(tr);
            }
        }


        public static void WriteToXml(string file)
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

        protected void Button1_Click1(object sender, EventArgs e)
        {
            foreach (var entry in cl)
            {
                if (entry.name.Equals(Session["name"].ToString()))
                    entry.status = "Not Active";
            }
            var path = Server.MapPath(@"~/xml/clients.xml");
            WriteToXml(path);
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}

public class Client
{
    public string name { get; set; }
    public string browser { get; set; }
    public string Ipadder { get; set; }
    public string status { get; set; }

    public Client(string name, string browser, string ipadder, string status)
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