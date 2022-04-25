<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FilmDiziTartisma.Login" %>

<%@ Register Src="~/UserControl/UserLogin.ascx" TagPrefix="uc1" TagName="UserLogin" %>


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
            <uc1:UserLogin runat="server" id="UserLogin" />
        </div>

    <script src="assets/js/form.js"></script>
</body>
</html>
