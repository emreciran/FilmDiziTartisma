<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserKategori.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Admin.UserKategori" %>

<h1>Kategoriler</h1>

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="465px">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="kategoriID" HeaderText="Kategori ID" />
        <asp:BoundField DataField="kategoriAd" HeaderText="Kategori Adı" />
        <asp:TemplateField HeaderText="İşlemler"></asp:TemplateField>
    </Columns>
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
        <asp:TextBox ID="txt_kategori_id" runat="server" placeholder="Kategori ID"></asp:TextBox>
        <asp:TextBox ID="txt_kategori_ad" runat="server" placeholder="Kategori Adı"></asp:TextBox>

        <asp:Button ID="btn_kategori_ekle" runat="server" Text="Ekle" OnClick="btn_kategori_ekle_Click" />
    </ContentTemplate>
</asp:UpdatePanel>


