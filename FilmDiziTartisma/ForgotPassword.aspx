<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="FilmDiziTartisma.ForgotPassword" %>

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
                <span class="title">Şifremi unuttum</span>

                <form action="#">
                    <div class="input-field">
                        <input type="text" placeholder="E-postanızı giriniz" required="required" />
                        <i class="uil uil-envelope icon"></i>
                    </div>
                    
                    <div class="input-field button">
                        <input type="button" value="Devam" />
                    </div>

                    <div class="login-signup">
                        <span class="text">Hesabınız varsa 
                            <asp:HyperLink ID="HyperLink1" class="text login-link" runat="server" NavigateUrl="~/Login.aspx">Giriş yap</asp:HyperLink>
                        </span>
                    </div>
                </form>

            </div>
        </div>
        </div>
</body>
</html>
