using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_UserTypeEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                btnutypesbmt.Text = "Update";
                var data = (from t in dc.UserTypes
                            where t.UtypeID.Equals(Request.QueryString["id"])
                            select t).ToList();
                if (data.Count == 1)
                {
                    txtUtypename.Text = data[0].Utypename;
                }
            }
            else
            {
                btnutypesbmt.Text = "Insert";
            }
        }
    }
    protected void btnutypesbmt_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["id"]))
        {
            //update
            dc.UserType_Update(int.Parse(Request.QueryString["id"]), txtUtypename.Text, true);
            Response.Redirect("UserTypeList.aspx");
        }
        {
            //insert
            dc.UserType_Insert(txtUtypename.Text, true);
            Response.Redirect("UserTypeList.aspx");
        }
    }
}