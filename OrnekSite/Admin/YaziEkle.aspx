<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="YaziEkle.aspx.cs" Inherits="OrnekSite.Admin.YaziEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <b>BASLIK:</b><asp:TextBox ID="txtBaslik" runat="server"></asp:TextBox>
    </div>
    <div>
        <b>METIN:</b><asp:TextBox ID="txtMetin" TextMode="MultiLine" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnEkle" OnClick="btnEkle_Click" runat="server" Text="Button" />
    </div>
</asp:Content>
