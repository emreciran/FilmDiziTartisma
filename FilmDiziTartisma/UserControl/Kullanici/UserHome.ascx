<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserHome.ascx.cs" Inherits="FilmDiziTartisma.UserControl.Kullanici.UserHome" %>

<div id="wrapper">


    <!-- Main -->
    <main id="main">
        <div class="inner">
            <h2>Filmler</h2>
            <section class="tiles">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <article class="style1">
                            <span class="image">
                                <img src="<%# Eval("filmFoto") %>" alt="" />
                            </span>
                            <a href="/Kullanici/FilmDetay?filmID=<%# Eval("film_id") %>">
                                <h2><%# Eval("filmAd") %></h2>
                                <div class="content">
                                    <p><%# Eval("filmAciklama") %></p>
                                </div>
                            </a>
                        </article>
                    </ItemTemplate>
                </asp:Repeater>
            </section>
        </div>
        <div class="inner" style="margin-top: 50px">
            <h2>Diziler</h2>
            <section class="tiles">
                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <article class="style1">
                            <span class="image">
                                <img src="<%# Eval("diziFoto") %>" alt="" />
                            </span>
                            <a href="/Kullanici/DiziDetay?diziID=<%# Eval("dizi_id") %>">
                                <h2><%# Eval("diziAd") %></h2>
                                <div class="content">
                                    <p><%# Eval("diziAciklama") %></p>
                                </div>
                            </a>
                        </article>
                    </ItemTemplate>
                </asp:Repeater>
            </section>
        </div>
    </main>



</div>
