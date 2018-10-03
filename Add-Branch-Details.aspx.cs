using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Add_Branch_Details : System.Web.UI.Page
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

        Branch_Detail objK = new Branch_Detail();

        //  objU.UserEmailId = Context.User.Identity.Name.ToString();

        objK.Branch_Name = Convert.ToString(txtBranchName.Text);
        objK.Address = Convert.ToString(txtAddress.Text);
        objK.ContactNumbers = Convert.ToString(txtContactNo.Text);
        objK.EmailId = Convert.ToString(txtEMailId.Text);
        objK.State = Convert.ToString(ddlState.SelectedValue);

        objK.CreatedDate = DateTime.Now;

        dbJalagam.Branch_Details.InsertOnSubmit(objK);
        dbJalagam.SubmitChanges();
        clsPublic.ClearControls(Page.Controls);

        lblMsg.Text = "<div><i class='fa fa-check fa-2x'></i>" + "Submitted Successfully" + "</div>";

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