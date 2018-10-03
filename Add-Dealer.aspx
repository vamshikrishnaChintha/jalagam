<%@ Page Title="" Language="C#" MasterPageFile="~/Post-Ad.master" AutoEventWireup="true" CodeFile="Add-Dealer.aspx.cs" Inherits="Add_Dealer" %>
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
                        <h3 class="h-tag padding">Dealer Registration</h3>
                        <div class="pane-txt">

                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Dealer Name<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtDealerName" MaxLength="100" Placeholder="&#xf007; Add Dealer Name"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtDealerName" Font-Bold="true"
                                            ErrorMessage="Dealer Name is Required !" Display="Dynamic"
                                            runat="server" />
                                    </div>
                                </div>
                            </div>
                            <%--<div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Age<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtAge" MaxLength="2" Placeholder="&#xf007; Add Age"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtAge" Font-Bold="true"
                                            ErrorMessage="Age is Required !" Display="Dynamic"
                                            runat="server" />
                                        <cc1:filteredtextboxextender id="Filteredtextboxextender1" runat="server" filtertype="Numbers"
                                            targetcontrolid="txtAge">
                                                        </cc1:filteredtextboxextender>
                                    </div>
                                </div>
                            </div>--%>
                           
                            <%--<div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Qualification<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtQualification" MaxLength="50" Placeholder="&#xf007; Add Qualification"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtQualification" Font-Bold="true"
                                            ErrorMessage="Qualification is Required !" Display="Dynamic"
                                            runat="server" />
                                    </div>

                                     
                                    </div>
                                </div>--%>
                            </div>
                            <%--<div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>EMailId<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtEMailId" MaxLength="100" Placeholder="&#xf007; Add EmailId"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtEMailId" Font-Bold="true"
                                            ErrorMessage="EMailId is Required !" Display="Dynamic"
                                            runat="server" />
                                    </div>
                                </div>
                            </div>--%>
                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Contact Number<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtContactNo" MaxLength="10" Placeholder="&#xf007; Add Contact No."
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtContactNo" Font-Bold="true"
                                            ErrorMessage="Contact Number is Required !" Display="Dynamic"
                                            runat="server" />
                                        <cc1:FilteredTextBoxExtender ID="Filteredtextboxextender2" runat="server" FilterType="Numbers"
                                            TargetControlID="txtContactNo" />

                                    </div>
                                </div>
                            </div>
                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Location<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtCity" MaxLength="200" Placeholder="&#xf007; Add City"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtCity" Font-Bold="true"
                                            ErrorMessage="City is Required !" Display="Dynamic"
                                            runat="server" />
                                    </div>
                                </div>
                            </div>
                        <%--<div class="post-ad-frm margin-bottom">
                            <div class="padding border-bottom">
                                <h3 class="h-tag padding">
                                    <b>Current Business<span style="color: #f60" title="Required">*</span></b></h3>
                            </div>
                            <div class="row padding">
                                <div class="col-sm-8">
                                    <asp:TextBox runat="server" ID="txtCurrentBusiness" MaxLength="100" Placeholder="&#xf007; Add Current Business"
                                        Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtCurrentBusiness" Font-Bold="true"
                                        ErrorMessage="Current Business is Required !" Display="Dynamic"
                                        runat="server" />
                                </div>
                            </div>
                        </div>--%>

                        <%--<div class="post-ad-frm margin-bottom">
                            <div class="padding border-bottom">
                                <h3 class="h-tag padding">
                                    <b>Firm Name<span style="color: #f60" title="Required">*</span></b></h3>
                            </div>
                            <div class="row padding">
                                <div class="col-sm-8">
                                    <asp:TextBox runat="server" ID="txtFirmName" MaxLength="100" Placeholder="&#xf007; Add Firm Name"
                                        Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtFirmName" Font-Bold="true"
                                        ErrorMessage="Firm Name is Required !" Display="Dynamic"
                                        runat="server" />
                                </div>
                            </div>
                        </div>--%>

                       <%-- <div class="post-ad-frm margin-bottom">
                            <div class="padding border-bottom">
                                <h3 class="h-tag padding">
                                    <b>Constitution<span style="color: #f60" title="Required">*</span></b></h3>
                            </div>
                            <div class="row padding">
                                <div class="col-sm-8">
                                    <asp:TextBox runat="server" ID="txtConstitution" MaxLength="50" Placeholder="&#xf007; Add Constitution"
                                        Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtConstitution" Font-Bold="true"
                                        ErrorMessage="Constitution is Required !" Display="Dynamic"
                                        runat="server" />
                                </div>
                            </div>
                        </div>--%>



                            
                            <div class="txtcenter row">
                                <asp:Literal ID="lblMsg" runat="server"></asp:Literal>
                                <asp:Button ID="btnSubmit" runat="server" Text="&#xf1d8; Submit" ValidationGroup="VgGroup" Style="font-family: CustomFont, FontAwesome;"
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

