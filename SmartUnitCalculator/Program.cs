using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartUnitCalculator.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication().AddCookie("SMC_Cookie", options =>
{
    options.Cookie.Name = "SMC_Cookie";
    options.LoginPath = "/Index";
    options.LogoutPath = "/LogIn";
});
builder.Services.AddRazorPages();
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SUCDB_J")
    ?? throw new InvalidOperationException("Connection string not found.")));
builder.Services.ConfigureApplicationCookie(option => 
{ 
    option.LoginPath = "/Index"; 
    option.LogoutPath = "/logIn"; 
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
