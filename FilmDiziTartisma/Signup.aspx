<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="FilmDiziTartisma.Signup" %>

<%@ Register Src="~/UserControl/UserSignup.ascx" TagPrefix="uc1" TagName="UserSignup" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.0/css/line.css" />
    <link rel="stylesheet" href="assets/css/form.css" />
</head>
<body>
    <div class="container">
        <div class="forms">
            <uc1:UserSignup runat="server" id="UserSignup" />
        </div>
    </div>

    <script src="assets/js/form.js"></script>
</body>
</html>
