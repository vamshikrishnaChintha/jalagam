using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Summary description for News_Letter
/// </summary>
public class News_Letter
{
    StringBuilder htmlString = new StringBuilder();
    public News_Letter()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string HeaderHTML(string strPageTitle)
    {
        htmlString.AppendLine("<!DOCTYPE html PUBLIC ' -//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'" + ">)");
        htmlString.AppendLine("<html xmlns='http://www.w3.org/1999/xhtml'" + ">");
        htmlString.AppendLine("<head>< meta http - equiv = 'Content-Type' content = 'text/html; charset=utf-8' />");
        htmlString.AppendLine("< title >" + strPageTitle + "</ title >");
        htmlString.AppendLine("meta name = 'viewport' content = 'width=device-width, initial-scale=1.0'" + "/> ");
        htmlString.AppendLine("< script type = 'text/javascript' src = 'http://cricket.jhalak.com/js/jquery.min.js' ></ script >");
        htmlString.AppendLine("<script type='text / javascript' src='http://cricket.jhalak.com/js/bootstrap.min.js'></script>");
        htmlString.AppendLine("<link rel='stylesheet' href='http://cricket.jhalak.com/css/bootstrap.min.css' type='text / css'" + " />");
        htmlString.AppendLine("<link rel='Stylesheet' href='http://cricket.jhalak.com/font-awesome/css/font-awesome.min.css' type='text / css'" + "/>");
        htmlString.AppendLine("<style type='text / css'>");
        htmlString.AppendLine(" div ul li{list-style-type:none; display:inline; text-align:right; margin:10px;}");
        htmlString.AppendLine(" div ul li a{color:#fff;}");
        htmlString.AppendLine("</style>");
        htmlString.AppendLine("</head>");
        return htmlString.ToString();


    }
    public string UserAcknowledgement(string strUserName)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + strUserName + "</h2>");
        htmlString.AppendLine("<div style='font-weight: bold;'>Welcome to Jhalak.com, an account has been created.</div>");
     
        htmlString.AppendLine("<div style='margin-top:20px;'><i>You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div>");
        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you,</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>http://jhalak.com</a></div>");
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }
    public string UserAcknowledgement(string strUserName, string strURL)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://www.jhalak.com/images/user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + strUserName + "</h2>");
        //htmlString.AppendLine("<div style='font-weight: bold;'>Welcome to Jhalak.com, an account has been created.</div>");
        htmlString.AppendLine(" <div>Please click the below button to verify your account. This will help you to see all your Ads.</div>");
        htmlString.AppendLine(" <div> You won’t be asked to log in as it’s simply a verification of the ownership of this email address.</div>");
        
        htmlString.AppendLine("<div style='margin:10px'><a href='" + strURL + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Verify Email</a></div>");
        //htmlString.AppendLine(" You login credentials :<br>");
        //htmlString.AppendLine(" User Name: your mail id<br>");
        //htmlString.AppendLine(" Password: saibaba" + "<br>");
        //htmlString.AppendLine(" Note:Please reset your password once you login <br>");
        //htmlString.AppendLine("<div>This step is required to confirm/ validate the email you entered. A valid email address is needed to contact you in future and assist you in case you forget your username and password. </div>");
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div>");
        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
        //htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Team Jhalak</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://www.jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://cricket.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://cricket.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://cricket.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://cricket.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }



    public string PostRaffleConfirmation(string strName, string userId, string strRaffle)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/jhalak-raffle-email-banner.jpg); background-repeat:no-repeat;height:300px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + strName + "</h2>");
        htmlString.AppendLine("<div style='font-weight: bold;'>Welcome to Jhalak.com, your Raffle has been Submitted Successfully.</div>");
        htmlString.AppendLine(" <div> Your Raffle Number is : " + strRaffle + " </div><br>");
        //htmlString.AppendLine(" <div>Congratulations! Your Ad is now visible on Jhalak.com.</div><br>");
        //htmlString.AppendLine(" <div>Ad Title: "+strAdTitle+"</div><br>");
        //htmlString.AppendLine(" <div>It Will Expire On: </div><br>");
        htmlString.AppendLine(" <div>Thank you for participating in the Jhalak Raffle</div><br>");
        htmlString.AppendLine(" <div><h4><b>Draw is on 8th July</b></h4></div><br>");
        htmlString.AppendLine(" <div>To Know if you are a winner <br>,  Please visit the <a href='http://jhalak.com/raffle.aspx'> http://jhalak.com/raffle.aspx </a>  </div><br>");


        //htmlString.AppendLine("<div> You can view, edit,and delete Operations. </div> <br>");
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>Thank you for using Jhalak.com , Jhalak and good luck with your Post! Remember, Jhalak is the best place for you.<br>");

        htmlString.AppendLine("You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div><br>");

        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px; text-align:center'>Thank you,</div>");
        htmlString.AppendLine(" <div style='margin:10px ; text-align:center'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        //htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://Entertainment.jhalak.com/images/fb-icon.png' /></a></li>");
        //htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://Entertainment.jhalak.com/images/g-icon.png' /></a></li>");
        //htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://Entertainment.jhalak.com/images/tw-icon.png' /><a></li>");
        //htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://Entertainment.jhalak.com/images/pin-icon.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }


    public string UserConfirmAcknowledgement(string strUserName, string strUserId,string strpwd)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://www.jhalak.com/images/user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + strUserName + "</h2>");
        //htmlString.AppendLine("<div style='font-weight: bold;'>Welcome to Jhalak.com, an account has been created.</div>");
        htmlString.AppendLine(" <div>Thank you for using Jhalak.com. Your account has been created successfully. Wait for the Jhalak Approval</div>"); 
         htmlString.AppendLine("<div>In this email you will find your account details.</div>");
         htmlString.AppendLine("<div>Keep these details handy and use this to access your account anytime, from anywhere.</div>");
        htmlString.AppendLine("<div style='margin-top:20px;'><i>Account Details:</i></div>");
        htmlString.AppendLine("<div style='margin-top:20px;'><i>Username :"+strUserId+" </i></div>");
        htmlString.AppendLine("<div style='margin-top:20px;'><i>Password :" + strpwd + " </i></div>");
        //htmlString.AppendLine("<div style='margin:10px'><a href='" + strURL + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Click  here to activate your account</a></div>");
        //htmlString.AppendLine(" You login credentials :<br>");
        //htmlString.AppendLine(" User Name: your mail id<br>");
        //htmlString.AppendLine(" Password: saibaba" + "<br>");
        //htmlString.AppendLine(" Note:Please reset your password once you login <br>");
        //htmlString.AppendLine("<div>This step is required to confirm/ validate the email you entered. A valid email address is needed to contact you in future and assist you in case you forget your username and password. </div>");
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div>");
        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
        //htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Team Jhalak</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://www.jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://cricket.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://cricket.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://cricket.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://cricket.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }

	public string UserApproval(string strUserName, string strUserId)
	{

		htmlString.AppendLine("<body style='font-family: arial!important'>");
		htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
		htmlString.AppendLine("<tr>");
		htmlString.AppendLine("<td>");
		htmlString.AppendLine("<table style='max-width:100%'>");
		htmlString.AppendLine("<tr>");
		htmlString.AppendLine("<td style='background-image:url(http://www.jhalak.com/images/user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
		htmlString.AppendLine(" </tr>");
		htmlString.AppendLine("</table>");
		htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
		htmlString.AppendLine(" <tr>");
		htmlString.AppendLine("<td>");
		htmlString.AppendLine("<div style='text-align: center;'>");
		htmlString.AppendLine("<h2>Hello " + strUserName + "</h2>");
		//htmlString.AppendLine("<div style='font-weight: bold;'>Welcome to Jhalak.com, an account has been created.</div>");
		htmlString.AppendLine(" <div>Thank you for using Jhalak.com. Your account has been Approved by Jhalak.</div>");
		htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com/Sign-In.aspx' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Click to Login</a></div>");
		//htmlString.AppendLine("<div>In this email you will find your account details.</div>");
		//htmlString.AppendLine("<div>Keep these details handy and use this to access your account anytime, from anywhere.</div>");
		//htmlString.AppendLine("<div style='margin-top:20px;'><i>Account Details:</i></div>");
		//htmlString.AppendLine("<div style='margin-top:20px;'><i>Username :" + strUserId + " </i></div>");
		//htmlString.AppendLine("<div style='margin-top:20px;'><i>Password :" + strpwd + " </i></div>");

		//htmlString.AppendLine("<div style='margin:10px'><a href='" + strURL + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Click  here to activate your account</a></div>");
		//htmlString.AppendLine(" You login credentials :<br>");
		//htmlString.AppendLine(" User Name: your mail id<br>");
		//htmlString.AppendLine(" Password: saibaba" + "<br>");
		//htmlString.AppendLine(" Note:Please reset your password once you login <br>");
		//htmlString.AppendLine("<div>This step is required to confirm/ validate the email you entered. A valid email address is needed to contact you in future and assist you in case you forget your username and password. </div>");
		//htmlString.AppendLine("<div style='margin-top:20px;'><i>You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div>");
		htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
		//htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Team Jhalak</div>");
		htmlString.AppendLine(" <div style='margin:10px'><a href='http://www.jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
		htmlString.AppendLine(" </div>");
		htmlString.AppendLine("</td>");
		htmlString.AppendLine("</tr>");
		htmlString.AppendLine("<tr>");
		htmlString.AppendLine("<td >");
		htmlString.AppendLine("<div style='text-align:center'>");
		htmlString.AppendLine("<ul style='margin-left:-40px'>");
		htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://cricket.jhalak.com/images/fb-nl.png' /></a></li>");
		htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://cricket.jhalak.com/images/g-plus-nl.png' /></a></li>");
		htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://cricket.jhalak.com/images/tw-nl.png' /><a></li>");
		htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://cricket.jhalak.com/images/pin-nl.png' /></a></li>");
		htmlString.AppendLine(" </ul>");
		htmlString.AppendLine("</div>");
		htmlString.AppendLine("</td>");
		htmlString.AppendLine("</tr>");
		htmlString.AppendLine("</table>");
		htmlString.AppendLine("</td>");
		htmlString.AppendLine("</tr>");
		htmlString.AppendLine("</table>");
		htmlString.AppendLine("</body>");


		return htmlString.ToString();
	}

	public string UserChangePassword(string strUserName,string date)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://www.jhalak.com/images/user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + strUserName + "</h2>");
        //htmlString.AppendLine("<div style='font-weight: bold;'>Welcome to Jhalak.com, an account has been created.</div>");
        htmlString.AppendLine(" <div>Your password has been updated on " +date +"</div>");
        htmlString.AppendLine(" <div>Please sign in Jhalak.com with your updated password.</div>");
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>Account Details:</i></div>");
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>Username :" + strUserId + " </i></div>");
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>Password :" + strpwd + " </i></div>");
        //htmlString.AppendLine("<div style='margin:10px'><a href='" + strURL + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Click  here to activate your account</a></div>");
        //htmlString.AppendLine(" You login credentials :<br>");
        //htmlString.AppendLine(" User Name: your mail id<br>");
        //htmlString.AppendLine(" Password: saibaba" + "<br>");
        //htmlString.AppendLine(" Note:Please reset your password once you login <br>");
        //htmlString.AppendLine("<div>This step is required to confirm/ validate the email you entered. A valid email address is needed to contact you in future and assist you in case you forget your username and password. </div>");
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div>");
        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
        //htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Team Jhalak</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://www.jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://cricket.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://cricket.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://cricket.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://cricket.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }


    //public string UserChangePassword1(string strUserName, string strUrl)
    //{

    //    htmlString.AppendLine("<body style='font-family: arial!important'>");
    //    htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
    //    htmlString.AppendLine("<tr>");
    //    htmlString.AppendLine("<td>");
    //    htmlString.AppendLine("<table style='max-width:100%'>");
    //    htmlString.AppendLine("<tr>");
    //    htmlString.AppendLine("<td style='background-image:url(http://www.jhalak.com/images/cric-banner-c.png); background-repeat:no-repeat;height:222px;width:600px'></td>");
    //    htmlString.AppendLine(" </tr>");
    //    htmlString.AppendLine("</table>");
    //    htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
    //    htmlString.AppendLine(" <tr>");
    //    htmlString.AppendLine("<td>");
    //    htmlString.AppendLine("<div style='text-align: center;'>");
    //    htmlString.AppendLine("<h2>Hello " + strUserName + "</h2>");
    //    //htmlString.AppendLine("<div style='font-weight: bold;'>Welcome to Jhalak.com, an account has been created.</div>");
    //    htmlString.AppendLine(" <div>Please click ‘Change Password’ to set a new password on Jhalak</div>");
    //    htmlString.AppendLine("<div style='margin:10px'><a href='" + strUrl + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Change Password</a></div>");

    //    htmlString.AppendLine(" <div>If clicking “Change Password” does not work, please click-on this URL or copy and paste it into your browser:</div>");
    //    htmlString.AppendLine(" <div>"+strUrl+"</div>");

    //    //htmlString.AppendLine("<div style='margin-top:20px;'><i>Account Details:</i></div>");
    //    //htmlString.AppendLine("<div style='margin-top:20px;'><i>Username :" + strUserId + " </i></div>");
    //    //htmlString.AppendLine("<div style='margin-top:20px;'><i>Password :" + strpwd + " </i></div>");
    //    //htmlString.AppendLine("<div style='margin:10px'><a href='" + strURL + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Click  here to activate your account</a></div>");
    //    //htmlString.AppendLine(" You login credentials :<br>");
    //    //htmlString.AppendLine(" User Name: your mail id<br>");
    //    //htmlString.AppendLine(" Password: saibaba" + "<br>");
    //    //htmlString.AppendLine(" Note:Please reset your password once you login <br>");
    //    //htmlString.AppendLine("<div>This step is required to confirm/ validate the email you entered. A valid email address is needed to contact you in future and assist you in case you forget your username and password. </div>");
    //    //htmlString.AppendLine("<div style='margin-top:20px;'><i>You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div>");
    //    htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
    //    htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Team Jhalak</div>");
    //    //htmlString.AppendLine(" <div style='margin:10px'><a href='http://www.jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>http://www.jhalak.com</a></div>");
    //    htmlString.AppendLine(" </div>");
    //    htmlString.AppendLine("</td>");
    //    htmlString.AppendLine("</tr>");
    //    htmlString.AppendLine("<tr>");
    //    htmlString.AppendLine("<td >");
    //    htmlString.AppendLine("<div style='text-align:center'>");
    //    htmlString.AppendLine("<ul style='margin-left:-40px'>");
    //    htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://cricket.jhalak.com/images/fb-nl.png' /></a></li>");
    //    htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://cricket.jhalak.com/images/g-plus-nl.png' /></a></li>");
    //    htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://cricket.jhalak.com/images/tw-nl.png' /><a></li>");
    //    htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://cricket.jhalak.com/images/pin-nl.png' /></a></li>");
    //    htmlString.AppendLine(" </ul>");
    //    htmlString.AppendLine("</div>");
    //    htmlString.AppendLine("</td>");
    //    htmlString.AppendLine("</tr>");
    //    htmlString.AppendLine("</table>");
    //    htmlString.AppendLine("</td>");
    //    htmlString.AppendLine("</tr>");
    //    htmlString.AppendLine("</table>");
    //    htmlString.AppendLine("</body>");


    //    return htmlString.ToString();
    //}
    public string PostAdConfirmation(string strUserName, string strAdTitle, string userId, Int16 intAdId)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/business-user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + strUserName + "</h2>");
        htmlString.AppendLine("<div style='font-weight: bold;'>Welcome to Jhalak.com, Your Ad has been posted successfully.</div>");
        htmlString.AppendLine(" <div>Thanks for posting your Ad.  Title : " + strAdTitle + " Ad Id: " + intAdId + " In www.Jhalak.com:</div><br>");
        //htmlString.AppendLine(" <div>Congratulations! Your Ad is now visible on Jhalak.com.</div><br>");
        //htmlString.AppendLine(" <div>Ad Title: "+strAdTitle+"</div><br>");
        //htmlString.AppendLine(" <div>It Will Expire On: </div><br>");
        htmlString.AppendLine(" <div>Thanks</div><br>");


       htmlString.AppendLine("<div> You can view, edit, delete and check responses for all your ads by using My Account . </div> <br>");
       htmlString.AppendLine("<div style='margin-top:20px;'><i>Thank you for using Jhalak and good luck with your Ad!.Be Assured, Jhalak.com is the complete solution for all your local needs.<br>");
            
       htmlString.AppendLine("You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div><br>");

        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you,</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://cricket.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://cricket.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://cricket.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://cricket.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }

    public string AdVisibleAck(string strUserName, string strAdTitle, string emailId,string userAdId,string date,string SId)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/business-user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + strUserName + "</h2>");
        //htmlString.AppendLine("<div style='font-weight: bold;'>Welcome to Jhalak.com, your ad posted successfully.</div>");
        //htmlString.AppendLine(" <div>Thanks for posting your Ad Title : " + strAdTitle + " Ad Id: " + intAdId + " In www.Jhalak.com:</div><br>");
        htmlString.AppendLine(" <div>Congratulations! Your Ad is now live on Jhalak.com.</div><br>");
        htmlString.AppendLine(" <div>Ad Title : "+strAdTitle+"</div><br>");
        htmlString.AppendLine(" <div>It will expire on: "+ date+" </div><br>");
        htmlString.AppendLine(" <div style='margin:10px'><a href=" + "'" + "http://jhalak.com/Ad-Detail.aspx?AId=" + userAdId + "&SId=" + SId + "'" + " style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>View Your Ad</a></div>");
        //htmlString.AppendLine(" <div>Thank You</div><br>");
        htmlString.AppendLine(" <div><a href='http://jhalak.com/Sign-In.aspx'>Edit Your Ad </a></div><br>");
        htmlString.AppendLine(" <div><a href='http://jhalak.com/Sign-In.aspx'>Delete Your Ad </a></div><br>");
        //htmlString.AppendLine("<div> You can view, edit, delete and check replies to all your ads by using My Account . </div> <br>");
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>Thank you for using Jhalak and good luck with your ad! Remember, Jhalak is the best place for you.<br>");

        //htmlString.AppendLine("You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div><br>");

        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you,</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
        htmlString.AppendLine("<div style='font-weight: bold;'>Premium Ads give your ad more visibility</div>");
        htmlString.AppendLine(" <div><a href='http://jhalak.com/Sign-In.aspx'>Upgrade To Premium </a></div><br>");

        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://cricket.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://cricket.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://cricket.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://cricket.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }


    public string RejectAdAck(string strUserName, string emailId)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/business-user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + strUserName + "</h2>");
        htmlString.AppendLine("<div style='font-weight: bold;'>Your ad contains prohibited item or content.</div>");
        //htmlString.AppendLine(" <div>Thanks for posting your Ad Title : " + strAdTitle + " Ad Id: " + intAdId + " In www.Jhalak.com:</div><br>");
        htmlString.AppendLine(" <div>At Jhalak.com, for legal and ethical reasons, we do not allow post certain content in our Ads. </div><br>");
        htmlString.AppendLine(" <div>This policy ensures all our users have a safe, secure and delightful experience.</div><br>");
        htmlString.AppendLine(" <div>1.	Drugs, weapons, and items of an obscene or erotic nature. </div><br>");
        htmlString.AppendLine(" <div>2.	Cigarettes, tobacco products and alcoholic beverages.</div><br>");
        htmlString.AppendLine(" <div>3.	Pharmaceutical products, medical devices that are under government regulation.</div><br>");
        htmlString.AppendLine(" <div>4.	Human organs or any other human parts.</div><br>");
        htmlString.AppendLine(" <div>5.	Stolen goods, hacked or pirated goods, robbery or other services considered criminal</div><br>");
        htmlString.AppendLine(" <div>6.	Goods that do not exist or that you do not own.</div><br>");
        htmlString.AppendLine(" <div>7.	Animals that are protected by law.</div><br>");
        htmlString.AppendLine(" <div>8.	Paid sexual services.</div><br>");
        htmlString.AppendLine(" <div>9.	Services that offer writing of thesis or master's papers or any falsification of documents.</div><br>");
        htmlString.AppendLine("<div style='font-weight: bold;'>Please review our Terms of Use for complete posting rules and information.</div>");
        //htmlString.AppendLine(" <div style='margin:10px'><a href=" + "'" + "http://jhalak.com/Ad-Detail.aspx?AId=" + userAdId + "&SId=" + SId + "'" + " style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>View Your Ad</a></div>");
        //htmlString.AppendLine(" <div>Thank You</div><br>");
        //htmlString.AppendLine(" <div><a href='http://jhalak.com/Sign-In.aspx'>Edit Your Ad </a></div><br>");
        //htmlString.AppendLine(" <div><a href='http://jhalak.com/Sign-In.aspx'>Delete Your Ad </a></div><br>");
        //htmlString.AppendLine("<div> You can view, edit, delete and check replies to all your ads by using My Account . </div> <br>");
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>Thank you for using Jhalak and good luck with your ad! Remember, Jhalak is the best place for you.<br>");

        //htmlString.AppendLine("You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div><br>");

        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
        //htmlString.AppendLine("<div style='font-weight: bold;'>Premium Ads give your ad more visibility</div>");
        //htmlString.AppendLine(" <div><a href='http://jhalak.com/Sign-In.aspx'>Upgrade To Premium </a></div><br>");

        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://cricket.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://cricket.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://cricket.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://cricket.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }

    public string RejectUser(string strUserName, string emailId)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/business-user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + strUserName + "</h2>");
        htmlString.AppendLine("<div style='font-weight: bold;'>Our system has not been Approved you as a Verified User, hence You are not a Trusted User.</div>");
        //htmlString.AppendLine(" <div>Thanks for posting your Ad Title : " + strAdTitle + " Ad Id: " + intAdId + " In www.Jhalak.com:</div><br>");
        htmlString.AppendLine(" <div>At Jhalak.com, for legal and ethical reasons, we do not allow untrusted Users. </div><br>");
        htmlString.AppendLine(" <div>This policy ensures all our users have a safe, secure and delightful experience.</div><br>");
        htmlString.AppendLine("<div style='font-weight: bold;'>Please review our Terms of Use for complete posting rules and information.</div>");
        
        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
        
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://cricket.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://cricket.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://cricket.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://cricket.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }

    public string VerifyUser(string strUserName, string emailId, string strURL)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/business-user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + strUserName + "</h2>");
        htmlString.AppendLine("<div style='font-weight: bold;'>Please click on the below link to Verify you as a Jhalak User.</div>");
        htmlString.AppendLine(" <div> You won’t be asked to log in as it’s simply a verification of the ownership of this Email address.</div>");
        htmlString.AppendLine("<div style='margin:10px'><a href='" + strURL + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Verify</a></div>");

        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");

        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://cricket.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://cricket.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://cricket.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://cricket.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }

    public string UserAcknowledgementMail(string ownerName, string username)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/user-verification-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + ownerName + "</h2>");
        htmlString.AppendLine("<div style='font-weight: bold;'> " + username + "has shown interest on your Ad posted on Date: and waiting for your response.</div>");
        //htmlString.AppendLine(" <div>Please click on the link below to activate your account:</div>");
        //htmlString.AppendLine("<div style='margin:10px'><a href='" + strURL + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Click  here to activate your account</a></div>");
        //htmlString.AppendLine(" You login credentials :<br>");
        //htmlString.AppendLine(" User Name: your mail id<br>");
        //htmlString.AppendLine(" Password: saibaba" + "<br>");
        //htmlString.AppendLine(" Note:Please reset your password once you login <br>");
        htmlString.AppendLine("<div>Please Login to your Jhalak Account and Check the response. </div>");
        htmlString.AppendLine("<div style='margin-top:20px;'><i>You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div>");
        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you,</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>www.jhalak.com</a></div>");
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://roommates.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/117749038368923736164'><img src='http://roommates.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://twitter.com/JhalakPortal'><img src='http://roommates.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://roommates.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }


    public string DeleteMailAck(string Name, string username, string adid,string sid,string adtitle)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/user-verification-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + Name + "</h2>");
        //htmlString.AppendLine("<div style='font-weight: bold;'> " + username + "has shown interest on your Ad posted on Date: and waiting for your response.</div>");
        //htmlString.AppendLine(" <div>Please click on the link below to activate your account:</div>");
        //htmlString.AppendLine("<div style='margin:10px'><a href='" + strURL + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Click  here to activate your account</a></div>");
        //htmlString.AppendLine(" You login credentials :<br>");
        //htmlString.AppendLine(" User Name: your mail id<br>");
        //htmlString.AppendLine(" Password: saibaba" + "<br>");
        //htmlString.AppendLine(" Note:Please reset your password once you login <br>");
        htmlString.AppendLine("<div>You’re Ad "+adid+" "+adtitle+"  has been deleted successfully. You can still access you’re Ad from your </div>");
        htmlString.AppendLine("<div>Dashboard. To view you’re Ad details click. </div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href=" + "'" + "http://jhalak.com/Ad-Detail.aspx?AId=" + adid + "&SId=" + sid + "'" + " style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>View Ad Details</a></div>");
        ////
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div>");
        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
        //htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Team Jhalak</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://roommates.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/117749038368923736164'><img src='http://roommates.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://twitter.com/JhalakPortal'><img src='http://roommates.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://roommates.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }

    public string MakePremiumAck(string Name, string emailId, string adtitle, string AdId)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/user-verification-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + Name + "</h2>");
        //htmlString.AppendLine("<div style='font-weight: bold;'> " + username + "has shown interest on your Ad posted on Date: and waiting for your response.</div>");
        //htmlString.AppendLine(" <div>Please click on the link below to activate your account:</div>");
        //htmlString.AppendLine("<div style='margin:10px'><a href='" + strURL + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Click  here to activate your account</a></div>");
        //htmlString.AppendLine(" You login credentials :<br>");
        //htmlString.AppendLine(" User Name: your mail id<br>");
        //htmlString.AppendLine(" Password: saibaba" + "<br>");
        //htmlString.AppendLine(" Note:Please reset your password once you login <br>");
        htmlString.AppendLine("<div>Thanks for creating your Ad " + adtitle + " on Jhalak.com.</div>");
        htmlString.AppendLine("<div>You can now receive [n*x] more responses to your Ad by making your Ad premium.</div>");
        htmlString.AppendLine("<div>It’s fast, easy and inexpensive way to start seeing your Ad on the top of the search results.</div>");
        htmlString.AppendLine("<div> <a href='http://jhalak.com/Sign-In.aspx'>Click here</a> to make your Ad premium.</div>");

        //htmlString.AppendLine(" <div style='margin:10px'><a href=" + "'" + "http://jhalak.com/Ad-Detail.aspx?AId=" + adid + "&SId=" + sid + "'" + " style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>View Ad Details</a></div>");
        ////
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div>");
        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
        //htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Team Jhalak</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://roommates.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/117749038368923736164'><img src='http://roommates.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://twitter.com/JhalakPortal'><img src='http://roommates.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://roommates.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }

    //public string MakePremiumAck(string Name, string emailId,string AdId)
    //{

    //    htmlString.AppendLine("<body style='font-family: arial!important'>");
    //    htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
    //    htmlString.AppendLine("<tr>");
    //    htmlString.AppendLine("<td>");
    //    htmlString.AppendLine("<table style='max-width:100%'>");
    //    htmlString.AppendLine("<tr>");
    //    htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/user-verification-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
    //    htmlString.AppendLine(" </tr>");
    //    htmlString.AppendLine("</table>");
    //    htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
    //    htmlString.AppendLine(" <tr>");
    //    htmlString.AppendLine("<td>");
    //    htmlString.AppendLine("<div style='text-align: center;'>");
    //    htmlString.AppendLine("<h2>Hello " + Name + "</h2>");
    //    //htmlString.AppendLine("<div style='font-weight: bold;'> " + username + "has shown interest on your Ad posted on Date: and waiting for your response.</div>");
    //    //htmlString.AppendLine(" <div>Please click on the link below to activate your account:</div>");
    //    //htmlString.AppendLine("<div style='margin:10px'><a href='" + strURL + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Click  here to activate your account</a></div>");
    //    //htmlString.AppendLine(" You login credentials :<br>");
    //    //htmlString.AppendLine(" User Name: your mail id<br>");
    //    //htmlString.AppendLine(" Password: saibaba" + "<br>");
    //    //htmlString.AppendLine(" Note:Please reset your password once you login <br>");
    //    htmlString.AppendLine("<div>Thanks for creating your Ad on Jhalak.com.</div>");
    //    htmlString.AppendLine("<div>You can now receive [n*x] more responses to your Ad by making your Ad premium.</div>");
    //    htmlString.AppendLine("<div>It’s fast, easy and inexpensive to start seeing your Ad on the top of the search results.</div>");
    //    htmlString.AppendLine("<div> <a href=" + "'" + "http://jhalak.com/Astrology/Edit-Astrology-Ads.aspx?Id=" + AdId + "'" + ">Click here</a> to make your Ad premium.</div>");

    //    //htmlString.AppendLine(" <div style='margin:10px'><a href=" + "'" + "http://jhalak.com/Ad-Detail.aspx?AId=" + adid + "&SId=" + sid + "'" + " style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>View Ad Details</a></div>");
    //    ////
    //    //htmlString.AppendLine("<div style='margin-top:20px;'><i>You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div>");
    //    htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
    //    //htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Team Jhalak</div>");
    //    htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
    //    htmlString.AppendLine(" </div>");
    //    htmlString.AppendLine("</td>");
    //    htmlString.AppendLine("</tr>");
    //    htmlString.AppendLine("<tr>");
    //    htmlString.AppendLine("<td >");
    //    htmlString.AppendLine("<div style='text-align:center'>");
    //    htmlString.AppendLine("<ul style='margin-left:-40px'>");
    //    htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://roommates.jhalak.com/images/fb-nl.png' /></a></li>");
    //    htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/117749038368923736164'><img src='http://roommates.jhalak.com/images/g-plus-nl.png' /></a></li>");
    //    htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://twitter.com/JhalakPortal'><img src='http://roommates.jhalak.com/images/tw-nl.png' /><a></li>");
    //    htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://roommates.jhalak.com/images/pin-nl.png' /></a></li>");
    //    htmlString.AppendLine(" </ul>");
    //    htmlString.AppendLine("</div>");
    //    htmlString.AppendLine("</td>");
    //    htmlString.AppendLine("</tr>");
    //    htmlString.AppendLine("</table>");
    //    htmlString.AppendLine("</td>");
    //    htmlString.AppendLine("</tr>");
    //    htmlString.AppendLine("</table>");
    //    htmlString.AppendLine("</body>");


    //    return htmlString.ToString();
    //}


    public string AcctUpdatedAck(string Name, string emaiId, string adid)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/business-user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + Name + "</h2>");
        //htmlString.AppendLine("<div style='font-weight: bold;'> " + username + "has shown interest on your Ad posted on Date: and waiting for your response.</div>");
        //htmlString.AppendLine(" <div>Please click on the link below to activate your account:</div>");
        //htmlString.AppendLine("<div style='margin:10px'><a href='" + strURL + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Click  here to activate your account</a></div>");
        //htmlString.AppendLine(" You login credentials :<br>");
        //htmlString.AppendLine(" User Name: your mail id<br>");
        //htmlString.AppendLine(" Password: saibaba" + "<br>");
        //htmlString.AppendLine(" Note:Please reset your password once you login <br>");
        htmlString.AppendLine("<div>Your account has been updated successfully. You can change your account settings in <a href='http://jhalak.com/My-Posts.aspx'>Myaccount.jhalak.com</a> </div>");
        htmlString.AppendLine("<div>To track all your activities on Jhalak.com, go to  <a href='http://jhalak.com/My-Posts.aspx'>Myaccount.jhalak.com/Mydashboard.</a> </div>");
       // htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com/Ad-details.aspx?Aid='" + adid + " style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>View Ad Details</a></div>");
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div>");
        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
        //htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Team Jhalak</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://roommates.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/117749038368923736164'><img src='http://roommates.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://twitter.com/JhalakPortal'><img src='http://roommates.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://roommates.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }


    public string AcctUpdatedBusinessAck(string Name, string emaiId, string BName, string category)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/business-user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + Name + "</h2>");
        //htmlString.AppendLine("<div style='font-weight: bold;'> " + username + "has shown interest on your Ad posted on Date: and waiting for your response.</div>");
        //htmlString.AppendLine(" <div>Please click on the link below to activate your account:</div>");
        //htmlString.AppendLine("<div style='margin:10px'><a href='" + strURL + "' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Click  here to activate your account</a></div>");
        //htmlString.AppendLine(" You login credentials :<br>");
        //htmlString.AppendLine(" User Name: your mail id<br>");
        //htmlString.AppendLine(" Password: saibaba" + "<br>");
        //htmlString.AppendLine(" Note:Please reset your password once you login <br>");
        htmlString.AppendLine("<div>Thank you for using Jhalak.com. We are writing to let you know that your account has been  </div>");
        htmlString.AppendLine("<div>upgraded to Business User. </div>");
        htmlString.AppendLine("<div>Business Details: </div>");
        htmlString.AppendLine("<div>Business Name:"+BName+" </div>");
        htmlString.AppendLine("<div>Category:" + category + " </div>");
        //htmlString.AppendLine("<div>Business Address: </div>");
        // htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com/Ad-details.aspx?Aid='" + adid + " style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>View Ad Details</a></div>");
        //htmlString.AppendLine("<div style='margin-top:20px;'><i>You will never receive spam as a result of confirming your email. Please read our privacy policy if you have any concerns.</i></div>");
        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Thank you</div>");
        //htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Team Jhalak</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Jhalak.com</a></div>");
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://roommates.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/117749038368923736164'><img src='http://roommates.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://twitter.com/JhalakPortal'><img src='http://roommates.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://roommates.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }


    public string AccountActivation(string strUserName)
    {

        htmlString.AppendLine("<body style='font-family:arial!important;font-size:14px;'>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0' style='width: 600px; border: 1px solid #e3e3e3; margin: 20px auto; box-shadow: 1px 1px 5px #999;border-radius: 5px; border-bottom: 20px solid #0063bd;'>");
        htmlString.AppendLine("<tr><td>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0' style='text-align:right;background:#000; width:100%;'>");
        htmlString.AppendLine("<tr><td style='padding:5px;text-align:right;float:right;'>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0'><tr><td style='padding:5px;'><a href=''><img src='http://cricket.jhalak.com/images/fb-nl.png'/></a></td>");
        htmlString.AppendLine("<td style='padding:5px;'><a href=''><img src='http://cricket.jhalak.com/images/g-plus-nl.png'/></a></td>");
        htmlString.AppendLine("<td style='padding:5px;'><a href=''><img src='http://cricket.jhalak.com/images/tw-nl.png'/></a></td>");
        htmlString.AppendLine("<td style='padding:5px;'><a href=''><img src='http://cricket.jhalak.com/images/pin-nl.png'/></a></td>");
        htmlString.AppendLine("</tr></table></td></tr></table>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0' width='100%'><tr><td>");
        htmlString.AppendLine("<img src='http://cricket.jhalak.com/images/user-confirmation-mail-top.jpg'/>");
        htmlString.AppendLine("</td></tr></table>");
        htmlString.AppendLine(" <table  width='100%' cellpadding='0' cellspacing='0' style='min-height: 300px; background: #FB7833;color: #fff; padding:10px;'>");
        htmlString.AppendLine("<tr><td>");
        htmlString.AppendLine("<div style='font-weight: bold; font-size:18px'>Hello " + strUserName + "</div>");
        htmlString.AppendLine("<div style='font-weight: bold; font-size:14px'> Welcome to <a href='' style='color:#fff;text-decoration:none'>Jhalak.com,</a> an account has been created. </div>");
        htmlString.AppendLine("<div style='margin-top:10px;'>Please click on the link below to activate your account:<br /><a href='' style='color:#fff;'>http://cricket.jhalak.com</a></div>");
        htmlString.AppendLine("<div style='margin-top: 10px;'>This step is required to confirm/ validate the email you entered. A valid email address is needed to contact you in future and assist you in case you forget your username and password.</div>");
        htmlString.AppendLine("</td></tr></table>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0' width='100%'><tr>");
        htmlString.AppendLine(" <td style='background: #00A3E1; color: #fff; padding: 10px; height: 100px;'>You will never receive spam as a result of confirming your email.</td>");
        htmlString.AppendLine(" <td style='background: #444; color: #fff; padding: 10px; height: 100px;'> Please read our privacy policy if you have any concerns.</td>");
        htmlString.AppendLine(" <td style='background: #E51D0F; color: #fff; padding: 10px; height: 100px;'><a href='' style='color:#fff;text-decoration:none;'>Jhalak.com</a> is located at 14 Campus Boulevard, Newtown Square, PA 19073.</td>");
        htmlString.AppendLine("</tr></table>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0' width='100%'><tr><td style='margin-bottom: 20px; padding:10px;'>");
        htmlString.AppendLine("<div style='margin-top: 10px; font-weight:bold;'>Thank you,</div><a href='' style='text-decoration:none;color;#000'>Jhalak.com</a>");
        htmlString.AppendLine("</td></tr></table>");
        htmlString.AppendLine("</td></tr></table>");
        htmlString.AppendLine("</body>");
        //htmlString.AppendLine("</html>");

        return htmlString.ToString();
    }



    public string PromotionalNewsletter(string strUserName)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://cricket.jhalak.com/images/user-confirmation-mail-top.jpg); background-repeat:no-repeat;height:222px;width:600px'>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Dear " + strUserName + ",</h2>");
        htmlString.AppendLine("<div style='font-weight: bold;'>Event Information:</div>");
        htmlString.AppendLine("<div><label>Event Info comes here</label></div>");
        htmlString.AppendLine("<div style='margin:10px'><a style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>Event link</a></div>");
        htmlString.AppendLine("<div > Thanks,<br />Jhalak.com – Customer Care.</div>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com'><img src='http://cricket.jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://cricket.jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://cricket.jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://cricket.jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine("</ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine(" </td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td align='center' style='font-size:12px'>");
        htmlString.AppendLine("This email was sent by Jhalak.com, You are subscribed as <label>username</label> We respect your right to privacy –<br /> view our policy.<a style='color:#444' href=''>Unsubscribe</a> | <a style='color:#444' href=''>Report Spam</a>");
        htmlString.AppendLine(" </td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine(" </td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");


        return htmlString.ToString();
    }
    #region organizer
    public string OrganizerTeamInvitation(string strUserName, string strTournamentName, string strTournamentURL)
    {

        htmlString.AppendLine("<body style='font-family:arial!important;font-size:14px;'>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0' style='width: 600px; border: 1px solid #e3e3e3; margin: 20px auto; box-shadow: 1px 1px 5px #999;border-radius: 5px;'>");

        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<img src='http://cricket.jhalak.com/images/cric-banner-e.jpg'/>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table width='100%' style='text-align:center;padding:10px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='font-size: 20px; text-align: center;'>");
        htmlString.AppendLine("Hello  " + "<style='color:#fff'>" + strUserName + ",</style>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='font-size: 14px; text-align: center;'>");
        htmlString.AppendLine("You have been invited to participate in tournament " + "<br><b>" + "<a style='font-size: 18px; text-align: center;' href='" + strTournamentURL + "'>" + strTournamentName + "</a> </b>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='font-weight:bold; background:#fff;text-align:center;padding:20px'>");
        htmlString.AppendLine("Please take a minute to accept our invitation");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='font-weight:bold; text-align:center;padding:20px; color:red'>");
        htmlString.AppendLine("Please Login to your account and accept the invitation from Tournament Organizer in the Invited Tournaments Menu.<br>Thank You");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");

        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");
        //htmlString.AppendLine("</html>");

        return htmlString.ToString();
    }
    public string OrganizerNewTeamInvitation(string strUserName, string strTournamentName, string strTournamentURL, string strTeamManagerURL, string strPwd)
    {
        htmlString.AppendLine("<body style='font-family:arial!important;font-size:14px;'>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0' style='width: 600px; border: 1px solid #e3e3e3; margin: 20px auto; box-shadow: 1px 1px 5px #999;border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<img src='http://cricket.jhalak.com/images/cric-banner-e.jpg'/>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table width='100%' style='text-align:center;padding:10px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='font-size: 30px; text-align: center;'>");
        htmlString.AppendLine("Hello  " + "<style='color:#fff'>" + strUserName + ",</style>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("You have been invited to participate in tournament " + "<br><b>" + "<a href='" + strTournamentURL + "'>" + strTournamentName + "</a> </b><br><br>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<a href='" + strTeamManagerURL + "'><b> Activate your account click here </b> </a><br><br>");
        htmlString.AppendLine("Your Login Credentials :<br>");
        htmlString.AppendLine("<div style='font-weight:bold; font-size:13px; background:#e7e7e7;border:1px solid #ddd;border-radius:3px;color:#366cc2'>");
        htmlString.AppendLine("<b>User Name:</b> Your Email ID<br>");
        htmlString.AppendLine("<b>Password:</b>" + strPwd + "<br>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("<div style='color:red;font-weight:bold;'>");
        htmlString.AppendLine("Note:Please Login to Your Account and change password");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='font-weight:bold; background:#fff;text-align:center;padding:20px'>");
        htmlString.AppendLine("Please accept the request from Tournament Organizer in the Invited Tournaments Menu");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");
        //htmlString.AppendLine("</html>");

        return htmlString.ToString();
    }
    public string TournamentWaiver(string strPlayerName, string strPlayerMaild, string strOrgMailId, string strOrganizer, string strTournament, string strDownloadURL)
    {
        htmlString.AppendLine("<body style='font-family:arial!important;font-size:14px;'>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0' style='width: 600px; border: 1px solid #e3e3e3; margin: 20px auto; box-shadow: 1px 1px 5px #999;border-radius: 5px;'>");

        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<img src='http://cricket.jhalak.com/images/cric-banner-e.jpg'/>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table width='100%' style='text-align:center;padding:10px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='font-size: 30px; text-align: center;'>");
        htmlString.AppendLine("Hello  " + "<style='color:#fff'>" + strOrganizer + ",</style>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("I have agreed tournament waiver to participate in  " + "<b>" + strTournament + "</b>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<a href='" + strDownloadURL + "'><b> Download tournament waiver </b> </a><br><br>");
        htmlString.AppendLine(" Thanks :<br>");
        htmlString.AppendLine(strPlayerName + "," + strPlayerMaild + " <br>");

        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");

        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='font-weight:bold; background:#fff;text-align:center;padding:20px'>");

        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");
        //htmlString.AppendLine("</html>");

        return htmlString.ToString();
    }
    public string OrganizerFinalizingTeam(string strPlayerName, string strTournamentName, string strTournamentURL, string strTeamManager, string strTeamManagerMaildId)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine("<table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(images/cric-banner-f.png); background-repeat:no-repeat;height:222px;width:600px'>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Dear " + strPlayerName + ",</h2>");
        htmlString.AppendLine(" <div style='font-weight: bold;font-size:30px;'>Congratulations..!!</div>");
        htmlString.AppendLine("<div style='margin:10px'>Team Manager has accepted your invitation and finalized your place on the squad for <br /><b>" + strTournamentName + "</b></div>");
        htmlString.AppendLine("<div>Please visit the below URL for Tournament Pools, Scheduled Matches, Match Scores, Team points, Team Statistics and Media</div>");
        htmlString.AppendLine("<div style='margin:10px'>");
        htmlString.AppendLine("<a style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px' href='" + strTournamentURL + "'>" + strTournamentURL + "</a>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("<div  style='margin:40px 10px;text-align:left;font-weight:100;'><b>Thank you,<br />" + strTeamManager + "<br />" + strTeamManagerMaildId + "</b></div>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine(" </td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");

        return htmlString.ToString();
    }
    #endregion





    #region MyRegion
    public string WriteNews(string strUserName, string strSummary)
    {


        htmlString.AppendLine("<body style='font-family:arial!important'>");
        htmlString.AppendLine("<table style='width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999;padding:0px'>");
        htmlString.AppendLine("<tr><td><table cellpadding='0' cellspacing='0' width='100%'><tr><td>");
        htmlString.AppendLine("<img src='http://cricket.jhalak.com/images/cric-banner-b.jpg'/>");
        htmlString.AppendLine("</td></tr></table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='min-height:300px;background:#FB7833;color:#fff;'>");
        htmlString.AppendLine("<tr><td></table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='min-height:300px; background:#FB7833;color:#fff;'>");
        htmlString.AppendLine("<tr><td style='height:300px'>");
        htmlString.AppendLine("<div style='text-align:center;'>");
        htmlString.AppendLine("<h4>Hello " + strUserName + "</h4>");

        htmlString.AppendLine("<div>" + strSummary + " </div>");

        htmlString.AppendLine("<div style='font-size:30px;color:#fff;text-decoration:none;'>Happy Browsing..!!<br />http://www.cricket.jhalak.com");
        htmlString.AppendLine("<div class='col-sm-12' style='font-size:20px;'>");
        htmlString.AppendLine("Desi Browsing,Now Easy.");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td></tr></table>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0' style='text-align:right;background:#000; width:100%;'>");
        htmlString.AppendLine("<tr><td style='padding:5px;text-align:right;float:right;'>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0'><tr><td style='padding:5px;'><img src='http://cricket.jhalak.com/images/fb-nl.png'/></td>");
        htmlString.AppendLine("<td style='padding:5px;'><img src='http://cricket.jhalak.com/images/g-plus-nl.png'/></td>");
        htmlString.AppendLine("<td style='padding:5px;'><img src='http://cricket.jhalak.com/images/tw-nl.png'/></td>");
        htmlString.AppendLine("<td style='padding:5px;'><img src='http://cricket.jhalak.com/images/pin-nl.png'/></td>");
        htmlString.AppendLine("</tr></table></td></tr></table>");
        htmlString.AppendLine("</td></tr></table>");
        htmlString.AppendLine("</body>");
        //htmlString.AppendLine("</html>");

        return htmlString.ToString();
    }
    public string WriteNews(string strSubject, string strSummary, string strOrganizer)
    {


        htmlString.AppendLine("<body style='font-family:arial!important'>");
        htmlString.AppendLine("<table style='width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999;padding:0px'>");
        htmlString.AppendLine("<tr><td><table cellpadding='0' cellspacing='0' width='100%'><tr><td>");
        htmlString.AppendLine("<img src='http://cricket.jhalak.com/images/cric-banner-b.jpg'/>");
        htmlString.AppendLine("</td></tr></table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='min-height:300px;background:#FB7833;color:#fff;'>");
        htmlString.AppendLine("<tr><td></table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='min-height:300px; background:#FB7833;color:#fff;'>");
        htmlString.AppendLine("<tr><td style='height:300px'>");
        htmlString.AppendLine("<div style='text-align:center;'>");
        htmlString.AppendLine("<h4>Hello " + "All" + "</h4>");

        htmlString.AppendLine("<div>" + strSummary + " </div>");

        htmlString.AppendLine("<div style='font-size:30px;color:#fff;text-decoration:none;'>Happy Browsing..!!<br />http://www.cricket.jhalak.com");
        htmlString.AppendLine("<div class='col-sm-12' style='font-size:20px;'>");
        htmlString.AppendLine("Desi Browsing, Now Easy.");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td></tr></table>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0' style='text-align:right;background:#000; width:100%;'>");
        htmlString.AppendLine("<tr><td style='padding:5px;text-align:right;float:right;'>");
        htmlString.AppendLine("<table cellpadding='0' cellspacing='0'><tr><td style='padding:5px;'><img src='http://cricket.jhalak.com/images/fb-nl.png'/></td>");
        htmlString.AppendLine("<td style='padding:5px;'><img src='http://cricket.jhalak.com/images/g-plus-nl.png'/></td>");
        htmlString.AppendLine("<td style='padding:5px;'><img src='http://cricket.jhalak.com/images/tw-nl.png'/></td>");
        htmlString.AppendLine("<td style='padding:5px;'><img src='http://cricket.jhalak.com/images/pin-nl.png'/></td>");
        htmlString.AppendLine("</tr></table></td></tr></table>");
        htmlString.AppendLine("</td></tr></table>");
        htmlString.AppendLine("</body>");
        //htmlString.AppendLine("</html>");

        return htmlString.ToString();
    }
    #endregion

    #region 
    public string ForgotPasswrod(string userName, string strPwd)
    {

        htmlString.AppendLine("<body style='font-family: arial!important'>");
        htmlString.AppendLine(" <table style='max-width: 600px; border: 1px solid #e3e3e3; margin: 20px auto;box-shadow: 1px 1px 5px #999; border-radius: 5px;'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<table style='max-width:100%'>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td style='background-image:url(http://jhalak.com/images/cric-banner-c.png); background-repeat:no-repeat;height:222px;width:600px'></td>");
        htmlString.AppendLine(" </tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("<table width='100%' cellpadding='0' cellspacing='0' style='color: #666;'>");
        htmlString.AppendLine(" <tr>");
        htmlString.AppendLine("<td>");
        htmlString.AppendLine("<div style='text-align: center;'>");
        htmlString.AppendLine("<h2>Hello " + userName + "</h2>");
        htmlString.AppendLine(" You login credentials :<br>");
        htmlString.AppendLine("<div style='font-weight:bold; color:red;font-size:13px;'>");
        htmlString.AppendLine("<b>User Name:</b> your mail id<br>");
        htmlString.AppendLine("<b>Password:</b>" + strPwd + "<br>");
        htmlString.AppendLine("Note:Please reset your password once you login <br>");
        htmlString.AppendLine("</div>");
        
        htmlString.AppendLine("<div style='font-size: 16px;margin-top:50px;'>Happy Browsing</div>");
        htmlString.AppendLine(" <div style='margin:10px'><a href='http://jhalak.com' style='background:#E21C04; color:#fff; text-decoration:none; padding:5px 50px;border-radius:5px; font-size:20px'>http://www.jhalak.com</a></div>");
        htmlString.AppendLine(" </div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("<tr>");
        htmlString.AppendLine("<td >");
        htmlString.AppendLine("<div style='text-align:center'>");
        htmlString.AppendLine("<ul style='margin-left:-40px'>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.facebook.com/Jhalakcom-428270054025360/'><img src='http://jhalak.com/images/fb-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://plus.google.com/'><img src='http://jhalak.com/images/g-plus-nl.png' /></a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.twitter.com'><img src='http://jhalak.com/images/tw-nl.png' /><a></li>");
        htmlString.AppendLine("<li style='list-style-type:none;display:inline;margin:5px'><a href='https://www.pinterest.com'><img src='http://jhalak.com/images/pin-nl.png' /></a></li>");
        htmlString.AppendLine(" </ul>");
        htmlString.AppendLine("</div>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</td>");
        htmlString.AppendLine("</tr>");
        htmlString.AppendLine("</table>");
        htmlString.AppendLine("</body>");
        return htmlString.ToString();


    }

    #endregion


}
