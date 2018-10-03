using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Text;

using System.Security.Principal;
public partial class Account_Login : System.Web.UI.Page
{

  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            this.Form.DefaultButton = this.btnSignIn.UniqueID;





        }
       



    }

    protected void btnSignIn_Click(object sender, EventArgs e)
    {



       // bool blnOrg = true;

        //blnOrg = clsPublicMethods.ValidateUser(Convert.ToString(txtUserId.Text), Convert.ToString(txtPwd.Text));
    if (txtUserId.Text == Convert.ToString("admin@jalagam.com") && txtPwd.Text == Convert.ToString("admin@12345"))
        {
            FormsAuthentication.SetAuthCookie(txtUserId.Text.Trim(), false);

            FormsAuthenticationTicket ticketUser = new FormsAuthenticationTicket(1, txtUserId.Text.Trim(), DateTime.Now, DateTime.Now.AddDays(2), true, "User");
            HttpCookie cookieUser = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticketUser));
           
          //  HttpContext.Current.Response.Cookies["JUser"].Expires = DateTime.Now.AddDays(2);


          
          //  cookieUser.Domain = ".jhalak.com";
          
                Response.Redirect("Dashboard.aspx");
        
        }
        else
        {
            lblSignin.Text = " <div style='color:red;'>" + "Please Enter Valid Credentials" + "</div>";
            return;
        }
    }

  

   


}