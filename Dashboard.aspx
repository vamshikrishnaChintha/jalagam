<%@ Page Title="" Language="C#" MasterPageFile="~/Post-Ad.master" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:UpdatePanel ID="updateP" runat="server">
        <ContentTemplate>
            <div class="desc-page">
                <div class="row margin jhkfrm">
                    <div class="col-sm-8 login-centered">

                        <div class="teamgrids row">
                            <div class="col-md-2  col-xs-12 teamgrid1 ">
                                <div class="admin-category-list active-link txtcenter">
                                    <img src="images/admin-dashboard-icon.png" /><br />
                                    <a href="Dashboard.aspx">Dashboard</a>
                                </div>
                            </div>
                            <div class="col-md-2  col-xs-6 teamgrid1 ">
                                <div class="admin-category-list  txtcenter">
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





                        <div class="head-color">
                            <h5><b>User Details (Contact Us)</b></h5>
                        </div>

                        <asp:GridView ID="gvContact" DataKeyNames="Id" runat="server" PagerSettings-Visible="true" CssClass="bg-color bg-color table table-bordered table-condensed"
                            ShowHeader="true" AutoGenerateColumns="false" AllowPaging="true" PageSize="3"
                            HorizontalAlign="center" OnPageIndexChanging="gvContact_PageIndexChanging">
                            <Columns>

                                <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="150" />
                                <asp:BoundField DataField="EmailId" HeaderText="Email Id" ItemStyle-Width="150" />
                                <asp:BoundField DataField="ContactNo" HeaderText="Contact No." ItemStyle-Width="150" />
                                <asp:BoundField DataField="Reason" HeaderText="Reason" ItemStyle-Width="150" />
                                <asp:BoundField DataField="PostedDate" HeaderText="Posted Date" ItemStyle-Width="150" />




                            </Columns>
                            <PagerSettings Visible="true" />
                            <PagerStyle CssClass="jhkpagination" />
                        </asp:GridView>



                        <div class="head-color">
                            <h5><b>Accessories</b></h5>
                        </div>

                        <asp:GridView ID="gvAccessories" DataKeyNames="Id" runat="server" PagerSettings-Visible="true" CssClass="bg-color bg-color table table-bordered table-condensed"
                            ShowHeader="false" AutoGenerateColumns="false" AllowPaging="true" PageSize="3"
                            HorizontalAlign="center" OnRowDataBound="gvAccessories_RowDataBound" OnPageIndexChanging="gvAccessories_PageIndexChanging" OnRowCancelingEdit="gvAccessories_RowCancelingEdit" OnRowDeleted="gvAccessories_RowDeleted" OnRowDeleting="gvAccessories_RowDeleting" OnRowEditing="gvAccessories_RowEditing" OnRowUpdating="gvAccessories_RowUpdating">
                            <Columns>
                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                        <div class="row">
                                            <%-- <div class="col-sm-3">
                            <asp:Image ID="imgArticle" runat="server" onerror="if (this.src != 'images/no-photo.png') this.src = 'images/no-photo.gif';" Width="100" Height="100" HtmlEncode="false" ImageUrl='<%# "LoadPhoto.aspx?ArticlePhoto=" + Eval("ArticleId")%>' />
                        </div>--%>
                                            <div class="col-sm-12 col-xs-12 col-md-12 col-lg-9">
                                                <div>

                                                    <a href='jalagam-accessories-<%#Eval("accessDetail").ToString() %>'>
                                                        <asp:Label ID="lblaccess" runat="server" Text='<%#Eval("Title") %>' Style="color: #db0f31!important" CssClass="txtflow" /></a>


                                                    <%-- <asp:HyperLink runat="server"
                                                            NavigateUrl='<%# String.Format("accessories-Detail.aspx?Id={0}", Eval("Id")) %>' Text='<%# Eval("Title", "{0}") %>'></asp:HyperLink>--%>
                                                </div>
                                                <div class="sub-button" style="text-align: right;">
                                                    <asp:Button runat="server" ButtonType="Button" CommandName="Delete" Text="Delete" />
                                                    <asp:Button runat="server" ButtonType="Button" CommandName="Update" Text="Edit" />
                                                </div>
                                            </div>

                                        </div>
                                    </ItemTemplate>
                                </asp:TemplateField>


                            </Columns>
                            <PagerSettings Visible="true" />
                            <PagerStyle CssClass="jhkpagination" />
                        </asp:GridView>

                        <div class="head-color">
                            <h5><b>Branches</b></h5>
                        </div>

                        <asp:GridView ID="gvBranch" DataKeyNames="Id" runat="server" PagerSettings-Visible="true" CssClass="bg-color bg-color table table-bordered table-condensed"
                            ShowHeader="false" AutoGenerateColumns="false" AllowPaging="true" PageSize="3"
                            HorizontalAlign="center" OnRowDataBound="gvBranch_RowDataBound" OnPageIndexChanging="gvBranch_PageIndexChanging" OnRowCancelingEdit="gvBranch_RowCancelingEdit" OnRowDeleted="gvBranch_RowDeleted" OnRowDeleting="gvBranch_RowDeleting" OnRowEditing="gvBranch_RowEditing" OnRowUpdating="gvBranch_RowUpdating">
                            <Columns>
                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                        <div class="row">
                                            <%-- <div class="col-sm-3">
                            <asp:Image ID="imgArticle" runat="server" onerror="if (this.src != 'images/no-photo.png') this.src = 'images/no-photo.gif';" Width="100" Height="100" HtmlEncode="false" ImageUrl='<%# "LoadPhoto.aspx?ArticlePhoto=" + Eval("ArticleId")%>' />
                        </div>--%>
                                            <div class="col-sm-12 col-xs-12 col-md-12 col-lg-9">
                                                <div>


                                                    <%-- <asp:Label ID="lblCategory" Text='<%#Eval("Title") %>' runat="server"></asp:Label>--%>

                                                    <asp:HyperLink runat="server"
                                                        NavigateUrl='<%# String.Format("Branch-Details.aspx?Id={0}", Eval("Id")) %>' Style="color: #db0f31!important" Text='<%# Eval("Title", "{0}") %>'></asp:HyperLink>
                                                </div>
                                                <div class="sub-button" style="text-align: right;">
                                                    <asp:Button runat="server" ButtonType="Button" CommandName="Delete" Text="Delete" />
                                                    <asp:Button runat="server" ButtonType="Button" CommandName="Update" Text="Edit" />
                                                </div>
                                            </div>

                                        </div>
                                    </ItemTemplate>
                                </asp:TemplateField>


                            </Columns>
                            <PagerSettings Visible="true" />
                            <PagerStyle CssClass="jhkpagination" />
                        </asp:GridView>

                        <div class="head-color">
                            <h5><b>Dealers</b></h5>
                        </div>

                        <asp:GridView ID="gvDealer" DataKeyNames="Id" runat="server" PagerSettings-Visible="true" CssClass="bg-color bg-color table table-bordered table-condensed"
                            ShowHeader="false" AutoGenerateColumns="false" AllowPaging="true" PageSize="3"
                            HorizontalAlign="center" OnRowDataBound="gvDealer_RowDataBound" OnPageIndexChanging="gvDealer_PageIndexChanging" OnRowCancelingEdit="gvDealer_RowCancelingEdit" OnRowDeleted="gvDealer_RowDeleted" OnRowDeleting="gvDealer_RowDeleting" OnRowEditing="gvDealer_RowEditing" OnRowUpdating="gvDealer_RowUpdating">
                            <Columns>
                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                        <div class="row">
                                            <%-- <div class="col-sm-3">
                            <asp:Image ID="imgArticle" runat="server" onerror="if (this.src != 'images/no-photo.png') this.src = 'images/no-photo.gif';" Width="100" Height="100" HtmlEncode="false" ImageUrl='<%# "LoadPhoto.aspx?ArticlePhoto=" + Eval("ArticleId")%>' />
                        </div>--%>
                                            <div class="col-sm-12 col-xs-12 col-md-12 col-lg-9">
                                                <div>

                                                    <asp:HyperLink runat="server"
                                                        NavigateUrl='<%# String.Format("Dealer-Details.aspx?Id={0}", Eval("Id")) %>' Style="color: #db0f31!important" Text='<%# Eval("Title", "{0}") %>'></asp:HyperLink>
                                                    <br />

                                                    Status:<asp:Label ID="Label1" runat="server" Text='<%#Eval("Status") %>' ForeColor="Green" /></a>
                                  <%--  <asp:Label ID="lblCategory" Text='<%#Eval("Title") %>' runat="server"></asp:Label>--%>

                                                    <%-- <asp:HyperLink runat="server"
                                    NavigateUrl='<%# String.Format("accessories-Detail.aspx?Id={0}", Eval("Id")) %>' Text='<%# Eval("Title", "{0}") %>'></asp:HyperLink>--%>
                                                </div>
                                                <div class="sub-button" style="text-align: right;">
                                                    <asp:Button runat="server" ButtonType="Button" CommandName="Delete" Text="Delete" />
                                                    <asp:Button runat="server" ButtonType="Button" CommandName="Update" Text="Edit" />
                                                </div>
                                            </div>

                                        </div>
                                    </ItemTemplate>
                                </asp:TemplateField>


                            </Columns>
                            <PagerSettings Visible="true" />
                            <PagerStyle CssClass="jhkpagination" />
                        </asp:GridView>

                        <div class="head-color">
                            <h5><b>Products</b></h5>
                        </div>

                        <asp:GridView ID="gvproduct" DataKeyNames="Id" runat="server" PagerSettings-Visible="true" CssClass="bg-color bg-color table table-bordered table-condensed"
                            ShowHeader="false" AutoGenerateColumns="false" AllowPaging="true" PageSize="3"
                            HorizontalAlign="center" OnRowDataBound="gvproduct_RowDataBound" OnPageIndexChanging="gvproduct_PageIndexChanging" OnRowCancelingEdit="gvproduct_RowCancelingEdit" OnRowDeleted="gvproduct_RowDeleted" OnRowDeleting="gvproduct_RowDeleting" OnRowEditing="gvproduct_RowEditing" OnRowUpdating="gvproduct_RowUpdating">
                            <Columns>
                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                        <div class="row">
                                            <%-- <div class="col-sm-3">
                            <asp:Image ID="imgArticle" runat="server" onerror="if (this.src != 'images/no-photo.png') this.src = 'images/no-photo.gif';" Width="100" Height="100" HtmlEncode="false" ImageUrl='<%# "LoadPhoto.aspx?ArticlePhoto=" + Eval("ArticleId")%>' />
                        </div>--%>
                                            <div class="col-sm-12 col-xs-12 col-md-12 col-lg-9">
                                                <div>


                                                    <%-- <asp:Label ID="lblCategory" Text='<%#Eval("Title") %>' runat="server"></asp:Label>--%>

                                                    <%--   <asp:HyperLink runat="server"
                                    NavigateUrl='<%# String.Format("Product-Detail.aspx?Id={0}", Eval("Id")) %>' Text='<%# Eval("Title", "{0}") %>'></asp:HyperLink>--%>

                                                    <a href='Product-<%#Eval("ProductDetail").ToString() %>'>
                                                        <asp:Label ID="lblProduct" runat="server" Width="20%" Text='<%#Eval("Title") %>' Style="color: #db0f31!important" CssClass="txtflow" /></a>



                                                </div>
                                                <div class="sub-button" style="text-align: right;">
                                                    <asp:Button runat="server" ButtonType="Button" CommandName="Delete" Text="Delete" />
                                                    <asp:Button runat="server" ButtonType="Button" CommandName="Update" Text="Edit" />
                                                </div>
                                            </div>

                                        </div>
                                    </ItemTemplate>
                                </asp:TemplateField>


                            </Columns>
                            <PagerSettings Visible="true" />
                            <PagerStyle CssClass="jhkpagination" />
                        </asp:GridView>

                        <div class="head-color">
                            <h5><b>Test Driving</b></h5>
                        </div>

                        <asp:GridView ID="gvTestDriving" DataKeyNames="Id" runat="server" PagerSettings-Visible="true" CssClass="bg-color bg-color table table-bordered table-condensed"
                            ShowHeader="false" AutoGenerateColumns="false" AllowPaging="true" PageSize="3"
                            HorizontalAlign="center" OnRowDataBound="gvTestDriving_RowDataBound" OnPageIndexChanging="gvTestDriving_PageIndexChanging" OnRowCancelingEdit="gvTestDriving_RowCancelingEdit" OnRowDeleted="gvTestDriving_RowDeleted" OnRowDeleting="gvTestDriving_RowDeleting" OnRowEditing="gvTestDriving_RowEditing" OnRowUpdating="gvTestDriving_RowUpdating">
                            <Columns>
                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                        <div class="row">
                                            <%-- <div class="col-sm-3">
                            <asp:Image ID="imgArticle" runat="server" onerror="if (this.src != 'images/no-photo.png') this.src = 'images/no-photo.gif';" Width="100" Height="100" HtmlEncode="false" ImageUrl='<%# "LoadPhoto.aspx?ArticlePhoto=" + Eval("ArticleId")%>' />
                        </div>--%>
                                            <div class="col-sm-12 col-xs-12 col-md-12 col-lg-9">
                                                <div>


                                                    <%--  <asp:Label ID="lblCategory" Text='<%#Eval("Title") %>' runat="server"></asp:Label>--%>

                                                    <asp:HyperLink runat="server" Style="color: #db0f31!important"
                                                        NavigateUrl='<%# String.Format("Test-Drive-Details.aspx?Id={0}", Eval("Id")) %>' Text='<%# Eval("Title", "{0}") %>'></asp:HyperLink>
                                                </div>
                                                <div class="sub-button" style="text-align: right;">
                                                    <asp:Button runat="server" ButtonType="Button" CommandName="Delete" Text="Delete" />
                                                    <asp:Button runat="server" ButtonType="Button" CommandName="Update" Text="Edit" />
                                                </div>
                                            </div>

                                        </div>
                                    </ItemTemplate>
                                </asp:TemplateField>


                            </Columns>
                            <PagerSettings Visible="true" />
                            <PagerStyle CssClass="jhkpagination" />
                        </asp:GridView>



                        <div class="head-color">
                            <h5><b>Photo Gallery</b></h5>
                        </div>

                        <asp:GridView ID="gvPhotoGallery" DataKeyNames="Id" runat="server" PagerSettings-Visible="true" CssClass="bg-color bg-color table table-bordered table-condensed"
                            ShowHeader="false" AutoGenerateColumns="false" AllowPaging="true" PageSize="3"
                            HorizontalAlign="center" OnRowDataBound="gvPhotoGallery_RowDataBound" OnPageIndexChanging="gvPhotoGallery_PageIndexChanging" OnRowCancelingEdit="gvPhotoGallery_RowCancelingEdit" OnRowDeleted="gvPhotoGallery_RowDeleted" OnRowDeleting="gvPhotoGallery_RowDeleting" OnRowEditing="gvPhotoGallery_RowEditing" OnRowUpdating="gvPhotoGallery_RowUpdating">
                            <Columns>
                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                        <div class="row">

                                            <div class="col-sm-12 col-xs-12 col-md-12 col-lg-9">
                                                <div>

                                                    <asp:HyperLink runat="server" Style="color: #db0f31!important"
                                                        NavigateUrl='<%# String.Format("Photo-Gallery-Detail.aspx?Id={0}", Eval("Id")) %>' Text='<%# Eval("Title", "{0}") %>'></asp:HyperLink>
                                                </div>
                                                <div class="sub-button" style="text-align: right;">
                                                    <asp:Button runat="server" ButtonType="Button" CommandName="Delete" Text="Delete" />
                                                    <asp:Button runat="server" ButtonType="Button" CommandName="Update" Text="Edit" />
                                                </div>
                                            </div>

                                        </div>
                                    </ItemTemplate>
                                </asp:TemplateField>

                            </Columns>
                            <PagerSettings Visible="true" />
                            <PagerStyle CssClass="jhkpagination" />
                        </asp:GridView>

                        <div class="head-color">
                            <h5><b>Dealer Apporval</b></h5>
                        </div>



                        <asp:GridView ID="gvDealerApproval" runat="server" DataKeyNames="Id" PagerSettings-Visible="true" CssClass="bg-color table table-bordered table-condensed"
                            ShowHeader="false" AutoGenerateColumns="false" AllowPaging="true" PageSize="3"
                            HorizontalAlign="center" OnRowDataBound="gvDealerApproval_RowDataBound" OnPageIndexChanging="gvDealerApproval_PageIndexChanging" OnRowCancelingEdit="gvDealerApproval_RowCancelingEdit" OnRowDeleted="gvDealerApproval_RowDeleted" OnRowDeleting="gvDealerApproval_RowDeleting" OnRowEditing="gvDealerApproval_RowEditing" OnRowUpdating="gvDealerApproval_RowUpdating">
                            <Columns>
                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>

                                        <div class="col-sm-10 col-xs-12 col-md-10 col-lg-10">
                                            <div class="row">

                                                <asp:HyperLink runat="server" Style="color: #db0f31!important"
                                                    NavigateUrl='<%# String.Format("Dealer-Details.aspx?Id={0}", Eval("Id")) %>' Text='<%# Eval("Title", "{0}") %>'></asp:HyperLink>
                                            </div>
                                        </div>

                                        <div class="col-sm-10 col-xs-12 col-md-10 col-lg-10">
                                            <div class="row">
                                                Status:<asp:Label ID="Label1" runat="server" Text='<%#Eval("Status") %>' ForeColor="Green" /></a>
											
                                            </div>
                                        </div>
                                    </ItemTemplate>

                                </asp:TemplateField>

                                <%-- <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />--%>
                                <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Approve" />
                            </Columns>
                            <PagerStyle CssClass="jhkpagination" />
                        </asp:GridView>



                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

