using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Branch_Details : System.Web.UI.Page
{

    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            GetData();
        }
    }

    private void GetData()
    {
        var objC = from objV in dbJalagam.Branch_Details
                   where objV.Branch_Id == Convert.ToInt32(Request.QueryString["Id"])
                   select objV;
        Branch_Detail objK = objC.SingleOrDefault();

        lblAddress.Text = Convert.ToString(objK.Address);
        lblBranchName.Text = Convert.ToString(objK.Branch_Name);
        lblContactNumbers.Text = Convert.ToString(objK.ContactNumbers);
        lblEmailId.Text = Convert.ToString(objK.EmailId);
    

    }

}