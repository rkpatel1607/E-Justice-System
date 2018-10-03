using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_UserTypeList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        var data = (from t in dc.UserTypes select t).ToList();
        string str = "<table>";
        str += "<tr><th>Edit</th><th>Delete</th><th>User</th></tr>";
        foreach (var item in data)
        {
            str += "<tr><td><a href=UserTypeEdit.aspx?id=" + item.UtypeID + ">Update</a></td><td>Delete</td><td>" + item.Utypename + "</td></tr>";
        }
        str += "</table>";
        display.InnerHtml = str;

    }
    protected void btnUTAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserTypeEdit.aspx");

    }
}