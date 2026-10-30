using Task_1.Interfaces;
using Task_1.Models;
namespace Task_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            // Register the data list service
            builder.Services.AddScoped<IDataListService, MonthService>();
            //builder.Services.AddScoped<IDataListService, WeekdayService>();

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Data}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
