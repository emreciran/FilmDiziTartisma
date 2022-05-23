<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserYonetmen.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Admin.UserYonetmen" %>

<div class="container">
    <div class="d-flex bd-highlight mb-3">
        <div class="me-auto p-2 bd-highlight">
            <h2>Yönetmenler</h2>
        </div>
        <div class="p-2 bd-highlight">
            <button type="button" class="btn btn-secondary" data-toggle="modal" data-target="#modal-lg">Ekle</button>
            <div class="modal fade show" id="modal-lg" style="display: none;" aria-modal="true" role="dialog">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">Yönetmen Ekle</h4>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_yonetmen_ad">Yonetmen Ad</label>
                                <asp:TextBox ID="txt_yonetmen_ad" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_yonetmen_soyad">Yonetmen Soyad</label>
                                <asp:TextBox ID="txt_yonetmen_soyad" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_yonetmen_foto">Yonetmen Fotoğraf</label>
                                <asp:TextBox ID="txt_yonetmen_foto" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                        </div>
                        <div class="modal-footer justify-content-between">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                            <asp:Button ID="btn_ekle" runat="server" Text="Ekle" class="btn btn-primary" OnClick="btn_ekle_Click" />
                        </div>
                    </div>
                </div>
            </div>

            <div class="modal fade show" id="modal-guncelle" style="display: none;" aria-modal="true" role="dialog">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">Yönetmen Güncelle</h4>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_yonetmen_guncelle_id">Yonetmen ID</label>
                                <asp:TextBox ID="txt_yonetmen_guncelle_id" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_yonetmen_guncelle_ad">Yonetmen Ad</label>
                                <asp:TextBox ID="txt_yonetmen_guncelle_ad" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_yonetmen_guncelle_soyad">Yonetmen Soyad</label>
                                <asp:TextBox ID="txt_yonetmen_guncelle_soyad" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_yonetmen_guncelle_foto">Yonetmen Fotoğraf</label>
                                <asp:TextBox ID="txt_yonetmen_guncelle_foto" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                        </div>
                        <div class="modal-footer justify-content-between">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                            <asp:Button ID="btn_guncelle" runat="server" Text="Güncelle" class="btn btn-primary" OnClick="btn_guncelle_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="table-responsive">
        <asp:GridView ID="GridView1" runat="server" class="table" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="yonetmen_id" HeaderText="#" />
                <asp:BoundField DataField="yonetmenAd" HeaderText="Yönetmen Adı" />
                <asp:BoundField DataField="yonetmenSoyad" HeaderText="Yönetmen Soyadı" />
                <asp:BoundField DataField="yonetmenFoto" HeaderText="Yönetmen Fotoğraf" />
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="btn_sil" runat="server" Text="Sil" CommandArgument='<%# Eval("yonetmen_id") %>' OnClick="btn_sil_Click" />
                        <asp:LinkButton ID="link_btn_guncelle" runat="server" data-toggle="modal" data-target="#modal-guncelle">Güncelle</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</div>
