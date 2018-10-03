using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
/// <summary>
/// Summary description for MailServices
/// </summary>
public class MailServices
{
    public MailServices()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void SendeMail(string strUserMailId, string strSubject, string strMsg)
    {


        try
        {
            SmtpClient mySmtpClient = new SmtpClient("smtpout.secureserver.net");


            mySmtpClient.UseDefaultCredentials = false;
            System.Net.NetworkCredential basicAuthenticationInfo = new
               System.Net.NetworkCredential("shailesh.gajula@sudimna.com", "hindu@1234");
            mySmtpClient.Credentials = basicAuthenticationInfo;


            MailAddress from = new MailAddress("shailesh.gajula@sudimna.com", "Jhalak");
            MailAddress to = new MailAddress(strUserMailId);
            MailMessage myMail = new System.Net.Mail.MailMessage(from, to);


            //MailAddress replyto = new MailAddress("reply@example.com");
            //myMail.ReplyTo = replyto;

            // set subject and encoding
            myMail.Subject = strSubject;
            myMail.SubjectEncoding = System.Text.Encoding.UTF8;

            // set body-message and encoding
            myMail.Body = "<b>" + strMsg + " </b><br />using <b>HTML</b>.";
            myMail.BodyEncoding = System.Text.Encoding.UTF8;
            // text or html
            myMail.IsBodyHtml = true;

            mySmtpClient.Send(myMail);


        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {


        }
    }
}