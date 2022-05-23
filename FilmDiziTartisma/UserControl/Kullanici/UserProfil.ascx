<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserProfil.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Kullanıcı.UserProfil" %>

<h1>Profil</h1>

<asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>
        <h4><%# Eval("uyeAd") %></h4>
        <h4><%# Eval("uyeSoyad") %></h4>
        <h4><%# Eval("uyeEmail") %></h4>
        <h4><%# Eval("uyePassword") %></h4>
        <h4><%# Eval("uyeYetki") %></h4>
    </ItemTemplate>
</asp:DataList>

