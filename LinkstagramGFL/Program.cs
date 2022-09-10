using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using User;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("LinkstagramGFLContextConnection") ?? throw new InvalidOperationException("Connection string 'LinkstagramGFLContextConnection' not found.");

builder.Services.AddDbContext<LinkstagramGFLContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<LinkstagramGFLUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<LinkstagramGFLContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
