<%@ Page Title="" Language="C#" MasterPageFile="~/Post-Ad.master" AutoEventWireup="true" CodeFile="Edit-Product.aspx.cs" Inherits="Edit_Product" %>
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
                    <div class="col-sm-7 login-centered">

                        <div class="teamgrids row">
                            <div class="col-md-2  col-xs-12 teamgrid1">
                                <div class="admin-category-list  txtcenter">
                                    <img src="images/admin-dashboard-icon.png" /><br />
                                    <a href="Dashboard.aspx">Dashboard</a>
                                </div>
                            </div>
                            <div class="col-md-2  col-xs-6 teamgrid1 ">
                                <div class="admin-category-list active-link txtcenter">
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
                            <div class="col-md-2  col-xs-6 teamgrid1">
                                <div class="admin-category-list txtcenter">
                                    <img src="images/admin-location-icon.png" /><br />
                                    <a href="Add-Branch-Details.aspx">Add Branches </a>
                                </div>
                            </div>
                            <div class="col-md-3  col-xs-6 teamgrid1 ">
                                <div class="admin-category-list txtcenter">
                                    <img src="images/admin-gallery-icon.png" /><br />
                                    <a href="Add-Photo-Gallery.aspx">Add Photo Gallery</a>
                                </div>
                            </div>
                        </div>


                        <h3 class="h-tag padding">Edit Product</h3>
                        <div class="pane-txt">

                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Product Code<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtProductCode" ReadOnly="true" MaxLength="100" Placeholder="&#xf007; Add Product Code"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtProductCode" Font-Bold="true"
                                            ErrorMessage="Product Code is Required !" Display="Dynamic"
                                            runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Price<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtPrice" MaxLength="7" Placeholder="&#xf007; Add Price"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtPrice" Font-Bold="true"
                                            ErrorMessage="Price is Required !" Display="Dynamic"
                                            runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Product Name<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtPName" MaxLength="500" Placeholder="&#xf007; Add Product Name"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtPName" Font-Bold="true"
                                            ErrorMessage="Product Name is Required !" Display="Dynamic"
                                            runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Battery Type<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:DropDownList ID="ddlBatteryType" runat="server">

                                            <asp:ListItem Text="Sealed Lead Acid Battery"></asp:ListItem>
                                            <asp:ListItem Text="Normal Battery"></asp:ListItem>
                                            <asp:ListItem Text="Electric Vechile Battery 20AH "></asp:ListItem>
                                            <asp:ListItem Text="V48 Battery 20AH IQ"></asp:ListItem>
                                            <asp:ListItem Text="V60 Battery 20AH IQ"></asp:ListItem>
                                            <asp:ListItem Text="Lithium Ion"></asp:ListItem>

                                        </asp:DropDownList>

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="ddlBatteryType" Font-Bold="true"
                                            ErrorMessage="Battery Type is Required !" Display="Dynamic"
                                            runat="server" />

                                    </div>
                                </div>
                            </div>
                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Color<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtColor" MaxLength="20" Placeholder="&#xf007; Add Color"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtColor" Font-Bold="true"
                                            ErrorMessage="Color is Required !" Display="Dynamic"
                                            runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Description<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtDesc" MaxLength="1000" Placeholder="&#xf007; Add Description"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtDesc" Font-Bold="true"
                                            ErrorMessage="Description is Required !" Display="Dynamic"
                                            runat="server" />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationGroup="VgGroup" ControlToValidate="txtDesc" CssClass="err-class"
                                            Display="Dynamic" Font-Bold="true" ErrorMessage="You Have Reached Your Maximum Limit of 1000 Characters Allowed for Description!"
                                            ValidationExpression="[\s\S]{1,1000}"></asp:RegularExpressionValidator>

                                    </div>
                                </div>
                            </div>
                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Tags<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtTags" MaxLength="100" Placeholder="&#xf007; Add Tags"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtTags" Font-Bold="true"
                                            ErrorMessage="Tags is Required !" Display="Dynamic"
                                            runat="server" />
                                    </div>
                                </div>
                            </div>


                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom" style="background: #efefef; border-top: 2px solid #e21c04">
                                    <h3 class="h-tag padding">
                                        <b>Upload Display Image<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <a name="Images"></a>

                                        <%-- <asp:FileUpload ID="fupProducts" class="multi" accept=".png,.jpg,.jpeg,.gif" runat="server" ViewStateMode="Enabled" />--%>


                                        <asp:FileUpload ID="fupDisplayImage" runat="server" />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="fupDisplayImage" ForeColor="Red"
                                            ErrorMessage="Only .gif, .jpg, .png, .tiff and .jpeg" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="VgGroup"
                                            ValidationExpression="(.*\.([Gg][Ii][Ff])|.*\.([Jj][Pp][Gg])|.*\.([Jj][Pp][Ee][Gg])|.*\.([Bb][Mm][Pp])|.*\.([pP][nN][gG])|.*\.([tT][iI][iI][fF])$)"></asp:RegularExpressionValidator>
                                        <%-- <asp:RegularExpressionValidator ID="RegularExpressionValidator1" Display="Dynamic" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.PNG|.jpg|.JPG|.JPEG|.jpeg)$" ControlToValidate="fupOfficialImage" runat="server" ForeColor="Red" ErrorMessage="Please select a valid Image file." />--%>

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ValidationGroup="VgGroup" ControlToValidate="fupDisplayImage" ErrorMessage="Display Image is Required!" CssClass="err-class" Display="Dynamic" ForeColor="Red" runat="server" />

                                        <%--  <asp:Label ID="lblImageMsg" Visible="false" CssClass="err-class-img" runat="server"></asp:Label>--%>
                                    </div>
                                </div>
                            </div>

                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom" style="background: #efefef; border-top: 2px solid #e21c04">
                                    <h3 class="h-tag padding">
                                        <b>Upload Product<span style="color: #f60"></span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <a name="Images"></a>

                                        <asp:FileUpload ID="fupProducts" runat="server" AllowMultiple="true" />
                                        <asp:RegularExpressionValidator ID="rexp" runat="server" ControlToValidate="fupProducts" ForeColor="Red"
                                            ErrorMessage="Only .gif, .jpg, .png, .tiff and .jpeg" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="VgGroup"
                                            ValidationExpression="(.*\.([Gg][Ii][Ff])|.*\.([Jj][Pp][Gg])|.*\.([Jj][Pp][Ee][Gg])|.*\.([Bb][Mm][Pp])|.*\.([pP][nN][gG])|.*\.([tT][iI][iI][fF])$)"></asp:RegularExpressionValidator>                                      
                                       <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ValidationGroup="VgGroup" ControlToValidate="fupProducts" ErrorMessage="Photo is required!" Display="Dynamic" ForeColor="Red" runat="server" />--%>

                                        <%--  <asp:Label ID="lblImageMsg" Visible="false" CssClass="err-class-img" runat="server"></asp:Label>--%>
                                    </div>

                                </div>
                            </div>

                            <div class="txtcenter row">
                                <asp:Literal ID="lblMsg" runat="server"></asp:Literal>
                                <asp:Button ID="btnSubmit" runat="server" Text="&#xf1d8; Update" ValidationGroup="VgGroup" Style="font-family: CustomFont, FontAwesome;"
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

