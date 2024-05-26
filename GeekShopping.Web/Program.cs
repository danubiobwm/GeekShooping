using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        //Register the HttpClient
        builder.Services.AddHttpClient<IProductService, ProductService>(client =>
        {
            string? uriString = builder.Configuration["ServiceUrls:ProductAPI"];
            client.BaseAddress = new Uri(uriString: uriString);
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

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}