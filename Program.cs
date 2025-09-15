var builder = WebApplication.CreateBuilder(args); //uygulama yapılandırıcısını oluşturur
// 1- mvc yeteneğini kazandırmak için gerekli servisleri ekler
builder.Services.AddControllersWithViews();
/**
Ekstra bilgi:
    builder.Services.AddControllers(); //sadece API uygulamaları için
    builder.Services.AddRazorPages(); //sadece Razor Pages uygulamaları için
*/
var app = builder.Build();  //uygulamayı oluşturur


//! 1-bu işlemi Controllera aktarıyor olmamız gerekiyor.Bu yüzden yoruma alıyoruz.

// app.MapGet("/", () => "Hello World!"); //uygulamanın ana sayfası için basit bir GET endpointi
// app.MapGet("/abc", () => "deneme!");

//! 2- Ve buraya bir şema ekliyoruz. /{controller}/{action}/id
/*app.MapDefaultControllerRoute(); //varsayılan controller rotasını ekler.Kısa Yolu bu */ 

//? uzun yolu da şöyledir:

app.MapControllerRoute(
     name: "default",
     pattern: "{controller=Meeting}/{action=Index}/{id?}"
); //id opsiyonel

app.Run(); //uygulamayı çalıştırır.
