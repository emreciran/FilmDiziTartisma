<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="KullaniciListe.aspx.cs" Inherits="FilmDiziTartisma.Admin.KullaniciListe" %>

<%@ Register Src="~/UserControl/Admin/UserKullaniciListe.ascx" TagPrefix="uc1" TagName="UserKullaniciListe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserKullaniciListe runat="server" ID="UserKullaniciListe" />
</asp:Content>
