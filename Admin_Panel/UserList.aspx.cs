using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_UserList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {

        var data = (from ta in dc.Users
                    join tc in dc.UserTypes on ta.UtypeID equals tc.UtypeID
                    join tz in dc.Areas on ta.Aid equals tz.Aid
                    join td in dc.CityZones on tz.Zcid equals td.Zcid
                    join ts in dc.Zones on td.Zid equals ts.Zid
                    join tci in dc.Cities on td.Cid equals tci.Cid
                    select new {ta.Uid,tz.Aname,ts.Zname,tci.Cname,ta.Uname,ta.ULname,ta.Uph,ta.Uemailid,ta.Upassword,ta.ugender,tc.Utypename,ta.DOJ,ta.Lastseen,ta.Usphoto,ta.UAdd}).ToList();
        
         
        string str = "<table>";
        str += "<tr><th>Edit</th><th>Delete</th><th>User</th><th>First name</th><th>Last name</th><th>User Type</th><th>Email</th><th>Password</th><th>Address</th><th>Area</th><th>Zone</th><th>City</th><th>Phone Num</th><th>Gender</th><th>Photo</th><th>Date of Join</th><th>Last Seen</th></tr>";
        foreach (var item in data)
        {
            str += "<tr><td><a href=UserEdit.aspx?id=" + item.Uid + ">Update</a></td><td>Delete</td><td>" + item.Uname + "</td><td>" + item.ULname + "</td><td>" + item.Utypename + "</td><td>" + item.Uemailid + "</td><td>" + item.Upassword + "</td><td>" + item.UAdd + "</td><td>" + item.Aname + "</td><td>" + item.Zname + "</td><td>" + item.Cname + "</td><td>" + item.Uph + "</td><td>" + item.ugender + "</td><td>" + item.Usphoto + "</td><td>" + item.DOJ + "</td><td>" + item.Lastseen + "</td></tr>";
        }
        str += "</table>";
        display.InnerHtml = str;
    }
    protected void btnaradd_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserEdit.aspx");
    }
}