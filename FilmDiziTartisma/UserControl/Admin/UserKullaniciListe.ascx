<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserKullaniciListe.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Admin.UserKullanici" %>


<div class="container">
    <div class="d-flex bd-highlight mb-3">
        <div class="me-auto p-2 bd-highlight">
            <h2>Kullanıcılar</h2>
        </div>
        <div class="p-2 bd-highlight">
            <button type="button" class="btn btn-secondary" data-toggle="modal" data-target="#modal-lg">Ekle</button>
            <div class="modal fade show" id="modal-lg" style="display: none;" aria-modal="true" role="dialog">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">Kullanıcı Ekle</h4>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div style="display: flex; flex-direction: column;">
                                <label for="txt_kullanici_ad">Kullanıcı Ad</label>
                                <asp:TextBox ID="txt_kullanici_ad" runat="server" Style="padding: .2rem"></asp:TextBox>
                            </div>
                            <div style="display: flex; flex-direction: column;">
                                <label for="txt_kullanici_soyad">Kullanıcı Soyad</label>
                                <asp:TextBox ID="txt_kullanici_soyad" runat="server" Style="padding: .2rem"></asp:TextBox>
                            </div>
                            <div style="display: flex; flex-direction: column;">
                                <label for="txt_email">Email</label>
                                <asp:TextBox ID="txt_email" runat="server" Style="padding: .2rem"></asp:TextBox>
                            </div>
                            <div style="display: flex; flex-direction: column;">
                                <label for="txt_kullanici_password">Kullanıcı Şifre</label>
                                <asp:TextBox ID="txt_kullanici_password" runat="server" Style="padding: .2rem"></asp:TextBox>
                            </div>
                            <div style="display: flex; flex-direction: column;">
                                <label for="drp_yeki">Yetki</label>
                                <asp:DropDownList ID="drp_yetki" runat="server" Style="padding: .2rem">
                                    <asp:ListItem>Kullanıcı</asp:ListItem>
                                    <asp:ListItem>Yazar</asp:ListItem>
                                    <asp:ListItem>Admin</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="modal-footer justify-content-between">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                            <asp:Button ID="btn_ekle" runat="server" Text="Ekle" class="btn btn-primary" OnClick="btn_ekle_Click" />
                        </div>
                    </div>
                </div>
            </div>

            <div class="modal fade show" id="modal-yetki" style="display: none;" aria-modal="true" role="dialog">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">Yetki Değiştir</h4>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div style="display: flex; flex-direction: column;">
                                <label for="txt_kullanici_id">Kullanıcı ID</label>
                                <asp:TextBox ID="txt_kullanici_id" runat="server" Style="padding: .2rem"></asp:TextBox>
                            </div>
                            <div style="display: flex; flex-direction: column;">
                                <label for="drp_yeki">Yetki</label>
                                <asp:DropDownList ID="modal_yetki" runat="server" Style="padding: .2rem">
                                    <asp:ListItem>Kullanıcı</asp:ListItem>
                                    <asp:ListItem>Yazar</asp:ListItem>
                                    <asp:ListItem>Admin</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="modal-footer justify-content-between">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                            <asp:Button ID="btn_modal_yekti" runat="server" Text="Değiştir" class="btn btn-primary" OnClick="btn_modal_yetki_Click" />
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div class="table-responsive">
        <asp:GridView ID="GridView1" runat="server" class="table" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="uye_id" HeaderText="#" />
                <asp:BoundField DataField="uyeAd" HeaderText="Üye Adı" />
                <asp:BoundField DataField="uyeSoyad" HeaderText="Üye Soyadı" />
                <asp:BoundField DataField="uyeEmail" HeaderText="Üye Email" />
                <asp:BoundField DataField="uyePassword" HeaderText="Üye Password" />
                <asp:BoundField DataField="uyeYetki" HeaderText="Üye Yetki" />
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="btn_sil" runat="server" Text="Sil" CommandArgument='<%# Eval("uye_id") %>' OnClick="btn_sil_Click" />
                        <asp:LinkButton ID="link_btn_guncelle" runat="server" data-toggle="modal" data-target="#modal-yetki">Yetki Değiştir</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</div>
