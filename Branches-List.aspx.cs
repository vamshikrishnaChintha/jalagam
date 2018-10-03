using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Branches_List : System.Web.UI.Page
{

    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

        if(!Page.IsPostBack)
        {
           
                BindBranches(Request.QueryString["S"]);
           

            if(Request.QueryString["S"]=="AP")
            {
                divTS.Visible = false;
                divAP.Visible = true;
            }
           else if (Request.QueryString["S"] == "TS")
            {
                divTS.Visible = true;
                divAP.Visible = false;
            }

        }

    }


    private void BindBranches(string state)
    {

        gvBranches.DataSource = GetBranches(state);
        gvBranches.DataBind();
    }


    private IQueryable GetBranches(string state)
    {
        var objC = from objV in dbJalagam.Branch_Details
                   where objV.State==Convert.ToString(state)
                   orderby objV.Branch_Id ascending
                   select new
                   {
                       Id = objV.Branch_Id,
                       Name = objV.Branch_Name,
                       Address= objV.Address,
                       ContactNo= "<i class='fas fa-phone-volume'></i> " + objV.ContactNumbers,
                       EmailId= "<i class='far fa-envelope'></i> " + objV.EmailId
                     

                   };

        return objC;
    }


    private void BindBranches()
    {

        gvBranches.DataSource = GetBranches();
        gvBranches.DataBind();
    }


    private IQueryable GetBranches()
    {
        var objC = from objV in dbJalagam.Branch_Details
                  
                   orderby objV.CreatedDate descending
                   select new
                   {
                       Id = objV.Branch_Id,
                       Name = objV.Branch_Name,
                       Address = objV.Address,
                       ContactNo = "<i class='fas fa-phone-volume'></i> " + objV.ContactNumbers,
                       EmailId = "<i class='far fa-envelope'></i> " + objV.EmailId


                   };

        return objC;
    }
}