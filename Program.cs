var builder = WebApplication.CreateBuilder(args); //uygulama yapılandırıcısını oluşturur
// 1- mvc yeteneğini kazandırmak için gerekli servisleri ekler
builder.Services.AddControllersWithViews();
/**
Ekstra bilgi:
    builder.Services.AddControllers(); //sadece API uygulamaları için
    builder.Services.AddRazorPages(); //sadece Razor Pages uygulamaları için
*/
var app = builder.Build();  //uygulamayı oluşturur



app.MapGet("/", () => "Hello World!"); //uygulamanın ana sayfası için basit bir GET endpointi
app.MapGet("/abc", () => "deneme!");


app.Run(); //uygulamayı çalıştırır.
