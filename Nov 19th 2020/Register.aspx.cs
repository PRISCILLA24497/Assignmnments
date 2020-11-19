using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApiregisterform
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                TextBox1.Focus();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "Prisci2@")
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                Response.Write("Invalid Credentials");
            }
        }
    }
    }
