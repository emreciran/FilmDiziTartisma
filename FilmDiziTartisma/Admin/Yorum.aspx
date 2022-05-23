<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="Yorum.aspx.cs" Inherits="FilmDiziTartisma.Admin.Yorum" EnableEventValidation="false" %>

<%@ Register Src="~/UserControl/Admin/UserYorum.ascx" TagPrefix="uc1" TagName="UserYorum" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .gridview{
            width:100%; 
        }
        .shorter{
            overflow: hidden; 
            text-overflow: ellipsis; 
            white-space: nowrap;  
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserYorum runat="server" id="UserYorum" />
</asp:Content>
