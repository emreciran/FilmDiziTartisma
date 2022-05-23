<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserFilmDetay.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Kullanici.UserFilmDetay" %>

<!-- Wrapper -->
    <div id="wrapper">
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <!-- Main -->
                <main id="main">
                    <div class="inner">
                        <h1><%# Eval("filmAd") %></h1>
                        <span class="image main">
                            <img src="<%# Eval("filmFoto") %>" alt="" /></span>
                        <h2>Özet</h2>
                        <p><%# Eval("filmAciklama") %></p>
                        <p>IMDB: <span><%# Eval("IMDB") %></span></p>
                        <p>Süre: <span><%# Eval("filmSuresi") %></span></p>
                    </div>
                    <div class="inner">
                        <h2>Oyuncular</h2>
                        <div class="grid">
                            <div style="display: flex; flex-direction: column; align-items: center; justify-content: center">
                                <img src="<%# Eval("filmOyuncuFoto") %>"" class="actor-image" style="width: 200px; height: 200px; border-radius: 50%; object-fit: cover;" />
                                <span><%# Eval("filmOyuncu") %></span>
                            </div>

                        </div>
                    </div>
                    <div class="inner">
                        <h2>Yönetmen</h2>
                        <div class="grid">
                            <div style="display: flex; flex-direction: column; align-items: center; justify-content: center">
                                <img src="<%# Eval("filmYonetmenFoto") %>"" class="actor-image" style="width: 200px; height: 200px; border-radius: 50%; object-fit: cover;" />
                                <span><%# Eval("filmYonetmen") %></span>
                            </div>
                        </div>
                    </div>
                    <div class="inner">
                        <h2>Kategoriler</h2>
                        <ul>
                            <li class="category"><a>Aksiyon</a></li>
                            <li class="category"><a>Gerilim</a></li>
                            <li class="category"><a>Korku</a></li>
                        </ul>
                    </div>

                </main>

            </ItemTemplate>
        </asp:Repeater>

        <h2 style="display: flex; justify-content: center;">Yorumlar</h2>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="inner">
                    <div>
                        <div style="display: flex;">
                            <span><%# Eval("yorumAdSoyad") %></span>
                            <span> - </span>
                            <span><%# Eval("yorumTarih") %></span>
                        </div>
                        <div>
                            <p><%# Eval("yorumIcerik") %></p>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <div class="inner">
            <h2 style="display: flex; justify-content: center;">Yorum Ekle</h2>
            <div class="fields">
                <div class="field half">
                    <asp:TextBox ID="txt_ad" runat="server" placeholder="Ad soyad giriniz"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Adınızı Giriniz!" ControlToValidate="txt_ad"></asp:RequiredFieldValidator>
                </div>
                <div class="field half">
                    <asp:TextBox ID="txt_email" runat="server" placeholder="Email"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Email Giriniz!" ControlToValidate="txt_email"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Hatalı Email!" ControlToValidate="txt_email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </div>
                <div class="field">
                    <asp:TextBox ID="txt_message" runat="server" TextMode="MultiLine" placeholder="Mesaj" MaxLength="150"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Mesaj Giriniz!" ControlToValidate="txt_message"></asp:RequiredFieldValidator>
                </div>
            </div>
            <ul class="actions">
                <li>
                    <asp:Button ID="btn_gonder" runat="server" Text="Gönder" class="primary" OnClick="btn_gonder_Click" />
                </li>
                <li>
                    <asp:Label ID="txt_bilgi" runat="server" Text=""></asp:Label>
                </li>
            </ul>
        </div>
    </div>