using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webapiquerystate
{
    public partial class Login : System.Web.UI.Page
    {
   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                TextBox1.Focus();


            string value = Request.Form["HFCount"];
            Response.Write("Your current hit count is:" + value);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "101" && TextBox4.Text=="Prisci123" && TextBox2.Text=="Prisci@gmail.com" && TextBox3.Text== "Priscilla")
            {
                Response.Write("Login Successful");
                Response.Redirect("Admin.aspx?ID=" + TextBox1.Text + "&Email=" +TextBox2.Text + "&Name=" +TextBox3.Text);
            }
            else
                Label1.Text = "Invalid User credentials";


            

        }

        protected void HiddenField1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
    }
