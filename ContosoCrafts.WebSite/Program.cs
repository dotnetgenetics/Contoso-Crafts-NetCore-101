using ContosoCrafts.WebSite.Services;

namespace ContosoCrafts.WebSite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            //blazor component
            builder.Services.AddServerSideBlazor();
            //map controllers
            builder.Services.AddControllers();
            //inject JsonFileProductService
            builder.Services.AddTransient<JsonFileProductService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            else
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //setup endpoints
            app.MapRazorPages();
            app.MapControllers();
            app.MapBlazorHub();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //    endpoints.MapControllers();
            //    endpoints.MapBlazorHub(); //blazor
            //});

            app.Run();
        }
    }
}
