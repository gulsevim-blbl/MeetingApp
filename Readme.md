# MeetingApp (ASP.NET Core MVC)

**MeetingApp**, ASP.NET Core MVC kullanılarak geliştirilmiş basit bir toplantı/etkinlik uygulamasıdır. Bu proje, **MVC mimarisi**nin temel kavramlarını öğrenmek ve uygulamak için hazırlanmıştır.  

## 📌 Proje İçeriği

Bu projede aşağıdaki ASP.NET Core MVC konuları ele alınmaktadır:

- **Empty Project**  
  - Proje, boş bir ASP.NET Core MVC şablonundan başlanarak sıfırdan yapılandırılmıştır.

- **Default Routing**  
  - Varsayılan yönlendirme (Default Routing) ayarları kullanılmıştır.  
  - Controller/Action/Id formatında çalışmaktadır.

- **Controllers**  
  - Toplantı yönetimi için gerekli Controller sınıfları oluşturulmuştur.  
  - Örnek: `MeetingController`

- **Views**  
  - Razor View dosyaları ile kullanıcı arayüzü hazırlanmıştır.  
  - Sayfa geçişleri View üzerinden sağlanmaktadır.

- **Models**  
  - Toplantı bilgilerini (ID, Başlık, Katılımcı sayısı vb.) saklamak için model sınıfları tanımlanmıştır.

- **Layout**  
  - Ortak sayfa tasarımı için `_Layout.cshtml` dosyası oluşturulmuştur.  
  - Header, Footer ve Navigation kısımları Layout üzerinden yönetilmektedir.

- **Client Packages - LibMan**  
  - Bootstrap ve jQuery gibi istemci tarafı kütüphaneler **LibMan** üzerinden projeye dahil edilmiştir.

- **ViewBag & ViewData**  
  - Controller’dan View’e veri taşımak için **ViewBag** ve **ViewData** kullanımı gösterilmiştir.

- **Forms**  
  - Kullanıcıların toplantı bilgilerini girebilmesi için Razor form yapısı hazırlanmıştır.

- **Model Binding**  
  - Form verilerinin Controller’daki action metoduna otomatik olarak bağlanması (Model Binding) uygulanmıştır.

- **Tag Helpers**  
  - ASP.NET Core’un sunduğu **Tag Helper** yapıları kullanılarak HTML formları daha kolay ve temiz bir şekilde oluşturulmuştur.

- **Form Validations**  
  - Data Annotations ile model seviyesinde validasyonlar yapılmıştır.  
  - Hatalı girişlerde kullanıcıya hata mesajları gösterilmiştir.


  ## 🚀 Çalıştırma

1. Bu projeyi klonlayın:  
   ```bash
   git clone https://github.com/kullanici-adi/MeetingApp.git
   ```

2. Proje klasörüne gidin:  
   ```bash
   cd MeetingApp
   ```

3. Uygulamayı çalıştırın:  
   ```bash
   dotnet run
   ```

4. Tarayıcıdan açın:  
   ```
   https://localhost:5001
   ```
