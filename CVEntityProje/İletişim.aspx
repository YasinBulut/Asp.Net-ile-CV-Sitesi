﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="İletişim.aspx.cs" Inherits="CVEntityProje.İletişim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table class="table table-bordered" style="margin-left: 20px; margin-right: 20px;">
        <tr>
            <th>ID</th>
            <th>AD SOYAD</th>
            <th>MAİL</th>
            <th>KONU</th>
            <th>MESAJ</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">

            <ItemTemplate>
                <tr>
                    <td><%# Eval ("ID")  %></td>
                    <td><%# Eval ("ADSOYAD")  %></td>
                    <td><%# Eval ("MAIL")  %></td>
                    <td><%# Eval ("KONU")  %></td>
                    
                   <td><asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-warning" NavigateUrl='<%# "MesajDetay.aspx?ID="+ Eval("ID") %>'>Mesajı Gör</asp:HyperLink></td>

                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </table>

</asp:Content>
