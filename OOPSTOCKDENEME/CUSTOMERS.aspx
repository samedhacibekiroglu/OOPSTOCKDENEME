<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="CUSTOMERS.aspx.cs" Inherits="OOPSTOCKDENEME.CUSTOMER" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table class="table table-bordered">
        <tr>
            <th>CUSTOMER ID</th>
            <th>CUSTOMER NAME</th>
            <th>CUSTOMER SURNAME</th>
            <th>DELETE CUSTOMER</th>
            <th>UPDATE CUSTOMER</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <td><%#Eval("CUSTOMERID1")%></td>
                <td><%#Eval("CUSTOMERNAME1")%></td>
                <td><%#Eval("CUSTOMERSURNAME1")%></td>
                <td><asp:HyperLink NavigateUrl='<%# "~/CUSTOMERDELETE.aspx?CUSTOMERID=" + Eval("CUSTOMERID1") %>' ID="HyperLink1" runat="server" CssClass ="btn btn-danger">DELETE CUSTOMER</asp:HyperLink></td>
                <td><asp:HyperLink NavigateUrl='<%# "~/UPDATECUSTOMER.aspx?CUSTOMERID=" + Eval("CUSTOMERID1") %>' ID="HyperLink2" runat="server" CssClass ="btn btn-warning">UPDATE CUSTOMER</asp:HyperLink></td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href ="ADDCUSTOMER.aspx" class="btn btn-info">ADD NEW CUSTOMER</a>
</asp:Content>
 