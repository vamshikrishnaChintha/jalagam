<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Contactus.aspx.cs" Inherits="Contactus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
   
   
    <link href="css/forms.css" rel="stylesheet" />
    <%--<link href="css/bootstrap.css" rel="stylesheet" />--%>
    <link href="css/custom.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
   
    <script type="text/javascript" src="js/jQuery-2.2.0.js"></script>
  
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <img src="images/jslide-01-inner.jpg" alt="" width="100%" />
    </div>

    <div class=" row  branches-bg padding">
           
            <div class="txtcenter padding-top padding-bottom col-sm-12">
                <h3 style="color: #fff;"><b>Contact Us</b></h3>
            </div>
         
                <div class="col-sm-12 margin-bottom ">
                    <div class="col-sm-6 jhkfrm login-centered" style="background: #fff;box-shadow:none!important;">
                        


                        
                        <div>
                            <div class="margin-top">
                               
                                    <span>Name:<b class="frm-mandate"> *</b></span>
                                    <asp:TextBox ID="txtName" runat="server" Width="100%" placeholder="Enter Your Name" />
                                   
                               
                            </div>
                            <div class="margin-top">
                               
                                    <span>Email ID:<b class="frm-mandate"> *</b></span>
                                    <asp:TextBox ID="txtEmailId" runat="server" placeholder="Enter Your Email ID" />

                              
                            </div>
                            <div class="margin-top">
                           
                                    <span>Phone Number:<b class="frm-mandate"> *</b></span>
                                    <asp:TextBox ID="txtPhoneNumber" runat="server" placeholder="Enter Your Phone Number" />

                               
                            </div>
                            <div class="margin-top">
                              
                                    <span >Reason for Contact:<b class="frm-mandate"> *</b></span>
                                    <asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine" placeholder="Enter Your Reason for Contact" />

                                
                            </div>

                            <div class="sub-btn">
                                <asp:Button ID="Button" CssClass="sub-btn" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                            </div>
                          
                        </div>
                    </div>
                </div>


            </div>

       

</asp:Content>

