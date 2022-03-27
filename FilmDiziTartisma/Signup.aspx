<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="FilmDiziTartisma.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.0/css/line.css">
    <link rel="stylesheet" href="assets/css/form.css" />
</head>
<body>
    <div class="container">
        <div class="forms">
    <div class="form signup">
                <span class="title">Üye ol</span>

                <form action="#">
                    <div class="input-field">
                        <input type="text" placeholder="Ad soyad giriniz" required>
                        <i class="uil uil-user"></i>
                    </div>
                    <div class="input-field">
                        <input type="text" placeholder="E-postanızı giriniz" required>
                        <i class="uil uil-envelope icon"></i>
                    </div>
                    <div class="input-field">
                        <input type="password" class="password" placeholder="Şifrenizi oluşturun" required>
                        <i class="uil uil-lock icon"></i>
                    </div>
                    <div class="input-field">
                        <input type="password" class="password" placeholder="Şifrenizi doğrulayın" required>
                        <i class="uil uil-lock icon"></i>
                        <i class="uil uil-eye-slash showHidePw"></i>
                    </div>

                    <div class="checkbox-text">
                        <div class="checkbox-content">
                            <input type="checkbox" id="sigCheck">
                            <label for="sigCheck" class="text">Beni hatırla</label>
                        </div>
                        
                        <asp:HyperLink ID="HyperLink2" class="text" runat="server" NavigateUrl="~/ForgotPassword.aspx">Şifremi unuttum</asp:HyperLink>
                    </div>

                    <div class="input-field button">
                        <input type="button" value="Kayıt ol">
                    </div>
                </form>

                <div class="login-signup">
                    <span class="text">Hesabınız varsa 
                        <asp:HyperLink ID="HyperLink1" class="text login-link" runat="server" NavigateUrl="~/Login.aspx">Giriş yap</asp:HyperLink>
                    </span>
                </div>
            </div>

            </div>
        </div>

        <script src="assets/js/form.js"></script>
</body>
</html>
