<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="FilmDiziTartisma.Kullanici.Profil" %>

<%@ Register Src="~/UserControl/Kullanici/UserProfil.ascx" TagPrefix="uc1" TagName="UserProfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserProfil runat="server" ID="UserProfil" />
</asp:Content>
