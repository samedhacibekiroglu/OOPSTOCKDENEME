<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="OOPSTOCKDENEME.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th> DEPARTMENT ID </th>
            <th> DEPARTMENT NAME </th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server"> 
                <ItemTemplate> 
                    <tr>
                        <td><%#Eval("DepartmentId1")%></td>
                        <td><%#Eval("DepartmentName1")%></td>
                    </tr>
                </ItemTemplate>

            </asp:Repeater>
            
        </tbody>
    </table>
<a href ="ADD DEPARTMENT.aspx" class="btn btn-info">ADD NEW DEPARTMENT</a>
</asp:Content>
