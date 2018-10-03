<%@ Page Title="" Language="C#" MasterPageFile="~/Post-Ad.master" AutoEventWireup="true" CodeFile="Add-Branch-Details.aspx.cs" Inherits="Add_Branch_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <div class="desc-page">
                <div class="row margin jhkfrm">
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
                                <div class="admin-category-list active-link txtcenter">
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

                        <h3 class="h-tag padding">Add Branch Details</h3>


                        <div class="pane-txt">

                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Branch Name<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtBranchName" MaxLength="100" Placeholder="&#xf007; Add Branch Name"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtBranchName" Font-Bold="true"
                                            ErrorMessage="Branch Name is Required !" Display="Dynamic"
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
                                        <asp:TextBox runat="server" ID="txtAddress" MaxLength="200" Placeholder="&#xf007; Add Address"
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
                                        <asp:TextBox runat="server" ID="txtContactNo" MaxLength="50" Placeholder="&#xf007; Add Contact Number"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtContactNo" Font-Bold="true"
                                            ErrorMessage="Contact Number is Required !" Display="Dynamic"
                                            runat="server" />

                                        <%--  <asp:RegularExpressionValidator ID="RegularExpressionValidator7" Display="Dynamic" ValidationGroup="VgGroup"
                                             runat="server" ErrorMessage="Enter valid Phone number !"
                                             ControlToValidate="txtContactNo"
                                             ValidationExpression="^[2-9]{2}[0-9]{8}$+(,^[2-9]{2}[0-9]{8}$+)"></asp:RegularExpressionValidator>--%>

                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" Display="Dynamic" ValidationGroup="VgGroup"
                                            runat="server" ErrorMessage="Enter valid Phone number (Only Numbers and Comma(,) )!"
                                            ControlToValidate="txtContactNo"
                                            ValidationExpression="[[0-9]{10}]+(,[0-9]+)*"></asp:RegularExpressionValidator>
                                      <%--  <ajax:filteredtextboxextender
                                            id="txtCharacters_FilteredTextBoxExtender"
                                            runat="server"
                                            enabled="True"
                                            targetcontrolid="txtCharacters"
                                            filtertype="Custom,LowercaseLetters,UppercaseLetters"
                                            filtermode="ValidChars"
                                            validchars=" ">    
</ajax:filteredtextboxextender>--%>

                                    </div>
                                </div>
                            </div>

                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Email Id<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">
                                        <asp:TextBox runat="server" ID="txtEMailId" MaxLength="100" Placeholder="&#xf007; Add EmailId"
                                            Style="font-family: CustomFont, FontAwesome"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="txtEMailId" Font-Bold="true"
                                            ErrorMessage="Email Id is Required !" Display="Dynamic"
                                            runat="server" />


                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" Display="Dynamic" ValidationGroup="VgGroup"
                                            runat="server" ErrorMessage="Enter valid Email Id!"
                                            ControlToValidate="txtEMailId"
                                            ValidationExpression="[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                            </div>

                            <div class="post-ad-frm margin-bottom">
                                <div class="padding border-bottom">
                                    <h3 class="h-tag padding">
                                        <b>Select State<span style="color: #f60" title="Required">*</span></b></h3>
                                </div>
                                <div class="row padding">
                                    <div class="col-sm-8">

                                        <asp:DropDownList ID="ddlState" runat="server">
                                            <asp:ListItem Text="TS" Value="TS"></asp:ListItem>
                                            <asp:ListItem Text="AP" Value="AP"></asp:ListItem>
                                        </asp:DropDownList>

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="err-class" ValidationGroup="VgGroup" ControlToValidate="ddlState" Font-Bold="true"
                                            ErrorMessage="State is Required !" Display="Dynamic"
                                            runat="server" />
                                    </div>
                                </div>
                            </div>
                        </div>

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

