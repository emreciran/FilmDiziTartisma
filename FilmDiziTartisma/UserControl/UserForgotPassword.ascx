<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserForgotPassword.ascx.cs" Inherits="FilmDiziTartisma.UserControl.UserForgotPassword" %>

<div class="forms" style="display:flex; align-items:center; justify-content:center;">
    <div class="form login">
        <span class="title">Şifremi unuttum</span>

        <form action="#" runat="server">
            <div class="input-field">
                <asp:TextBox ID="txt_email" runat="server" placeholder="E-postanızı giriniz" required="required" />
                <i class="uil uil-envelope icon"></i>
            </div>

            <div class="input-field button">
                <asp:Button ID="forgot_password" runat="server" Text="Devam" OnClick="forgot_password_Click" />
            </div>

            <div class="login-signup">
                <span class="text">Hesabınız varsa 
                    <asp:HyperLink ID="HyperLink1" class="text login-link" runat="server" NavigateUrl="~/Giris">Giriş yap</asp:HyperLink>
                </span>
            </div>
        </form>

    </div>
</div>
