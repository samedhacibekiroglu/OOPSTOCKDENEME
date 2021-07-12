<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="OOPSTOCKDENEME.Staff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>STAFF ID</th>
            <th>STAFF NAME</th>
            <th>STAFF SURNAME</th>
            <th>STAFF DEPARTMENT</th>
            <th>STAFF SALARY</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <td><%#Eval("STAFFID1")%></td>
                <td><%#Eval("STAFFNAME1")%></td>
                <td><%#Eval("STAFFSURNAME2")%></td>
                <td><%#Eval("STAFFDEP1")%></td>
                <td><%#Eval("STAFFSALARY1")%></td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
 <a href ="ADDSTAFF.aspx" class="btn btn-info">ADD NEW STAFF</a>
</asp:Content>
