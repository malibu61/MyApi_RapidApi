//using DataAccessLayer.Concrete;
//using EntityLayer.Concrete;
//using FluentValidation;
//using FluentValidation.AspNetCore;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc.Authorization;
//using MimeKit.Cryptography;
//using WebUI.Dtos.GuestDto;
//using WebUI.ValidationRules.GuestValidationRules;

//var builder = WebApplication.CreateBuilder(args);

//// Servisleri ekleme
////builder.Services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
//builder.Services.AddScoped<IValidator<CreateGuestDto>, CreateGuestValidator>();
//builder.Services.AddScoped<IValidator<UpdateGuestDto>, UpdateGuestValidator>();




//builder.Services.ConfigureApplicationCookie(options =>
//{
//    options.LoginPath = "/Login/Index/";         // Eğer kullanıcı giriş yapmamışsa buraya yönlendir
//    options.SlidingExpiration = true;
//});


////builder.Services.AddMvc(config =>
////{
////    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
////    config.Filters.Add(new AuthorizeFilter(policy));
////});


//builder.Services.AddControllersWithViews(config =>
//{
//    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
//    config.Filters.Add(new AuthorizeFilter(policy));
//}).AddFluentValidation();




////builder.Services.AddControllersWithViews().AddFluentValidation();



////builder.Services.AddControllersWithViews().AddFluentValidation(fv =>
////{
////    fv.RegisterValidatorsFromAssemblyContaining<CreateGuestDValidator>();
////});

//builder.Services.AddDbContext<Context>();
//builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();

//// IHttpClientFactory'yi ekleme
//builder.Services.AddHttpClient();

//var app = builder.Build();

////builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//// HTTP request pipeline yapılandırması
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//}
//app.UseStaticFiles();

//app.UseRouting();





//app.MapDefaultControllerRoute(); // Eğer MVC kullanıyorsan

//app.UseAuthentication();

//app.UseAuthorization();



////app.UseEndpoints(endpoints =>
////{
////    endpoints.MapControllerRoute(
////        name: "default",
////        pattern: "{controller=Login}/{action=Index}/{id?}");
////});


//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");         //login index yapacağız

//app.Run();






using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using WebUI.Dtos.GuestDto;
using WebUI.ValidationRules.GuestValidationRules;

var builder = WebApplication.CreateBuilder(args);

// Servisleri ekleme
builder.Services.AddScoped<IValidator<CreateGuestDto>, CreateGuestValidator>();
builder.Services.AddScoped<IValidator<UpdateGuestDto>, UpdateGuestValidator>();

builder.Services.AddControllersWithViews(config =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    config.Filters.Add(new AuthorizeFilter(policy));
}).AddFluentValidation();




//builder.Services.ConfigureApplicationCookie(options =>
//{
//    options.LoginPath = "/Login/Index"; // Giriş yapmamış kullanıcılar Login sayfasına yönlendirilir
//    options.SlidingExpiration = true;
//});


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.Cookie.Name = ".NetCore";
    options.LoginPath = "/Login/Index";
    options.AccessDeniedPath = "/Login/Index";
});


builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();

//builder.Services.AddIdentity<AppUser, AppRole>(options =>
//{
//    // Identity ayarları
//    options.SignIn.RequireConfirmedAccount = false;  // Giriş için doğrulama gerekmiyor
//    options.Lockout.AllowedForNewUsers = false;     // Kullanıcıların kilitlenmesi ayarı
//})
//.AddEntityFrameworkStores<Context>()
//.AddDefaultTokenProviders();


builder.Services.AddHttpClient();













var app = builder.Build();

// HTTP request pipeline yapılandırması
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();


app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication(); // Authentication ilk önce
app.UseAuthorization();  // Authorization sonrasında

//app.MapDefaultControllerRoute(); // MVC kullanıyorsanız

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");         //login index yapacağız
app.Run();
