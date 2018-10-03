using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_NewsList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        var data = (from t in dc.News select t).ToList();
        string str = "<table>";
        str += "<tr><th>Edit</th><th>Delete</th><th>News</th></tr>";
        foreach (var item in data)
        {
            str += "<tr><td><a href=NewsEdit.aspx?id=" + item.Nid + ">Update</a></td><td>Delete</td><td>" + item.NDate + "</td><td>" + item.NTitle + "</td><td>" + item.NDescp + "</td><td>" + item.NImg + "</td></tr>";
        }
        str += "</table>";
        display.InnerHtml = str;

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewsEdit.aspx");
    }
}