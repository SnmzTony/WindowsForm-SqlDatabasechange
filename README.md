# E-İrsaliye Durum Takip Uygulaması
Bu uygulama, kullanıcılara e-İrsaliye numarası aracılığıyla bir e-İrsaliye'nin durumunu sorgulama ve güncelleme imkanı sağlar. Uygulama, Microsoft SQL Server veritabanı kullanarak çalışır ve C# programlama dili ile geliştirilmiştir.

Kullanım Kılavuzu
Uygulamayı kullanmak için aşağıdaki adımları takip edebilirsiniz:

Uygulamayı açın ve e-İrsaliye numarasını girin.
"Sorgula" butonuna tıklayarak seçili e-İrsaliye'nin durumunu sorgulayın.
Eğer durumu "İrsaliye Alındı" ise, "Güncelle" butonuna tıklayarak durumu "Gönderildi" olarak güncelleyin.
Kurulum
Uygulamayı kullanmak için aşağıdaki adımları takip edebilirsiniz:

Microsoft SQL Server kurulumu: Uygulama, Microsoft SQL Server veritabanı kullanmaktadır. Öncelikle, SQL Server'ı bilgisayarınıza kurmanız gerekiyor.
Veritabanı oluşturma: SQL Server Management Studio kullanarak, bir veritabanı oluşturun ve "Dispatches" adında bir tablo ekleyin. Tablo yapısı şu şekilde olmalıdır:
EIRSALIYE_NUMARASI (nvarchar(50), primary key)
GIB_STATU (nvarchar(50))
Uygulama yükleme: Bu GitHub reposunu kopyalayın ve Visual Studio kullanarak uygulamayı yükleyin.
Bağlantı dizgisi: Uygulamayı çalıştırmadan önce, App.config dosyasındaki myConnectionString değerinin doğru olduğundan emin olun. Bu değer, SQL Server'ın kurulu olduğu bilgisayarın adını ve oluşturduğunuz veritabanının adını içermelidir.
Lisans
Bu proje, MIT lisansı altında lisanslanmıştır. Ayrıntılar için LICENSE dosyasına bakabilirsiniz.
