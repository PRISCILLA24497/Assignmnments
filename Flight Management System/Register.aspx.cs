using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FlightAssignmenr
{
	public partial class Register : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
			con.Open();
			var insertQuery = "insert into Flight1(Id,Name,Password,Age,Gender)values(@USERID,@NAME,@PASSWORD,@AGE,@GENDER)";
			SqlCommand cmd = new SqlCommand(insertQuery, con);
			string GENDER = string.Empty;
			if (RadioButton1.Checked)
			{
				GENDER = "male";
			}
			else if (RadioButton2.Checked)
			{
				GENDER = "female";
			}

			cmd.Parameters.AddWithValue("@USERID", TextBox1.Text);
			cmd.Parameters.AddWithValue("@NAME", TextBox2.Text);
			cmd.Parameters.AddWithValue("@PASSWORD", TextBox3.Text);
			cmd.Parameters.AddWithValue("@AGE", TextBox5.Text);

			cmd.Parameters.AddWithValue("@GENDER", GENDER);
			cmd.ExecuteNonQuery();
			Response.Write("Registeration Succesful!!");
			con.Close();
		}
	}
}