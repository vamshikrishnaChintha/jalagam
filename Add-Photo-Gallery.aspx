<%@ Page Title="" Language="C#" MasterPageFile="~/Post-Ad.master" AutoEventWireup="true" CodeFile="Add-Photo-Gallery.aspx.cs" Inherits="Add_Photo_Gallery" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
    <div class="desc-page">
        <div class="row margin jhkfrm ">
            <div class="col-sm-8 login-centered">

                <div class="teamgrids row">
                    <div class="col-md-2  col-xs-12 teamgrid1 ">
                        <div class="admin-category-list  txtcenter">
                            <img src="images/admin-dashboard-icon.png" /><br />
                            <a href="Dashboard.aspx">Dashboard</a>
                        </div>
                    </div>
                    <div class="col-md-2  col-xs-6 teamgrid1 ">
                        <div class="admin-category-list txtcenter">
                            <img src="images/admin-product-icon.png" /><br />
                            <a href="Add-Product.aspx">Add Product</a>
                        </div>
                    </div>
                    <div class="col-md-3  col-xs-6 teamgrid1 ">
                        <div class="admin-category-list txtcenter">
                            <img src="images/admin-battery-icon.png" /><br />
                            <a href="Add-Accessories.aspx">Add Accessories</a>
                        </div>
                    </div>
                    <div class="col-md-2  col-xs-6 teamgrid1 ">
                        <div class="admin-category-list  txtcenter">
                            <img src="images/admin-location-icon.png" /><br />
                            <a href="Add-Branch-Details.aspx">Add Branches </a>
                        </div>
                    </div>
                    <div class="col-md-3  col-xs-6 teamgrid1 ">
                        <div class="admin-category-list active-link txtcenter">
                            <img src="images/admin-gallery-icon.png" /><br />
                            <a href="Add-Photo-Gallery.aspx">Add Photo Gallery</a>
                        </div>
                    </div>
                </div>

                <h3 class="h-tag padding">Add Photo Gallery</h3>
                <div class="pane-txt">


                    <div class="post-ad-frm margin-bottom">
                        <div class="padding border-bottom">
                            <h3 class="h-tag padding">
                                <b>Title<span style="color: #f60" title="Required">*</span></b></h3>
                        </div>
                        <div class="row padding">
                            <div class="col-sm-8">
                                <asp:TextBox runat="server" ID="txtTitle" MaxLength="100" Placeholder="&#xf007; Add Product Code"
                                    Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                <%--<cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" TargetControlID="RequiredFieldValidator1" Width="220" runat="server" CloseImageUrl="images/alert-close.png" WarningIconImageUrl="images/alert-img.png" />--%>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtTitle" Font-Bold="true"
                                    ErrorMessage="Title is Required !" Display="Dynamic"
                                    runat="server" />
                            </div>
                        </div>
                    </div>


                    <div class="post-ad-frm margin-bottom">
                        <div class="padding border-bottom" style="background: #efefef; border-top: 2px solid #e21c04">
                            <h3 class="h-tag padding">
                                <b>Upload Photos<span style="color: #f60" title="Required">*</span></b></h3>
                        </div>
                        <div class="row padding">
                            <div class="col-sm-8">
                                <a name="Images"></a>

                                <%-- <asp:FileUpload ID="fupProducts" class="multi" accept=".png,.jpg,.jpeg,.gif" runat="server" ViewStateMode="Enabled" />--%>


                                <asp:FileUpload ID="fupPhoto" runat="server" AllowMultiple="true" />
                                <asp:RegularExpressionValidator ID="rexp" runat="server" ControlToValidate="fupPhoto" ForeColor="Red"
                                    ErrorMessage="Only .gif, .jpg, .png, .tiff and .jpeg" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="VgGroup"
                                    ValidationExpression="(.*\.([Gg][Ii][Ff])|.*\.([Jj][Pp][Gg])|.*\.([Jj][Pp][Ee][Gg])|.*\.([Bb][Mm][Pp])|.*\.([pP][nN][gG])|.*\.([tT][iI][iI][fF])$)"></asp:RegularExpressionValidator>
                                <%-- <asp:RegularExpressionValidator ID="RegularExpressionValidator1" Display="Dynamic" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.PNG|.jpg|.JPG|.JPEG|.jpeg)$" ControlToValidate="fupOfficialImage" runat="server" ForeColor="Red" ErrorMessage="Please select a valid Image file." />--%>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="fupPhoto" Font-Bold="true"
                                    ErrorMessage="Photo is Required !" Display="Dynamic"
                                    runat="server" />

                                <%--  <asp:Label ID="lblImageMsg" Visible="false" CssClass="err-class-img" runat="server"></asp:Label>--%>
                            </div>

                        </div>
                    </div>
                </div>

            </div>



            <div class="txtcenter row margin-top-20">
                <asp:Literal ID="lblMsg" runat="server"></asp:Literal>
                <asp:Button ID="btnSubmit" runat="server" Text="&#xf1d8; Submit" Style="font-family: CustomFont, FontAwesome;"
                    CssClass="btn btn-default list-btn" ValidationGroup="VgGroup" OnClick="btnSubmit_Click" />
            </div>
        </div>
    </div>

        </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>

