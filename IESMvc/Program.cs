using Microsoft.EntityFrameworkCore;
using IESMvc.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<IESContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("IESConnection"));
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<IESContext>();
IESDbInitialize.Initialize(context);

app.Run();

