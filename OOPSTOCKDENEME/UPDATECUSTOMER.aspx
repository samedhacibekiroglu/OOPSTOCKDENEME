<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UPDATECUSTOMER.aspx.cs" Inherits="OOPSTOCKDENEME.UPDATECUSTOMER" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form runat="server" class ="form-group">
        <div>
            <%--<asp:Label ID="Label1" runat="server" Text="CUSTOMER NAME" Font-Bold="TRUE"></asp:Label>--%>
             <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control"
                placeholder="PLEASE ENTER THE CUSTOMER ID" Enabled="False"></asp:TextBox>
        </div>
        <br />
    <div>
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control"
                placeholder="PLEASE ENTER THE CUSTOMER NAME"></asp:TextBox>
        </div>
        <br />
    <div>
        <asp:TextBox ID="TextBox2" runat="server" CssClass ="form-control"
                placeholder="PLEASE ENTER THE CUSTOMER SURNAME"></asp:TextBox>
        
    </div>
    <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="UPDATE CUSTOMER" CssClass="btn btn-success" OnClick="Button1_Click" />

        </div>
    </form>
</asp:Content>
