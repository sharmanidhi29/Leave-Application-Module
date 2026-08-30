using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pr5
{
    public partial class LeaveApply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check whether Employee cookie exists
                if (Request.Cookies["Employee"] != null)
                {
                    txtemp.Text = Request.Cookies["Employee"].Value;
                }

                // Display current date
                lblButtonDT.Text =
                    DateTime.Now.ToString("dd-MM-yy");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string ename = txtemp.Text;
            string leavetp = DropDownList1.SelectedValue;
            string reason = TextBox2.Text;
            string leavedate = lblButtonDT.Text;

            // Store employee name in cookie if checkbox is checked
            if (CheckBox1.Checked)
            {
                Response.Cookies["Employee"].Value = ename;

                // Cookie will expire after 7 days
                Response.Cookies["Employee"].Expires =
                    DateTime.Now.AddDays(7);
            }

            // Store details in Session
            Session["Employee"] = ename;
            Session["LeaveType"] = leavetp;
            Session["LeaveDate"] = leavedate;
            Session["Reason"] = reason;

            // Display leave application details
            if (leavetp == "Select Leave Type")
            {
                lblmsg.Text =
                    "Please select a Leave Type.";
            }
            else
            {
                lblmsg.Text =
                    "<b>Leave Application Submitted Successfully</b><br/><br/>" +
                    "Employee Name: " + ename + "<br/>" +
                    "Leave Date: " + leavedate + "<br/>" +
                    "Leave Type: " + leavetp + "<br/>" +
                    "Reason: " + reason;
            }
        }
    }
}