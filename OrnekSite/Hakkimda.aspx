<%@ Page Title="" Language="C#" MasterPageFile="~/Sablon.Master" AutoEventWireup="true" CodeBehind="Hakkimda.aspx.cs" Inherits="OrnekSite.Hakkimda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:DropDownList ID="ddlZaman" runat="server" OnSelectedIndexChanged="ddlZaman_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Text="Seçiniz.." Value="0"></asp:ListItem>
            
            <asp:ListItem Text="Ortaokul" Value="1"></asp:ListItem>
            
            <asp:ListItem Text="Lise" Value="2"></asp:ListItem>
            
            <asp:ListItem Text="Üniversite" Value="3"></asp:ListItem>
        </asp:DropDownList>
    </div>
    <div runat="server" id="orta">A</div>
    <div runat="server" id="lise">B</div>
    <div runat="server" id="uni">C</div>
</asp:Content>
