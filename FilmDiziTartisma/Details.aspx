<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="FilmDiziTartisma.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Wrapper -->
			<div id="wrapper">

                <!-- Main -->
					<main id="main">
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
					</main>


			</div>
</asp:Content>
