<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dizi.aspx.cs" Inherits="FilmDiziTartisma.Yazar.Dizi" %>

<%@ Register Src="~/UserControl/Yazar/UserDizi.ascx" TagPrefix="uc1" TagName="UserDizi" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Dizi ekle dizi sil dizi güncelle
            <uc1:UserDizi runat="server" ID="UserDizi" />
        </div>
    </form>
</body>
</html>
