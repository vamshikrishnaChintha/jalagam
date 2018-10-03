using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test_Drive_Details : System.Web.UI.Page
{
    DcjalagamDataContext dbJalagam =new DcjalagamDataContext();
         
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            GetData();
        }
    }


    private void GetData()
    {
        var objC = from objV in dbJalagam.Test_Driving_Dets
                   where objV.Id == Convert.ToInt32(Request.QueryString["Id"])
                   select objV;
        Test_Driving_Det objK = objC.SingleOrDefault();
        
        lblAddress.Text = Convert.ToString(objK.Address);
        lblProductCode.Text = Convert.ToString(objK.Product_Master.ProductName);
        lblContactNo.Text = Convert.ToString(objK.ContactNo);
        lblEmailId.Text = Convert.ToString(objK.EmailId);
        lblName.Text = Convert.ToString(objK.Name);

    }

}