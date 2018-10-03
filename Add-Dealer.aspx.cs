using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Add_Dealer : System.Web.UI.Page
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

        }
    }


    private void Save()
    {

        Dealer_Registration objK = new Dealer_Registration();

        //  objU.UserEmailId = Context.User.Identity.Name.ToString();

        objK.Dealer_Name = Convert.ToString(txtDealerName.Text);
        //objK.Age = Convert.ToString(txtAge.Text);
       // objK.Qualification = Convert.ToString(txtQualification.Text);
       // objK.EmailId = Convert.ToString(txtEMailId.Text);
        objK.ContactNo = Convert.ToString(txtContactNo.Text);
       // objK.City = Convert.ToString(txtCity.Text);
       // objK.Currnet_Business = Convert.ToString(txtCurrentBusiness.Text);
       // objK.FirmName = Convert.ToString(txtFirmName.Text);
       // objK.Constitution = Convert.ToString(txtConstitution.Text);
        objK.CreatedDate = DateTime.Now;
       // objU.CreatedBy = Context.User.Identity.Name.ToString();
       
        dbJalagam.Dealer_Registrations.InsertOnSubmit(objK);
        dbJalagam.SubmitChanges();
        clsPublic.ClearControls(Page.Controls);
        lblMsg.Text = "<div><i class='fa fa-check fa-2x'></i>" + "Details Submitted Successfully" + "</div>";

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

}