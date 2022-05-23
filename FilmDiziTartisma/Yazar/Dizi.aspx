<%@ Page Title="" Language="C#" MasterPageFile="~/YazarLayout.Master" AutoEventWireup="true" CodeBehind="Dizi.aspx.cs" Inherits="FilmDiziTartisma.Yazar.Dizi" EnableEventValidation="false" %>

<%@ Register Src="~/UserControl/Yazar/UserDizi.ascx" TagPrefix="uc1" TagName="UserDizi" %>

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
    <uc1:UserDizi runat="server" ID="UserDizi" />
</asp:Content>
