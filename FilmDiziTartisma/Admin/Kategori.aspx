<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="Kategori.aspx.cs" Inherits="FilmDiziTartisma.Admin.Kategori" EnableEventValidation="false" %>

<%@ Register Src="~/UserControl/Admin/UserKategori.ascx" TagPrefix="uc1" TagName="UserKategori" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserKategori runat="server" ID="UserKategori" />
</asp:Content>
