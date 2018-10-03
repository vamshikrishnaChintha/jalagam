<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Dealers-List.aspx.cs" Inherits="Dealers_List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <asp:Repeater runat="server" ID="gvDealers">
        <HeaderTemplate></HeaderTemplate>
        <ItemTemplate>
            <div class="col-lg-3">
                <div class="jha-box entthumb">



                    <div class="jha-pad font-bold">

                        <asp:HyperLink runat="server"
                            NavigateUrl='<%# String.Format("Dealer-Details.aspx?Id={0}", Eval("Id")) %>' Text='<%# Eval("DealerName", "{0}") %>'></asp:HyperLink>

                      
                        <br />
                        <asp:Label ID="lblCategory" Text='<%#Eval("City") %>' runat="server"></asp:Label>
                        </br>
                       
                    </div>



                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>


</asp:Content>

