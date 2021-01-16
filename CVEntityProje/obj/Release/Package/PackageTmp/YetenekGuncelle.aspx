<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGuncelle.aspx.cs" Inherits="CVEntityProje.YetenekGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>YETENEK GÜNCELLEME SAYFASI</h2>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Yetenek"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-group" OnClick="Button1_Click"  />

</asp:Content>
