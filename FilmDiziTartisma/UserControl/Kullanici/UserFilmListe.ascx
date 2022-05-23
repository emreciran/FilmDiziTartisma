<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserFilmListe.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Kullanıcı.UserFilmListe" %>

<h1>Filmler</h1>

<asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
       
    </HeaderTemplate>
    <ItemTemplate>
        <h4><%# Eval("filmAd") %></h4>
    </ItemTemplate>
    <FooterTemplate>
        
    </FooterTemplate>
</asp:Repeater>
