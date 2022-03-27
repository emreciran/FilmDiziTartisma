<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="FilmDiziTartisma.Generic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<link rel="stylesheet" href="assets/css/main.css" />
	<noscript><link rel="stylesheet" href="assets/css/noscript.css" /></noscript>
</head>
<body class="is-preload">
		<!-- Wrapper -->
			<div id="wrapper">

				<!-- Header -->
					<header id="header">
						<div class="inner">

							<!-- Logo -->
							<asp:HyperLink ID="HyperLink2" class="logo" NavigateUrl="~/Default.aspx" runat="server">
								<span class="symbol"><img src="images/logo.svg" alt="" /></span><span class="title">FilmDizi</span>
                            </asp:HyperLink>

							<!-- Nav -->
								<nav>
									<ul>
										<li><a href="#menu">Menu</a></li>
									</ul>
								</nav>

						</div>
					</header>

				<!-- Menu -->
					<nav id="menu">
						<h2>Menu</h2>
						<ul>
							<li>
                                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Default.aspx">Ana Sayfa</asp:HyperLink>
							</li>
							<li>
                                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Movie.aspx">Filmler</asp:HyperLink>
							</li>
							<li>
                                <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Series.aspx">Diziler</asp:HyperLink>
							</li>
							<li>
                                <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Category.aspx">Kategoriler</asp:HyperLink>
							</li>
						</ul>
					</nav>

                <!-- Main -->
					<div id="main">
						<div class="inner">
							<h1>The Batman</h1>
							<span class="image main"><img src="images/images.jpg" alt="" /></span>
							<h2>Özet</h2>
							<p>The Batman, suçluların kalplerine korku salan Batman'in Riddler isimli bir seri katille mücadelesini konu ediyor. Batman olarak iki yıl sokaklarda dolaşmak ve suçlulara korku salmak Bruce Wayne'i Gotham City'nin karanlığının kalbine sürükledi. Gizemli bir seri katil Riddler, şehrin seçkinlerini hedef alıp bir dizi sadist ve hain saldırı gerçekleştirdiğinde Batman, Riddler'in izini sürmeye başlar. İpuçlarınını peşinden giden Batman'in yolu bu süreçte Catwoman olarak bilinen Selina Kyle, Penguen olarak da bilinen Oswald Cobblepot ve Carmine Falcone gibi karakterlerle kesişir. Batman kurduğu yeni ilişkilerin de yardımıyla suçluların maskesini düşürmek ve Gotham Şehri’ni eski huzuruna kavuşturmak için zorlu bir mücadeleye girişir.</p>
							<p>IMDB: <span>8.5</span></p>
							<p>Süre: <span>146 dakika</span></p>
						</div>
						<div class="inner">
							<h2>Oyuncular</h2>
							<div class="grid">
								<div style="display:flex; flex-direction:column; align-items:center; justify-content:center">
									<img src="images/images.jpg" class="actor-image" style="width:200px; height:200px; border-radius:50%; object-fit:cover;" />
									<span>Robert Pattinson</span>
								</div>
								<div style="display:flex; flex-direction:column; align-items:center; justify-content:center">
									<img src="images/images.jpg" class="actor-image" style="width:200px; height:200px; border-radius:50%; object-fit:cover;" />
									<span>Robert Pattinson</span>
								</div>
								<div style="display:flex; flex-direction:column; align-items:center; justify-content:center">
									<img src="images/images.jpg" class="actor-image" style="width:200px; height:200px; border-radius:50%; object-fit:cover;" />
									<span>Robert Pattinson</span>
								</div>
								<div style="display:flex; flex-direction:column; align-items:center; justify-content:center">
									<img src="images/images.jpg" class="actor-image" style="width:200px; height:200px; border-radius:50%; object-fit:cover;" />
									<span>Robert Pattinson</span>
								</div>
								<div style="display:flex; flex-direction:column; align-items:center; justify-content:center">
									<img src="images/images.jpg" class="actor-image" style="width:200px; height:200px; border-radius:50%; object-fit:cover;" />
									<span>Robert Pattinson</span>
								</div>
								<div style="display:flex; flex-direction:column; align-items:center; justify-content:center">
									<img src="images/images.jpg" class="actor-image" style="width:200px; height:200px; border-radius:50%; object-fit:cover;" />
									<span>Robert Pattinson</span>
								</div>
							</div>
						</div>
						<div class="inner">
							<h2>Yönetmen</h2>
							<div class="grid">
								<div style="display:flex; flex-direction:column; align-items:center; justify-content:center">
									<img src="images/images.jpg" class="actor-image" style="width:200px; height:200px; border-radius:50%; object-fit:cover;" />
									<span>Robert Pattinson</span>
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
						<div class="inner">
							<form method="post" action="#">
									<div class="fields">
										<div class="field half">
											<input type="text" name="name" id="name" placeholder="Ad soyad giriniz" />
										</div>
										<div class="field half">
											<input type="email" name="email" id="email" placeholder="Email" />
										</div>
										<div class="field">
											<textarea name="message" id="message" placeholder="Mesaj"></textarea>
										</div>
									</div>
									<ul class="actions">
										<li><input type="submit" value="Gönder" class="primary" /></li>
									</ul>
								</form>
						</div>
					</div>


				<!-- Footer -->
					<footer id="footer">
						<div class="inner">
							<section>
								<h2>FILMDIZI</h2>
								
							</section>
							<section>
								<h2>Takip</h2>
								<ul class="icons">
									<li>
										<asp:HyperLink ID="HyperLink18" runat="server" class="icon brands style2 fa-github" Target="_blank" NavigateUrl="https://github.com/emreciran">
											<span class="label">GitHub</span>
                                        </asp:HyperLink>
									</li>
								</ul>
							</section>
							<ul class="copyright">
								<li>&copy; Emre Efe Ciran. All rights reserved</li>
							</ul>
						</div>
					</footer>

			</div>

		<!-- Scripts -->
			<script src="assets/js/jquery.min.js"></script>
			<script src="assets/js/browser.min.js"></script>
			<script src="assets/js/breakpoints.min.js"></script>
			<script src="assets/js/util.js"></script>
			<script src="assets/js/main.js"></script>

	</body>
</html>
