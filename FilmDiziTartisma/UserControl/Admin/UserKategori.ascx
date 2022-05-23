<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserKategori.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Admin.UserKategori" %>

<style type="text/css">
    .auto-style1 {
        height: 34px;
    }
</style>

<div class="container">
    <div class="d-flex bd-highlight mb-3">
        <div class="me-auto p-2 bd-highlight">
            <h2>Kategoriler</h2>
        </div>

        <div class="p-2 bd-highlight">
            <button type="button" class="btn btn-secondary" data-toggle="modal" data-target="#modal-lg">Ekle</button>
            <div class="modal fade show" id="modal-lg"  aria-modal="true" role="dialog">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">Kategori Ekle</h4>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div style="display: flex; flex-direction: column;">
                                <label for="txt_kategori_ad">Kategori Ad</label>
                                <asp:TextBox ID="txt_kategori_ad" runat="server" Style="padding: 0.2rem"></asp:TextBox>
                            </div>
                        </div>
                        <div class="modal-footer justify-content-between">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                            <asp:Button ID="btn_ekle" class="btn btn-primary" runat="server" Text="Ekle" OnClick="btn_ekle_Click" />
                        </div>
                    </div>
                </div>
            </div>

            <div id="modal-guncelle" class="modal fade show"  aria-modal="true" role="dialog">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">Kategori Güncelle</h4>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div style="display: flex; flex-direction: column;">
                                <label for="txt_kategori_id_guncelle">Kategori ID</label>
                                <asp:TextBox ID="txt_kategori_id_guncelle" runat="server" Style="padding: 0.2rem"></asp:TextBox>
                            </div>
                            <div style="display: flex; flex-direction: column;">
                                <label for="txt_kategori_ad_guncelle">Kategori Ad</label>
                                <asp:TextBox ID="txt_kategori_ad_guncelle" runat="server" Style="padding: 0.2rem"></asp:TextBox>
                            </div>
                        </div>
                        <div class="modal-footer justify-content-between">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                            <asp:Button ID="btn_guncelle" class="btn btn-primary" runat="server" Text="Güncelle" OnClick="btn_guncelle_Click" />
                        </div>
                    </div>
                </div>
            </div>


            <div id="modal-detay" class="modal fade show"  aria-modal="true" role="dialog">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">Kategori Detay</h4>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div style="display: flex; flex-direction: column;">
                                <label for="txt_kategori_id_detay">Kategori ID</label>
                                <asp:TextBox ID="txt_kategori_id_detay" runat="server" Style="padding: 0.2rem"></asp:TextBox>
                            </div>
                            <div style="display: flex; flex-direction: column;">
                                <label for="txt_kategori_ad_detay">Kategori Ad</label>
                                <asp:TextBox ID="txt_kategori_ad_detay" runat="server" Style="padding: 0.2rem"></asp:TextBox>
                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                        <div class="modal-footer justify-content-between">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div class="table-responsive">

        <asp:GridView ID="GridView1" runat="server" class="table" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="kategori_id" HeaderText="#" />
                <asp:BoundField DataField="kategoriAd" HeaderText="Kategori Adı" />
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="btn_sil" runat="server" Text="Sil" CommandArgument='<%# Eval("kategori_id") %>' OnClick="btn_sil_Click" />
                        <asp:LinkButton ID="link_btn_guncelle" runat="server" data-toggle="modal" data-target="#modal-guncelle" CommandArgument='<%# Eval("kategori_id") %>'>Güncelle</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
           
    </div>
</div>
