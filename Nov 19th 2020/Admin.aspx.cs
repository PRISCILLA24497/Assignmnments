using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webapiquerystate
{
    public partial class Admin : System.Web.UI.Page
    {
        int count;
        protected void Page_Load(object sender, EventArgs e)
        {
            string name1 = Request.QueryString["ID"]; 
            string name3= Request.QueryString["Name"];
            string name4 = Request.QueryString["Email"];
            Response.Write("Hello !!" +"Your Credentials are");
            Response.Write("ID:" +name1);
            Response.Write("Name:" +name3);
            Response.Write("Email:" +name4);
          

            
        }

        
    }
}