<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Our-Products.aspx.cs" Inherits="Our_Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <img src="images/jslide-02-inner.jpg" alt="" width="100%" />
    </div>

    <div class="txtcenter padding-top padding-bottom ">
        <h3><b>Our Products</b></h3>
    </div>
    <div class="container margin-top-20">
        <div class="teamgrids row">

            <asp:Repeater runat="server" ID="gvProducts">
                <HeaderTemplate></HeaderTemplate>
                <ItemTemplate>
                    <div class="col-md-3  col-sm-12 teamgrid1 padding-bottom-20">
                        <div class="div-border padding  box-shadow ">
                            <div>

                             <%--   <a href='product-<%#Eval("ProductDetail").ToString() %>'>
                                    <asp:Label ID="lblaccess" runat="server" Width="20%" Text='<%#Eval("ProductName") %>' CssClass="txtflow" /></a>--%>
                                <a href='product-<%#Eval("ProductDetail").ToString() %>'>
                                    <asp:Image ID="imgGallery" ALT='<%#Eval("ProductName") %>' runat="server" Height="150px" Width="100%" ImageUrl='<%# "Load-Image.aspx?DisplayPhoto=" + Eval("Id")%>' />
                                </a>
                            </div>
                            <div class="margin-top">
                                <h6><b>
                                   <%-- <asp:HyperLink ID="HyperLink1" Width="20%" Text='<%#Eval("ProductName") %>' ToolTip='<%# Eval("ProductName") %>' runat="server" Target="_blank" CssClass="txtflow" Style="color: #db0f31!important" NavigateUrl='<%# String.Format("Product-Detail.aspx?Id={0}", Eval("Id"))%>'></asp:HyperLink>--%>

                                    <a href='product-<%#Eval("ProductDetail").ToString() %>'>
                                        <asp:Label ID="lblProduct" runat="server" Width="20%" Text='<%#Eval("ProductName") %>' Style="color: #db0f31!important" CssClass="txtflow" /></a>

                                    </b>
                                </h6>
                            </div>
                            <%-- <asp:Label ID="Label1" Text='<%#Eval("ProductName") %>' runat="server"></asp:Label>--%>


                            <%-- Price: <asp:Label ID="Label2" Text='<%#Eval("Price") %>' runat="server"></asp:Label>
                            </br>--%>
                        Color:
                            <asp:Label ID="Label3" Text='<%#Eval("Color") %>' runat="server"></asp:Label>
                            <div class="margin-top">
                                <a href='product-<%#Eval("ProductDetail").ToString() %>' class="more-btn" style="color: #fff!important;">Read more</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>

