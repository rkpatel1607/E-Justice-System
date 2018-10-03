using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Member_Panel_DailyNews : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

        lbldate.Text = (System.DateTime.Now.Date).ToString();
        var data = (from t in dc.News
                    where t.NDate  == Convert.ToDateTime(lbldate.Text)
                    select t).ToList();
        string str = "<table>";
        str += "<tr><th>Edit</th><th>Delete</th><th>Daily News</th></tr>";
        foreach (var item in data)
        {
            str += "<tr><td>" + item.Nid + ">Update</td></td><td>Delete</td><td>" + item.NTitle + "</td><td>" + item.NDescp + "</td><td>" + item.NImg + "</td></tr>";
        }
        str += "</table>";
        Display.InnerHtml = str;
    }
}