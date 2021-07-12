<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ADD DEPARTMENT.aspx.cs" Inherits="OOPSTOCKDENEME.ADD_DEPARTMENT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class ="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="DEPARTMENT NAME" Font-Bold="TRUE"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control"
                placeholder="PLEASE ENTER THE DEPARTMENT NAME"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="SAVE DEPARTMENT NAME" CssClass="btn-primary" OnClick="Button1_Click" />

        </div>
    </form>
</asp:Content>
