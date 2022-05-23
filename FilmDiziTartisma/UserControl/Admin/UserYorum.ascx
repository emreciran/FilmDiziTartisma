<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserYorum.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Admin.UserYorum" %>

<div class="container">
    <div class="d-flex bd-highlight mb-3">
        <div class="me-auto p-2 bd-highlight">
            <h2>Yorumlar</h2>
        </div>
    </div>

    <div class="table-responsive">
        <asp:GridView ID="GridView1" runat="server" class="table" AutoGenerateColumns="False" CssClass="gridview">
            <Columns>
                <asp:BoundField DataField="yorum_id" HeaderText="#" />
                <asp:BoundField DataField="yorumAdSoyad" HeaderText="Ad Soyad" />
                <asp:BoundField DataField="yorumEmail" HeaderText="Email" />
                <asp:BoundField DataField="yorumIcerik" HeaderText="İçerik" ItemStyle-CssClass="shorter" />
                <asp:BoundField DataField="yorumTarih" HeaderText="Tarih" />
                <asp:BoundField DataField="yorumOnay" HeaderText="Onay Durum" />

                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="btn_onay" runat="server" Text="Onay Değiştir" CommandArgument='<%# Eval("yorum_id") %>' OnClick="btn_onay_Click"/>
                        <asp:Button ID="btn_sil" runat="server" Text="Sil" CommandArgument='<%# Eval("yorum_id") %>' OnClick="btn_sil_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</div>
