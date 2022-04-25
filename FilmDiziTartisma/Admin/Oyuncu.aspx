<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="Oyuncu.aspx.cs" Inherits="FilmDiziTartisma.Admin.Oyuncu" %>

<%@ Register Src="~/UserControl/Admin/UserOyuncu.ascx" TagPrefix="uc1" TagName="UserOyuncu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserOyuncu runat="server" ID="UserOyuncu" />
</asp:Content>
