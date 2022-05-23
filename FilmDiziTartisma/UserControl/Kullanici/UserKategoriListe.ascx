<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserKategoriListe.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Kullanıcı.UserKategoriListe" %>

<h1>Kategoriler</h1>

<asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
       
    </HeaderTemplate>
    <ItemTemplate>
        <h4><%# Eval("kategoriAd") %></h4>
    </ItemTemplate>
    <FooterTemplate>
        
    </FooterTemplate>
</asp:Repeater>
