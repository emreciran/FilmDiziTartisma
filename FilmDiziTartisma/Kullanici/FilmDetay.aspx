<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="FilmDetay.aspx.cs" Inherits="FilmDiziTartisma.Kullanici.FilmDetay" %>

<%@ Register Src="~/UserControl/Kullanici/UserFilmDetay.ascx" TagPrefix="uc1" TagName="UserFilmDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserFilmDetay runat="server" id="UserFilmDetay" />
</asp:Content>
