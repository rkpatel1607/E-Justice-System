using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_CrimeTypeList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        var data = (from t in dc.CrimeTypes select t).ToList();
        string str = "<table>";
        str += "<tr><th>Edit</th><th>Delete</th><th>Crime Type</th></tr>";
        foreach (var item in data)
        {
            str += "<tr><td><a href=CrimeTypeEdit.aspx?id=" + item.CrimeTypeId + ">Update</a></td><td>Delete</td><td>" + item.CTName + "</td></tr>";
        }
        str += "</table>";
        display.InnerHtml = str;
    }
    protected void btnctadd_Click(object sender, EventArgs e)
    {
        Response.Redirect("CrimeTypeEdit.aspx");
    }
}