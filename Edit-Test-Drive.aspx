<%@ Page Title="" Language="C#" MasterPageFile="~/Post-Ad.master" AutoEventWireup="true" CodeFile="Edit-Test-Drive.aspx.cs" Inherits="Edit_Test_Drice" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <div class="desc-page">
                <div class="row margin jhkfrm">
                    <div class="col-sm-9 login-centered">
                        <h3 class="h-tag padding">Edit Test Drive</h3>
                        <div class="pane-txt">

                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Name<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtName" MaxLength="30" Placeholder="&#xf007; Add Name"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtName" Font-Bold="true"
                                            ErrorMessage="Name is Required !" Display="Dynamic"
                                            runat="server" />

                                    </div>
                                </div>
                            </div>
                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Address<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtAddress" MaxLength="300" Placeholder="&#xf007; Add Address"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtAddress" Font-Bold="true"
                                            ErrorMessage="Address is Required !" Display="Dynamic"
                                            runat="server" />
                                    </div>
                                </div>
                            </div>

                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Contact Number<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtContactNo" MaxLength="30" Placeholder="&#xf007; Add Contact Number"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtContactNo" Font-Bold="true"
                                            ErrorMessage="Contact Number is Required !" Display="Dynamic"
                                            runat="server" />
                                    </div>
                                </div>
                            </div>



                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Email ID<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtEmailId" MaxLength="30" Placeholder="&#xf007; Add EMailId"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtEmailId" Font-Bold="true"
                                            ErrorMessage="EMailId is Required !" Display="Dynamic"
                                            runat="server" />

                                        <asp:RegularExpressionValidator ID="rfEmail" runat="server" Display="Dynamic" ValidationGroup="VgGroup" ControlToValidate="txtEmailId" ErrorMessage="Enter a valid Email Address !" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                    </div>
                                </div>
                            </div>

                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Products<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:DropDownList ID="ddlProductCode" runat="server"></asp:DropDownList>


                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="ddlProductCode" Font-Bold="true"
                                            ErrorMessage="Product Code is Required !" Display="Dynamic"
                                            runat="server" />

                                    </div>
                                </div>
                            </div>

                        </div>





                        <div class="txtcenter row">
                            <asp:Literal ID="lblMsg" runat="server"></asp:Literal>
                            <asp:Button ID="btnSubmit" runat="server" Text="&#xf1d8; Update" Style="font-family: CustomFont, FontAwesome;" ValidationGroup="VgGroup"
                                CssClass="btn btn-default list-btn" OnClick="btnSubmit_Click" />
                        </div>
                    </div>
                </div>
            </div>

            </div>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnSubmit" />
        </Triggers>
    </asp:UpdatePanel>


</asp:Content>

