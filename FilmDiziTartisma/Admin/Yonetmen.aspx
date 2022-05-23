<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="Yonetmen.aspx.cs" Inherits="FilmDiziTartisma.Admin.Yonetmen" EnableEventValidation="false"  %>

<%@ Register Src="~/UserControl/Admin/UserYonetmen.ascx" TagPrefix="uc1" TagName="UserYonetmen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserYonetmen runat="server" ID="UserYonetmen" />
</asp:Content>
