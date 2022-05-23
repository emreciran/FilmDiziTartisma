<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserDiziListe.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Kullanıcı.UserDiziListe" %>

<h1>Diziler</h1>

<asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
       
    </HeaderTemplate>
    <ItemTemplate>
        <h4><%# Eval("diziAd") %></h4>
    </ItemTemplate>
    <FooterTemplate>
        
    </FooterTemplate>
</asp:Repeater>
