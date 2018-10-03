using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Add_Test_Driving : System.Web.UI.Page
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
            getProductType();

        }
    }



    private void Save()
    {

        Test_Driving_Det objU = new Test_Driving_Det();

        //  objU.UserEmailId = Context.User.Identity.Name.ToString();

        objU.Name = Convert.ToString(txtName.Text);
        objU.Address = Convert.ToString(txtAddress.Text);
        objU.ContactNo = Convert.ToString(txtContactNo.Text);
        objU.EmailId = Convert.ToString(txtEmailId.Text);
        objU.ProductCode = Convert.ToString(ddlProductCode.SelectedValue);
        objU.CreateDate = DateTime.Now;

        // objU.CreatedBy = Context.User.Identity.Name.ToString();

        dbJalagam.Test_Driving_Dets.InsertOnSubmit(objU);
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

    private void getProductType()
    {

        clsPublic.FillDropDownList(getProductCode(), ddlProductCode);
       ddlProductCode.Items.Insert(0, new ListItem("--- Select ---", "--- Select ---"));
    }
    public IQueryable getProductCode()
    {

        var objRecipetype = from objType in dbJalagam.Product_Masters
                           orderby objType.Id ascending
                            select new

                            {
                                Text = objType.ProductName,
                                Value = objType.Prodcut_Code
                            };

        return objRecipetype;


    }



}