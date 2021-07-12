<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ADDPRODUCT.aspx.cs" Inherits="OOPSTOCKDENEME.ADDPRODUCT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class ="form-group">
        <div>
            <%--<asp:Label ID="Label1" runat="server" Text="CUSTOMER NAME" Font-Bold="TRUE"></asp:Label>--%>
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control"
                placeholder="PLEASE ENTER THE PRODUCT NAME"></asp:TextBox>
        </div>
        <br />
    <div>
        <asp:TextBox ID="TextBox2" runat="server" CssClass ="form-control"
                placeholder="PLEASE ENTER THE PRODUCT PIECE"></asp:TextBox>
        
    </div>
    <br />
        <div>
            <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control"
                placeholder="PLEASE ENTER THE PRODUCT PRIECE"></asp:TextBox>
            </div>
    <br />
        <div>
        
            <asp:Button ID="Button1" runat="server" Text="SAVE PRODUCT NAME" CssClass="btn-primary" OnClick="Button1_Click"/>

        </div>
    </form>
</asp:Content>
