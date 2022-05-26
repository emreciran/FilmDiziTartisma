# FilmDiziTartisma
Film Dizi Tartisma

http://www.filmdizitartisma.somee.com/

## Bu projede 3 tane yetki vardır. Bunlar;
**1-Kullanıcı**: Kullanıcılar film ve dizileri görüntüleyebilirler. Bu film ve dizilere yorum atabilirler. Profil bilgilerini ve kategorileri listeleyebilirler.  
**2-Yazar**: Yazarlar film ve dizileri ekleyebilir bunları güncelleyip silebilirler.                                                                               
**3-Admin**: Admin sistemde kullanıcı, kategori, yönetmen, oyuncu ve yorumlar ile temel crud işlemlerini yapabilir(ekleme, listeleme, güncelleme, silme).                                                                                                                                                                       
***Yorumlarının onay durumu ilk başta false durumundadır. Admin yorumun onay durumunu true yaparsa yorum ilgili film veya dizi altında görüntülenecektir.***      
## Kullandığım veritabanı ve ASP NET Teknolojileri;                                                                                                                                                              
- Veritabanını MS SQL ile oluşturdum. Veritabanındaki verilere ulaşmak için Entity Framework kullandım.
- Master Page, User Control, Global.asax(URL Rewrite)
- Projede 4 katman bulunuyor. Bunlar;
  - Web katmanı
  - Sınıflarım
  - Veritabanı
  - Web API

1. Web katmanında proje sayfaları, Global.asax, User Controller, CSS, JS vb.
2. Sınıflarım katmanında her bir tablo için crud işlemleri ve işimize yarayabilecek fonksiyonlar yer alıyor.
3. Veritabanı katmanında Entiy modelimiz yer alıyor.
4. Web API katmanında tüm veritabanı tablolarına ait Controller'ı oluşturdum.
