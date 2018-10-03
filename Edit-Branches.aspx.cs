using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Edit_Branches : System.Web.UI.Page
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

        //  Branch_Detail objK = new Branch_Detail();
        Branch_Detail objK;
        objK = dbJalagam.Branch_Details.SingleOrDefault(obj => obj.Branch_Id == Convert.ToInt16(Request.QueryString["Id"]));

        objK.Branch_Name = Convert.ToString(txtBranchName.Text);
        objK.Address = Convert.ToString(txtAddress.Text);
        objK.ContactNumbers = Convert.ToString(txtContactNo.Text);
        objK.EmailId = Convert.ToString(txtEMailId.Text);
        objK.State = Convert.ToString(ddlState.SelectedValue);

        objK.CreatedDate = DateTime.Now;

       
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
        var objC = from objV in dbJalagam.Branch_Details
                   where objV.Branch_Id == Convert.ToInt32(Request.QueryString["Id"])
                   select objV;
        Branch_Detail objK = objC.SingleOrDefault();


        txtAddress.Text = Convert.ToString(objK.Address);
        txtBranchName.Text = Convert.ToString(objK.Branch_Name);
        txtContactNo.Text = Convert.ToString(objK.ContactNumbers);
        txtEMailId.Text = Convert.ToString(objK.EmailId);
        ddlState.SelectedValue = Convert.ToString(objK.State);
      
    }


}