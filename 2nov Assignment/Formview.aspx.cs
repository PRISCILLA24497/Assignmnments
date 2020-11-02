using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ListView
{
	public partial class Formview : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand("select * from Student", con);
			SqlDataReader rd = cmd.ExecuteReader();
			FormView1.DataSource = rd;
			FormView1.DataBind();
			con.Close();

		}

		protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
		{

		}
	}
}