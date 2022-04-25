<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="FilmDiziTartisma.ForgotPassword" %>

<%@ Register Src="~/UserControl/UserForgotPassword.ascx" TagPrefix="uc1" TagName="UserForgotPassword" %>


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
        <uc1:UserForgotPassword runat="server" id="UserForgotPassword" />
     </div>
</body>
</html>
