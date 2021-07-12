<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ADDSALE.aspx.cs" Inherits="OOPSTOCKDENEME.ADDSALE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <form runat="server" class ="form-group">
        <div>
            <%--<asp:Label ID="Label1" runat="server" Text="CUSTOMER NAME" Font-Bold="TRUE"></asp:Label>--%>
            <asp:Label ID="Label1" runat="server" Text="SELECT PRODUCT" Font-Bold="true" Font-Italic="true"></asp:Label>
            <asp:DropDownList ID="DropDownListProduct" runat="server" CssClass ="form-control"></asp:DropDownList>
        </div>
        <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="SELECT STAFF" Font-Bold="true" Font-Italic="true"></asp:Label>
       <asp:DropDownList ID="DropDownListStaff" runat="server" CssClass ="form-control"></asp:DropDownList>
        <div>
         <br />
        </div>
            <asp:Label ID="Label3" runat="server" Text="SELECT CUSTOMER" Font-Bold="true" Font-Italic="true"></asp:Label>
            <asp:DropDownList ID="DropDownListCustomer" runat="server" CssClass ="form-control"></asp:DropDownList>
    </div>
    <br />
        <div>
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control"
                placeholder="AMOUNT"></asp:TextBox>
    </div>
    <br />
        <div>
        
            <asp:Button ID="Button1" runat="server" Text="SAVE  THE SALE" CssClass="btn-primary"/>
        </div>
    </form>
</asp:Content>
