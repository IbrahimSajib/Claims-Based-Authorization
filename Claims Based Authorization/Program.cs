using Claims_Based_Authorization.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
        .AddEntityFrameworkStores<AuthDbContext>();

builder.Services.AddDbContext<AuthDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AuthCS")));



builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy",
        policy => policy.RequireClaim("Role","Admin"));
    options.AddPolicy("HRPolicy",
        policy => policy.RequireClaim("Role", "HR"));
    options.AddPolicy("DeveloperPolicy",
        policy => policy.RequireClaim("Role", "Developer"));


    options.AddPolicy("MalePolicy",
        policy => policy.RequireClaim("Gender", "Male"));
    options.AddPolicy("FemalePolicy",
        policy => policy.RequireClaim("Gender", "Female"));


    options.AddPolicy("BangladeshPolicy",
        policy => policy.RequireClaim("Country", "Bangladesh"));
    options.AddPolicy("JapanPolicy",
        policy => policy.RequireClaim("Country", "Japan"));
    options.AddPolicy("AsianPolicy",
        policy => policy.RequireClaim("Country", "Bangladesh", "Japan"));
    options.AddPolicy("AustraliaPolicy",
        policy => policy.RequireClaim("Country", "Australia"));
    options.AddPolicy("CanadaPolicy",
        policy => policy.RequireClaim("Country", "Canada"));
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
