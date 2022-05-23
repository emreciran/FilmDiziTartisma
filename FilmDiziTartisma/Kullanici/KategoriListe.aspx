<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="KategoriListe.aspx.cs" Inherits="FilmDiziTartisma.Kullanici.KategoriListe" %>

<%@ Register Src="~/UserControl/Kullanici/UserKategoriListe.ascx" TagPrefix="uc1" TagName="UserKategoriListe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserKategoriListe runat="server" ID="UserKategoriListe" />
</asp:Content>
