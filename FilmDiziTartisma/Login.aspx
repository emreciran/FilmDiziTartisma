<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FilmDiziTartisma.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.0/css/line.css" />
    <link rel="stylesheet" href="assets/css/form.css" />
</head>
<body>
        <div class="container">
        <div class="forms">
            <div class="form login">
                <span class="title">Giriş yap</span>

                <form action="#">
                    <div class="input-field">
                        <input type="text" placeholder="E-postanızı giriniz" required="required" />
                        <i class="uil uil-envelope icon"></i>
                    </div>
                    <div class="input-field">
                        <input type="password" class="password" placeholder="Şifrenizi giriniz" required="required" />
                        <i class="uil uil-lock icon"></i>
                        <i class="uil uil-eye-slash showHidePw"></i>
                    </div>

                    <div class="checkbox-text">
                        <div class="checkbox-content">
                            <input type="checkbox" id="logCheck" />
                            <label for="logCheck" class="text">Beni hatırla</label>
                        </div>
                        <asp:HyperLink ID="HyperLink1" class="text" runat="server" NavigateUrl="~/ForgotPassword.aspx">Şifremi unuttum</asp:HyperLink>
                    </div>

                    <div class="input-field button">
                        <input type="button" value="Giriş yap" />
                    </div>
                </form>

                <div class="login-signup">
                    <span class="text">Hesabınız mı yok?
                        <asp:HyperLink ID="HyperLink3" class="text signup-link" runat="server" NavigateUrl="~/Signup.aspx">Kayıt ol</asp:HyperLink>
                    </span>
                </div>
            </div>


        </div>
    </div>

    <script src="assets/js/form.js"></script>
</body>
</html>
