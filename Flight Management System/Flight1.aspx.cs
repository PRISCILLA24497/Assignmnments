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
	public partial class Flight1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

	

		protected void Button1_Click(object sender, EventArgs e)
		{
			Session["value"] = TextBox1.Text;
			Session["value1"] = TextBox2.Text;
			if (RadioButton1.Checked)
			{
				Session["value3"] = RadioButton1.Text;
			}
			else
			{
				Session["value3"] = RadioButton2.Text;
			}
			Session["value4"] = TextBox3.Text;
			Session["value5"] = TextBox4.Text;
			Session["value6"] = DropDownList1.Text;

			Response.Redirect("TicketGeneration.aspx");
		}
		protected void Button2_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
			con.Open();
			var insertQuery = "insert into Booking1(UserName,Age,Gender,Source,Destination,Class)values(@UserName,@Age,@Gender,@Source,@Destination,@Class)";
			SqlCommand cmd = new SqlCommand(insertQuery, con);
			string gender = string.Empty;
			if (RadioButton1.Checked)
			{
				gender = "male";
			}
			else if (RadioButton2.Checked)
			{
				gender = "female";
			}


			cmd.Parameters.AddWithValue("@UserName", TextBox1.Text);
			cmd.Parameters.AddWithValue("@Age", TextBox2.Text);

			cmd.Parameters.AddWithValue("@Source", TextBox3.Text);
			cmd.Parameters.AddWithValue("@Gender", gender);
			cmd.Parameters.AddWithValue("@Destination", TextBox4.Text);
			cmd.Parameters.AddWithValue("@Class", DropDownList1.Text);
			int affectedrows = cmd.ExecuteNonQuery();
			if (affectedrows > 0)
			{
				Label1.Text = "Ticket Booking is Succeful!!";
			}
			else
			{
				Label1.Text = "Falied!";
			}



			cmd.ExecuteNonQuery();

			// Response.Redirect("TicketGeneration.aspx");
			con.Close();
		}
	}
}


		