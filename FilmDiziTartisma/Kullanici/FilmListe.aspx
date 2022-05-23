<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="FilmListe.aspx.cs" Inherits="FilmDiziTartisma.Kullanici.FilmListe" %>

<%@ Register Src="~/UserControl/Kullanici/UserFilmListe.ascx" TagPrefix="uc1" TagName="UserFilmListe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserFilmListe runat="server" ID="UserFilmListe" />
</asp:Content>
