<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserSignup.ascx.cs" Inherits="FilmDiziTartisma.UserControl.UserSignup" %>

<div class="form signup">
    <span class="title">Üye ol</span>
    <form id="form1" runat="server">
        <div class="input-field">
            <asp:TextBox ID="name" placeholder="Adınız" runat="server"></asp:TextBox>
            <i class="uil uil-user"></i>
        </div>
        <div class="input-field">
            <asp:TextBox ID="surname" placeholder="Soyadınız" runat="server"></asp:TextBox>
            <i class="uil uil-user"></i>
        </div>
        <div class="input-field">
            <asp:TextBox ID="email" placeholder="Email" runat="server"></asp:TextBox>
            <i class="uil uil-envelope icon"></i>
        </div>
        <div class="input-field">
            <asp:TextBox ID="password" placeholder="Şifreniz" TextMode="Password" runat="server"></asp:TextBox>
            <i class="uil uil-lock icon"></i>
        </div>
        <div class="input-field" style="display:flex; align-items:center;">
            <p style="margin-right: 10px">Yetki Seçiniz: </p>
            <asp:DropDownList ID="drp_yetki" class="select" runat="server">
                <asp:ListItem class="listitem">Kullanıcı</asp:ListItem>
                <asp:ListItem class="listitem">Yazar</asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class="checkbox-text">
            <asp:HyperLink ID="HyperLink2" class="text" runat="server" NavigateUrl="~/SifremiUnuttum">Şifremi unuttum</asp:HyperLink>
        </div>
        <div class="input-field button">
            <asp:Button ID="Button1" runat="server" Text="Kayıt Ol" OnClick="Button1_Click" />
        </div>
    </form>
    <div class="login-signup">
        <span class="text">Hesabınız varsa 
            <asp:HyperLink ID="HyperLink1" class="text login-link" runat="server" NavigateUrl="~/Giris">Giriş yap</asp:HyperLink>
        </span>
    </div>
</div>
