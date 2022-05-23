<%@ Page Title="" Language="C#" MasterPageFile="~/YazarLayout.Master" AutoEventWireup="true" CodeBehind="Film.aspx.cs" Inherits="FilmDiziTartisma.Yazar.Film" EnableEventValidation="false" %>

<%@ Register Src="~/UserControl/Yazar/UserFilm.ascx" TagPrefix="uc1" TagName="UserFilm" %>

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
    <uc1:UserFilm runat="server" ID="UserFilm" />
</asp:Content>
