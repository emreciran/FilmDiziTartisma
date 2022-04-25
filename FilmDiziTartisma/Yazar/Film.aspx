<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Film.aspx.cs" Inherits="FilmDiziTartisma.Yazar.Film" %>

<%@ Register Src="~/UserControl/Yazar/UserFilm.ascx" TagPrefix="uc1" TagName="UserFilm" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:UserFilm runat="server" ID="UserFilm" />
        </div>
    </form>
</body>
</html>
