<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ADDSTAFF.aspx.cs" Inherits="OOPSTOCKDENEME.ADDSTAFF" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class ="form-group">
        <div>
            <%--<asp:Label ID="Label1" runat="server" Text="CUSTOMER NAME" Font-Bold="TRUE"></asp:Label>--%>
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control"
                placeholder="PLEASE ENTER THE STAFF NAME"></asp:TextBox>
        </div>
        <br />
    <div>
        <asp:TextBox ID="TextBox2" runat="server" CssClass ="form-control"
                placeholder="PLEASE ENTER THE STAFF SURNAME"></asp:TextBox>
    </div>
    <br />
        <div>
            <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control"
                placeholder="PLEASE ENTER THE STAFF SALARY"></asp:TextBox>
        <div>
         <br />
        </div>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass ="form-control"></asp:DropDownList>
    </div>
    <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="SAVE  THE STAFF" CssClass="btn-primary"  OnClick="Button1_Click"/>
        </div>
    </form>
</asp:Content>
