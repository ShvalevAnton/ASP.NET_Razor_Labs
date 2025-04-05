using WebAppCoreProduct.Models;
using WebAppCoreProduct;

var builder = WebApplication.CreateBuilder(args);

// Регистрируем сервис скидок
builder.Services.AddScoped<IDiscountService, DiscountService>();

// Add services to the container.
builder.Services.AddRazorPages();
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
app.UseAuthorization();
app.MapRazorPages();
app.Run();
