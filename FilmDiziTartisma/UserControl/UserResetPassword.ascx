<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserResetPassword.ascx.cs" Inherits="FilmDiziTartisma.UserControl.UserResetPassword" %>

<div class="forms">
    <div class="form login">
        <span class="title">Şifre Sıfırlama</span>

        <form action="#" runat="server">
            <div class="input-field">
                <asp:TextBox ID="txt_new_password" runat="server" placeholder="Yeni şifrenizi giriniz" required="required" />
                <i class="uil uil-envelope icon"></i>
            </div>
            <div class="input-field">
                <asp:TextBox ID="txt_confirm_password" runat="server" placeholder="Şifrenizi doğrulayınız" required="required" />
                <i class="uil uil-envelope icon"></i>
            </div>

            <div class="input-field button">
                <asp:Button ID="reset_password" runat="server" Text="Şifremi Sıfırla" OnClick="reset_password_Click"/>
            </div>
        </form>

    </div>
</div>
