using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Edit_Dealer : System.Web.UI.Page
{
    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    PublicMethods clsPublic = new PublicMethods();

    protected void Page_Load(object sender, EventArgs e)
    {

        Page.Form.Attributes.Add("enctype", "multipart/form-data");


        if (!Page.IsPostBack)
        {

            //if (Context.User.Identity.IsAuthenticated == false)
            //{
            //    HttpContext.Current.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);
            //    FormsAuthentication.SignOut();
            //    Session.Abandon();
            //    Response.Redirect("Sign-In.aspx");
            //}
            GetData();

        }
    }


    private void Save()
    {

       // Dealer_Registration objK = new Dealer_Registration();

        Dealer_Registration objK;
        objK = dbJalagam.Dealer_Registrations.SingleOrDefault(obj => obj.Id == Convert.ToInt16(Request.QueryString["Id"]));

        objK.Dealer_Name = Convert.ToString(txtDealerName.Text);
        objK.Age = Convert.ToString(txtAge.Text);
        objK.Qualification = Convert.ToString(txtQualification.Text);
        objK.EmailId = Convert.ToString(txtEMailId.Text);
        objK.ContactNo = Convert.ToString(txtContactNo.Text);
        objK.City = Convert.ToString(txtCity.Text);
        objK.Currnet_Business = Convert.ToString(txtCurrentBusiness.Text);
        objK.FirmName = Convert.ToString(txtFirmName.Text);
        objK.Constitution = Convert.ToString(txtConstitution.Text);
        objK.CreatedDate = DateTime.Now;
        // objU.CreatedBy = Context.User.Identity.Name.ToString();

       // dbJalagam.Dealer_Registrations.InsertOnSubmit(objK);
        dbJalagam.SubmitChanges();
        clsPublic.ClearControls(Page.Controls);

        lblMsg.Text = "<div><i class='fa fa-check fa-2x'></i>" + "Updated Successfully" + "</div>";

    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        try
        {

            Save();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }


    private void GetData()
    {
        var objC = from objV in dbJalagam.Dealer_Registrations
                   where objV.Id == Convert.ToInt32(Request.QueryString["Id"])
                   select objV;
        Dealer_Registration objK = objC.SingleOrDefault();


        txtDealerName.Text = Convert.ToString(objK.Dealer_Name);
        txtAge.Text = Convert.ToString(objK.Age);
        txtContactNo.Text = Convert.ToString(objK.ContactNo);
        txtQualification.Text = Convert.ToString(objK.Qualification);
        txtEMailId.Text = Convert.ToString(objK.EmailId);

        txtCity.Text = Convert.ToString(objK.City);
        txtCurrentBusiness.Text = Convert.ToString(objK.Currnet_Business);
        txtFirmName.Text = Convert.ToString(objK.FirmName);
        txtConstitution.Text = Convert.ToString(objK.Constitution);


    }

}