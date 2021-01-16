<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDetay.aspx.cs" Inherits="CVEntityProje.MesajDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: 20pt;
        }
        .auto-style2 {
            font-size: 14pt;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4 class="auto-style1"><strong>MESAJ DETAYLARI</strong></h4>
    <strong><span class="auto-style2">&nbsp;&nbsp; AD/SOYAD</span></strong><br />
    <asp:TextBox ID="txtadsoyad" style=" margin-left:20px;" runat="server" CssClass="form -control" Enabled="false" Width="800px"></asp:TextBox>
    <br />
    <span class="auto-style2"><strong>&nbsp;&nbsp; MAİL:</strong></span><br />
    <asp:TextBox ID="txtmail" style=" margin-left:20px;" runat="server" CssClass="form -control" Enabled="false" Width="800px"></asp:TextBox>
    <br />
    <strong><span class="auto-style2">&nbsp;&nbsp; KONU:
    </span></strong>
    <br />
    <asp:TextBox ID="txtbaslık" style=" margin-left:20px;" runat="server" CssClass="form -control" Enabled="false" Width="800px"></asp:TextBox>
    <br />
    <strong><span class="auto-style2">&nbsp;&nbsp; MESAJ İÇERİK:</span></strong><br />
    <asp:TextBox ID="txtmesaj" style=" margin-left:20px;" runat="server" TextMode="MultiLine"  CssClass="form -control" Height="150px" Enabled="false" Width="800px"></asp:TextBox>
</asp:Content>
