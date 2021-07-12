<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Sale.aspx.cs" Inherits="OOPSTOCKDENEME.Sale" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

<table class="table table-bordered">
        <tr>
            <th>SALE ID</th>
            <th>PRODUCT NAME</th>   
            <th>STAFF</th>
            <th>CUSTOMER</th>
            <th>AMOUNT</th>
            
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <td><%#Eval("SALEID1")%></td>
                <td><%#Eval("PRODUCTNAME1")%></td>
                <td><%#Eval("STAFFNAME1")%></td>
                <td><%#Eval("CUSTOMERNAME1")%></td>
                <td><%#Eval("AMOUNT1")%></td>
                
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
     <a href ="ADDSALE.aspx" class="btn btn-info">ADD NEW SALE</a>
</asp:Content>
