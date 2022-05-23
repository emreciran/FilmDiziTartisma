<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="DiziDetay.aspx.cs" Inherits="FilmDiziTartisma.Kullanici.DiziDetay" %>

<%@ Register Src="~/UserControl/Kullanici/UserDiziDetay.ascx" TagPrefix="uc1" TagName="UserDiziDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserDiziDetay runat="server" id="UserDiziDetay" />
</asp:Content>
