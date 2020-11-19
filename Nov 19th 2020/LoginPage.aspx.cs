using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApiregisterform
{
    public partial class LoginPage : System.Web.UI.Page
    {
        int count;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (IsPostBack)
                TextBox1.Focus();
           
           
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Priscilla" && TextBox2.Text == "Prisci2@")
            {
                Label2.Text = "Login Successful";

            }
            else
            {
                
                count = int.Parse(HFCount.Value);
                count += 1;
                Response.Write("Invalid Credentials!!");
                Response.Write("Unsucessful Attempts!!" + count);
                HFCount.Value = count.ToString();

               
            }

        }
    }
}