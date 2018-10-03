using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Security.Principal;
public partial class Post_Ad : System.Web.UI.MasterPage
{
   // PublicMethods clsPublic = new PublicMethods();
	DcjalagamDataContext dbJalagam = new DcjalagamDataContext();

	protected void Page_Load(object sender, EventArgs e)
    {
  //      if (Context.User.Identity.IsAuthenticated == false)
  //      {
  //          HttpContext.Current.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);
  //          FormsAuthentication.SignOut();
  //          Session.Abandon();
  //          Response.Redirect("Sign-In.aspx");
  //      }
  //      else
  //      {
  //          bool blnOrg = true;

  //          blnOrg = clsPublic.ValidateUser(Context.User.Identity.Name.ToString());

  //          if (blnOrg == true)
  //          {

  //              LoginName loginName = HeadLoginView.FindControl("HeadLoginName") as LoginName;
  //              loginName.FormatString = clsPublic.GetUserName(Context.User.Identity.Name.ToString());
  //          }
  //          else
  //          {
  //              HttpContext.Current.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);
  //              FormsAuthentication.SignOut();
  //              Session.Abandon();
  //              Response.Redirect("Sign-In.aspx");
  //          }

  //      }
		//GetRoommates();

	}

}
