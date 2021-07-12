<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PRODUCTS.aspx.cs" Inherits="OOPSTOCKDENEME.PRODUCT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>PRODUCT ID</th>
            <th>PRODUCT NAME</th>
            <th>PRODUCT PRICE</th>
            <th>PRODUCT PIECE</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <td><%#Eval("PRODUCTID1")%></td>
                <td><%#Eval("PRODUCTNAME1")%></td>
                <td><%#Eval("PRODUCTPRICE1")%></td>
                 <td><%#Eval("PRODUCTPIECE1")%></td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href ="ADDPRODUCT.aspx" class="btn btn-info">ADD NEW PRODUCT</a>
</asp:Content>
