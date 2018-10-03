<%@ Page Title="Login " Language="C#" MasterPageFile="~/Post-Ad.master" AutoEventWireup="true" CodeFile="Sign-In.aspx.cs" Inherits="Account_Login" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
             
            <div class="jhkfrm row margin">
                <div class="col-sm-12">
                    <div class="col-sm-6 login-centered">
                        <div class="col-sm-12 txtcenter">

                            <asp:Label ID="lblSignin" runat="server" Text=""></asp:Label>

                        </div>
                         
    
   
                        <asp:Label ID="lblforgot" runat="server" Text=""></asp:Label>
                        <asp:Label ID="txtname" runat="server" Text=""></asp:Label>
                        <div class="userlog row txtcenter">
                           
                            <b>Sign in</b>
                          
                        </div>
                        <div>
                            <div>
                                <label>
                                    <span>User name:<b class="frm-mandate"> *</b></span>
                                    <asp:TextBox ID="txtUserId" runat="server" placeholder="Enter valid mail id" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ValidationGroup="vgSignin" ControlToValidate="txtUserId" Display="None" ErrorMessage="User mail id is required!<br>Please make sure to enter the organizer user mail id." />
                                    <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" runat="server" TargetControlID="RequiredFieldValidator13" Width="220" CloseImageUrl="images/alert-close.png" WarningIconImageUrl="images/alert-img.png" />
                                </label>
                            </div>
                            <div>
                                <label>
                                    <span>Password:<b class="frm-mandate">*</b></span>
                                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" placeholder="Enter Password" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="vgsignin" ControlToValidate="txtPwd" Display="None" ErrorMessage="password is required!<br>Please make sure to enter the password." />
                                    <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" runat="server" TargetControlID="RequiredFieldValidator1" Width="220" CloseImageUrl="images/alert-close.png" WarningIconImageUrl="images/alert-img.png" />
                                </label>
                            </div>
                          
                            <div class="sub-btn">
                                <asp:Button ID="btnSignIn" CssClass="sub-btn" runat="server" ValidationGroup="vgsignin" Text="Submit" OnClick="btnSignIn_Click" />
                            </div>
                          <%--   <a class="signup-btn" href="#"    onclick="loginByFacebook();">Login with Facebook</a>--%>
                          
                         


                            
                           
                        </div>
                    </div>
                </div>
                

            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
