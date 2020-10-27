using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies
{
	public partial class cookie : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void button1_Click(object sender, EventArgs e)
		{
			var something = "";
			if (checkbox1.Checked) { something = checkbox1.Text; }
			if (checkbox2.Checked) { something = checkbox2.Text; }
			if (checkbox3.Checked) { something = checkbox3.Text; }
			if (checkbox4.Checked) { something = checkbox4.Text; }
			if (checkbox5.Checked) { something = checkbox5.Text; }
			showcourses.Text = something;
		}
	}
}