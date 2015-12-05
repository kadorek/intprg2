<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SabitBilgiEkle.aspx.cs" Inherits="OrnekSite.Admin.SabitBilgiEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>
       <b>kod:</b> <input type="text" runat="server" id="txtKod" />
    </div>
    <div>
        <b>isim:</b> <input type="text" runat="server" id="txtIsim" />
    </div>
    <div>
        <b>deger:</b> <input type="text" runat="server" id="txtDeger" />
    </div>
    <div>
        <b>aktifmi:</b> <input type="checkbox" runat="server" id="chkAktifmi" />
    </div>
    <div>
        <input type="submit" value="ekle" runat="server" id="btnEkle"  onserverclick="btnEkle_ServerClick"/>
    </div> 
</asp:Content>
