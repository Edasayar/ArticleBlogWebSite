using ArticleBlogSiteDAL.Context;
using ArticleBlogSiteDAL.Extensions;
using Microsoft.EntityFrameworkCore;
using ArticleBlogSiteService.Extensions;
using ArticleBlogSiteEntity.Identity;
using Microsoft.AspNetCore.Identity;
using ArticleBlogSiteDAL.Context.Data;
using ArticleBlogSiteMVC.Areas.Admin.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.LoadDataLayerExtension(builder.Configuration);
builder.Services.LoadServiceLayerExtension();
builder.Services.AddSession();

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddIdentity<AppUser, AppRole>()
        .AddEntityFrameworkStores<ArticleBlogSiteIdentityDbContext>()
        .AddSignInManager<SignInManager<AppUser>>()
        .AddErrorDescriber<ArticleIdentityValidator>();


builder.Services.ConfigureApplicationCookie(conf =>
{
    conf.LoginPath = new PathString("/Admin/Auth/Login");
    conf.LogoutPath = new PathString("/Admin/Auth/Logout");
    conf.Cookie = new CookieBuilder
    {
        Name = "ArticleBlogSite",
        HttpOnly= true,
        SameSite=SameSiteMode.Strict,
        SecurePolicy= CookieSecurePolicy.SameAsRequest
    };
    conf.SlidingExpiration = true;
    conf.ExpireTimeSpan= TimeSpan.FromDays(10);
    conf.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");  //yetkisiz giriþ varsa bu çalýþýr varsa hata mesajý iletilir
});


// Add services to the container.

//builder.Services.AddDbContext<ArticleBlogSiteDbContext>(op =>
//{
//    string con = builder.Configuration.GetConnectionString("_ArticleBlog");
//    op.UseSqlServer(con);

//});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Register}/{action=Index}/{id?}"
        );

       endpoints.MapDefaultControllerRoute();


});

app.Run();
