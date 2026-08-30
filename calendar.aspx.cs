using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pr5
{
    public partial class calander : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            // Select Date
            DateTime sldt = Calendar1.SelectedDate;

            lblSelectedDate.Text =
                "Selected Date " + sldt.ToString("dd-MM-yy");

            // Store selected date in session
            Session["LeaveDate"] = sldt;
        }

        protected void BtnApplyLeave_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeaveApply.aspx");
        }
    }
}