<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="DiziListe.aspx.cs" Inherits="FilmDiziTartisma.Kullanici.DiziListe" %>

<%@ Register Src="~/UserControl/Kullanici/UserDiziListe.ascx" TagPrefix="uc1" TagName="UserDiziListe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserDiziListe runat="server" ID="UserDiziListe" />
</asp:Content>
