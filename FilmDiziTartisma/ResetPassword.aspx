<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="FilmDiziTartisma.ResetPassword" %>

<%@ Register Src="~/UserControl/UserResetPassword.ascx" TagPrefix="uc1" TagName="UserResetPassword" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.0/css/line.css" />
    <link rel="stylesheet" href="assets/css/form.css" />
</head>
<body>
    <div class="container">
        <uc1:UserResetPassword runat="server" ID="UserResetPassword" />
    </div>
</body>
</html>
