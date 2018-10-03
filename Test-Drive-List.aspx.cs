using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test__Drive_List : System.Web.UI.Page
{
    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

        if(!Page.IsPostBack)
        {
            BindTestDrive();
        }
    }
    private void BindTestDrive()
    {

        gvTestDrive.DataSource = GetTestDriving();
        gvTestDrive.DataBind();
    }

    private IQueryable GetTestDriving()
    {
        var objC = from objV in dbJalagam.Test_Driving_Dets

                   orderby objV.Id descending
                   select new
                   {
                       Id = objV.Id,
                       Title = objV.Name,
                       ContactNo=objV.ContactNo,
                       Address = objV.Address,


                   };

        return objC;
    }
}