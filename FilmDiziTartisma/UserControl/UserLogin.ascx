<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.ascx.cs" Inherits="FilmDiziTartisma.UserControl.UserLogin" %>

<div class="forms" style="display:flex; justify-content:center; align-items:center;">
    <div class="form login">
        <span class="title">Giriş yap</span>

        <form action="#" runat="server">
            <div class="input-field">
                <asp:TextBox ID="txt_email" runat="server" type="text" placeholder="E-postanızı giriniz" required="required"></asp:TextBox>
                <i class="uil uil-envelope icon"></i>
            </div>
            <div class="input-field">
                <asp:TextBox ID="txt_password" runat="server" type="password" class="password" placeholder="Şifrenizi giriniz" required="required"></asp:TextBox>
                <i class="uil uil-lock icon"></i>
                <i class="uil uil-eye-slash showHidePw"></i>
            </div>

            <div class="input-field" style="display: flex; align-items: center;">
                <p style="margin-right: 10px">Yetki Seçiniz: </p>
                <asp:DropDownList ID="drp_yetki" class="select" runat="server">
                    <asp:ListItem class="listitem">Kullanıcı</asp:ListItem>
                    <asp:ListItem class="listitem">Yazar</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="checkbox-text">
                <asp:HyperLink ID="HyperLink1" class="text" runat="server" NavigateUrl="~/SifremiUnuttum">Şifremi unuttum</asp:HyperLink>
            </div>

            <div class="input-field button">
                <asp:Button ID="btn_giris_yap" runat="server" Text="Giriş Yap" OnClick="btn_giris_yap_Click" />
            </div>
        </form>

        <div class="login-signup">
            <span class="text">Hesabınız mı yok?
                <asp:HyperLink ID="HyperLink3" class="text signup-link" runat="server" NavigateUrl="~/Kayit">Kayıt ol</asp:HyperLink>
            </span>
        </div>
    </div>
</div>