<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserFilm.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Yazar.UserFilm" %>

<div class="container">
    <div class="d-flex bd-highlight mb-3">
        <div class="me-auto p-2 bd-highlight">
            <h2>Film</h2>
        </div>
        <div class="p-2 bd-highlight">
            <button type="button" class="btn btn-secondary" data-toggle="modal" data-target="#modal-lg">Ekle</button>
            <div class="modal fade show" id="modal-lg" style="display: none;" aria-modal="true" role="dialog">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">Film Ekle</h4>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_ad">Film Ad</label>
                                <asp:TextBox ID="txt_film_ad" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_suresi">Film Süresi</label>
                                <asp:TextBox ID="txt_film_suresi" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_imdb">IMDB</label>
                                <asp:TextBox ID="txt_film_imdb" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_aciklama">Açıklama</label>
                                <asp:TextBox ID="txt_film_aciklama" runat="server" style="padding:.2rem" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_video">Video</label>
                                <asp:TextBox ID="txt_film_video" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_yonetmen">Yönetmen</label>
                                <asp:TextBox ID="txt_film_yonetmen" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_yonetmen_foto">Yönetmen Fotoğraf</label>
                                <asp:TextBox ID="txt_film_yonetmen_foto" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_fotograf">Film Fotoğraf</label>
                                <asp:TextBox ID="txt_film_fotograf" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_oyuncu">Oyuncu</label>
                                <asp:TextBox ID="txt_film_oyuncu" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_oyuncu_foto">Oyuncu Fotoğraf</label>
                                <asp:TextBox ID="txt_film_oyuncu_foto" runat="server" style="padding:.2rem"></asp:TextBox>
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
                            <h4 class="modal-title">Film Güncelle</h4>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_guncelle_id">Film ID</label>
                                <asp:TextBox ID="txt_film_guncelle_id" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_guncelle_ad">Film Ad</label>
                                <asp:TextBox ID="txt_film_guncelle_ad" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_guncelle_suresi">Film Süresi</label>
                                <asp:TextBox ID="txt_film_guncelle_suresi" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_guncelle_imdb">IMDB</label>
                                <asp:TextBox ID="txt_film_guncelle_imdb" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_guncelle_aciklama">Açıklama</label>
                                <asp:TextBox ID="txt_film_guncelle_aciklama" runat="server" style="padding:.2rem" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_guncelle_video">Video</label>
                                <asp:TextBox ID="txt_film_guncelle_video" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_guncelle_yonetmen">Yönetmen</label>
                                <asp:TextBox ID="txt_film_guncelle_yonetmen" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_guncelle_yonetmen_foto">Yönetmen Fotoğraf</label>
                                <asp:TextBox ID="txt_film_guncelle_yonetmen_foto" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_guncelle_fotograf">Film Fotoğraf</label>
                                <asp:TextBox ID="txt_film_guncelle_fotograf" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_guncelle_oyuncu">Oyuncu</label>
                                <asp:TextBox ID="txt_film_guncelle_oyuncu" runat="server" style="padding:.2rem"></asp:TextBox>
                            </div>
                            <div style="display:flex; flex-direction:column;">
                                <label for="txt_film_guncelle_oyuncu_foto">Oyuncu Fotoğraf</label>
                                <asp:TextBox ID="txt_film_guncelle_oyuncu_foto" runat="server" style="padding:.2rem"></asp:TextBox>
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
        <asp:GridView ID="GridView1" runat="server" class="table" AutoGenerateColumns="False" CssClass="gridview">
            <Columns>
                <asp:BoundField DataField="film_id" HeaderText="#" />
                <asp:BoundField DataField="filmAd" HeaderText="Film Adı" />
                <asp:BoundField DataField="filmSuresi" HeaderText="Film Süresi" />
                <asp:BoundField DataField="IMDB" HeaderText="IMDB" />
                <asp:BoundField DataField="filmAciklama" HeaderText="Açıklama" ItemStyle-CssClass="shorter" />
                <asp:BoundField DataField="filmVideo" HeaderText="Video" />
                <asp:BoundField DataField="filmYonetmen" HeaderText="Yönetmen" />
                <asp:BoundField DataField="filmYonetmenFoto" HeaderText="Yönetmen Fotoğraf" />
                <asp:BoundField DataField="filmFoto" HeaderText="Film Fotoğraf" />
                <asp:BoundField DataField="filmOyuncu" HeaderText="Oyuncu" />
                <asp:BoundField DataField="filmOyuncuFoto" HeaderText="Oyuncu Fotoğraf" />
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="btn_sil" runat="server" Text="Sil" CommandArgument='<%# Eval("film_id") %>' OnClick="btn_sil_Click"/>
                        <asp:LinkButton ID="link_btn_guncelle" runat="server" data-toggle="modal" data-target="#modal-guncelle">Güncelle</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</div>