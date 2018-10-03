using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_LawEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                btnSubmit.Text = "Update";
                var data = (from t in dc.Laws
                            where t.Lid.Equals(Request.QueryString["id"])
                            select t).ToList();
                if (data.Count == 1)
                {
                    Ddlawtype.Text = data[0].Ltype;
                    txttitle.Text = data[0].Ltitle;
                    txttitle.Text = data[0].Ldescription;
                }
            }
            else
            {
                btnSubmit.Text = "Insert";
            }
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["id"]))
        {
            //update
            dc.Law_Update(int.Parse(Request.QueryString["id"]),Ddlawtype.Text,txttitle.Text,txtdesc.Text,true);
            Response.Redirect("LawList.aspx");
        }
        {
            //insert
            dc.Law_Insert(Ddlawtype.Text,txttitle.Text,txtdesc.Text,true);
            Response.Redirect("LawList.aspx");
        }
    }
}