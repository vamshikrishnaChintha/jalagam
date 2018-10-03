using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Edit_Test_Drice : System.Web.UI.Page
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
            GetData();

        }
    }



    private void Save()
    {

        //Test_Driving_Det objU = new Test_Driving_Det();
        Test_Driving_Det objK;
        objK = dbJalagam.Test_Driving_Dets.SingleOrDefault(obj => obj.Id == Convert.ToInt16(Request.QueryString["Id"]));
     

        objK.Name = Convert.ToString(txtName.Text);
        objK.Address = Convert.ToString(txtAddress.Text);
        objK.ContactNo = Convert.ToString(txtContactNo.Text);
        objK.EmailId = Convert.ToString(txtEmailId.Text);
        objK.ProductCode = Convert.ToString(ddlProductCode.SelectedValue);
        objK.CreateDate = DateTime.Now;

        // objU.CreatedBy = Context.User.Identity.Name.ToString();

       // dbJalagam.Test_Driving_Dets.InsertOnSubmit(objK);
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



    private void GetData()
    {
        var objC = from objV in dbJalagam.Test_Driving_Dets
                   where objV.Id == Convert.ToInt32(Request.QueryString["Id"])
                   select objV;
        Test_Driving_Det objK = objC.SingleOrDefault();


        ddlProductCode.SelectedValue = Convert.ToString(objK.ProductCode);
        txtName.Text = Convert.ToString(objK.Name);
        txtContactNo.Text = Convert.ToString(objK.ContactNo);
        txtEmailId.Text = Convert.ToString(objK.EmailId);
        txtAddress.Text = Convert.ToString(objK.Address);
      

    }

}