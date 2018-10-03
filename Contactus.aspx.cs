using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contactus : System.Web.UI.Page
{
    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    PublicMethods clsPublic = new PublicMethods();

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {

        }


    }
    private void Save()
    {

        Contact_Us objK = new Contact_Us();

        //  objU.UserEmailId = Context.User.Identity.Name.ToString();

        objK.Name = Convert.ToString(txtName.Text);
        objK.EmailId = Convert.ToString(txtEmailId.Text);
        objK.Description = Convert.ToString(txtReason.Text);
        objK.ContactNumber = Convert.ToString(txtPhoneNumber.Text);
     
        objK.CreatedDate = DateTime.Now;
        

        dbJalagam.Contact_Us.InsertOnSubmit(objK);
        dbJalagam.SubmitChanges();
        clsPublic.ClearControls(Page.Controls);

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