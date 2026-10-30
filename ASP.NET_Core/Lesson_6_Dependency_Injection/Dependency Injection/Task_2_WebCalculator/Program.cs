using Task_2_WebCalculator.Services.Implementations;
using Task_2_WebCalculator.Services.Interfaces;

namespace Task_2_WebCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            // Реєстрація CalcService в DI-контейнері
            builder.Services.AddTransient<ICalcService, CalcService>();

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Calc}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
