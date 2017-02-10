using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeTaskWebProgramming
{
    public partial class Details : System.Web.UI.Page
    {
        List<Client> cl = new List<Client>();
        protected void Page_Load(object sender, EventArgs e)
        {
            TableHeaderRow hr = new TableHeaderRow();
            TableCell hrc1 = new TableCell();
            TableCell hrc2 = new TableCell();
            TableCell hrc3 = new TableCell();

            hrc1.Text = "Client #";
            hrc2.Text = "Ip Adress";
            hrc3.Text = "Status";

            hr.Cells.Add(hrc1);
            hr.Cells.Add(hrc2);
            hr.Cells.Add(hrc3);

            Table1.Rows.Add(hr);
        }

        public class Client
        {
            private string Ipadder;
            private string status;
            private string number;


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