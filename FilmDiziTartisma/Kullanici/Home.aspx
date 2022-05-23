<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FilmDiziTartisma.Kullanici.Home" %>

<%@ Register Src="~/UserControl/Kullanici/UserHome.ascx" TagPrefix="uc1" TagName="UserHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserHome runat="server" id="UserHome" />
</asp:Content>
