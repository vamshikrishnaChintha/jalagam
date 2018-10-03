using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dealer_Details : System.Web.UI.Page
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
        var objC = from objV in dbJalagam.Dealer_Registrations
                   where objV.Id == Convert.ToInt32(Request.QueryString["Id"])
                   select objV;
        Dealer_Registration objK = objC.SingleOrDefault();


        lblAge.Text = Convert.ToString(objK.Age);
        lblCity.Text = Convert.ToString(objK.City);
        lblConsitution.Text = Convert.ToString(objK.Constitution);
        lblCurrentBusiness.Text = Convert.ToString(objK.Currnet_Business);
        lblContactNo.Text = Convert.ToString(objK.ContactNo);
        lblDealerName.Text = Convert.ToString(objK.Dealer_Name);
        lblEMailId.Text = Convert.ToString(objK.EmailId);
        lblFirmName.Text = Convert.ToString(objK.FirmName);
        lblQualification.Text = Convert.ToString(objK.Qualification);

    }


}