using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApiregisterform
{
    public partial class Count : System.Web.UI.Page
    {
        int count;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HFCount_ValueChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            count = int.Parse(HFCount.Value);
            count += 1;
            Response.Write("Number of counts:" + count);
            HFCount.Value = count.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count = int.Parse(HFCount.Value);
            count += 1;
            Response.Write("Number of counts:" + count);
            HFCount.Value = count.ToString();
        }
    }
}