using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_FeedbackList : System.Web.UI.Page
{
     DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        var data = (from ta in dc.Feedbacks
                    join tc in dc.Users on ta.Fid equals tc.Uid
                    select new { ta.Fid, tc.Uname,tc.ULname, ta.DOF, ta.FMsg }).ToList();

       
        string str = "<table>";
        str += "<tr><th>Edit</th><th>Delete</th><th>Feedback </th><th>First Name</th><th>Last Name </th><th>Date of Feedback </th><th>Feedback Message </th></tr>";
        foreach (var item in data)
        {
            str += "<tr><td><a href=FeedbackEdit.aspx?id=" + item.Fid + ">Update</a></td><td>Delete</td><td>" + item.Uname + "</td><td>" + item.ULname + "</td><td>" + item.DOF + "</td><td>" + item.FMsg + "</td></tr>";
        }
        str += "</table>";
        display.InnerHtml = str;

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeedbackEdit.aspx");
    }
}