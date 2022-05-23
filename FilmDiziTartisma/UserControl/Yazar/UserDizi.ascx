<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserDizi.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Yazar.UserDizi" %>

<div class="container">
    <div class="d-flex bd-highlight mb-3">
        <div class="me-auto p-2 bd-highlight">
            <h2>Dizi</h2>
        </div>
        <div class="p-2 bd-highlight">
            <button type="button" class="btn btn-secondary" data-toggle="modal" data-target="#modal-lg">Ekle</button>
            <div class="modal fade show" id="modal-lg" style="display: none;" aria-modal="true" role="dialog">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">Dizi Ekle</h4>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_ad">Dizi Ad</label>
                                <asp:TextBox ID="txt_dizi_ad" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_sezon">Sezon Sayısı</label>
                                <asp:TextBox ID="txt_dizi_sezon" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_imdb">IMDB</label>
                                <asp:TextBox ID="txt_dizi_imdb" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_aciklama">Açıklama</label>
                                <asp:TextBox ID="txt_dizi_aciklama" runat="server" style="padding:.2rem" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_video">Video</label>
                                <asp:TextBox ID="txt_dizi_video" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_yonetmen">Yönetmen</label>
                                <asp:TextBox ID="txt_dizi_yonetmen" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_yonetmen_foto">Yönetmen Fotoğraf</label>
                                <asp:TextBox ID="txt_dizi_yonetmen_foto" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_fotograf">Dizi Fotoğraf</label>
                                <asp:TextBox ID="txt_dizi_fotograf" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_oyuncu">Oyuncu</label>
                                <asp:TextBox ID="txt_dizi_oyuncu" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_oyuncu_foto">Oyuncu Fotoğraf</label>
                                <asp:TextBox ID="txt_dizi_oyuncu_foto" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                        </div>
                        <div class="modal-footer justify-content-between">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                            <asp:Button ID="btn_ekle" runat="server" Text="Ekle" class="btn btn-primary" OnClick="btn_ekle_Click"/>
                        </div>
                    </div>
                </div>
            </div>

            <div class="modal fade show" id="modal-guncelle" style="display: none;" aria-modal="true" role="dialog">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">Dizi Güncelle</h4>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_guncelle_id">Dizi ID</label>
                                <asp:TextBox ID="txt_dizi_guncelle_id" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_guncelle_ad">Dizi Ad</label>
                                <asp:TextBox ID="txt_dizi_guncelle_ad" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_guncelle_sezon">Sezon Sayısı</label>
                                <asp:TextBox ID="txt_dizi_guncelle_sezon" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_guncelle_imdb">IMDB</label>
                                <asp:TextBox ID="txt_dizi_guncelle_imdb" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_guncelle_aciklama">Açıklama</label>
                                <asp:TextBox ID="txt_dizi_guncelle_aciklama" runat="server" style="padding:.2rem" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_guncelle_video">Video</label>
                                <asp:TextBox ID="txt_dizi_guncelle_video" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_guncelle_yonetmen">Yönetmen</label>
                                <asp:TextBox ID="txt_dizi_guncelle_yonetmen" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_guncelle_yonetmen_foto">Yönetmen Fotoğraf</label>
                                <asp:TextBox ID="txt_dizi_guncelle_yonetmen_foto" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_guncelle_fotograf">Dizi Fotoğraf</label>
                                <asp:TextBox ID="txt_dizi_guncelle_fotograf" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_guncelle_oyuncu">Oyuncu</label>
                                <asp:TextBox ID="txt_dizi_guncelle_oyuncu" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_dizi_guncelle_oyuncu_foto">Oyuncu Fotoğrraf</label>
                                <asp:TextBox ID="txt_dizi_guncelle_oyuncu_foto" runat="server" style="padding:.2rem"></asp:TextBox>
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
        <asp:GridView ID="GridView1" runat="server" class="table" AutoGenerateColumns="False" CssClass="gridview" >
            <Columns>
                <asp:BoundField DataField="dizi_id" HeaderText="#" />
                <asp:BoundField DataField="diziAd" HeaderText="Dizi Adı" />
                <asp:BoundField DataField="diziSezonsayisi" HeaderText="Sezon Sayısı" />
                <asp:BoundField DataField="IMDB" HeaderText="IMDB" />
                <asp:BoundField DataField="diziAciklama" HeaderText="Açıklama" ItemStyle-CssClass="shorter" />
                <asp:BoundField DataField="diziVideo" HeaderText="Video" />
                <asp:BoundField DataField="diziYonetmen" HeaderText="Yönetmen" />
                <asp:BoundField DataField="diziYonetmenFoto" HeaderText="Yönetmen Fotoğraf" />
                <asp:BoundField DataField="diziFoto" HeaderText="Dizi Fotoğraf" />
                <asp:BoundField DataField="diziOyuncu" HeaderText="Oyuncu" />
                <asp:BoundField DataField="diziOyuncuFoto" HeaderText="Oyuncu Fooğraf" />
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="btn_sil" runat="server" Text="Sil" CommandArgument='<%# Eval("dizi_id") %>' OnClick="btn_sil_Click"/>
                        <asp:LinkButton ID="link_btn_guncelle" runat="server" data-toggle="modal" data-target="#modal-guncelle">Güncelle</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</div>