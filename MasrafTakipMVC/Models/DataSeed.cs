using Microsoft.EntityFrameworkCore;
namespace MasrafTakipMVC.Models
{
    public class DataSeed
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MasrafTakipContext>();
            context.Database.Migrate();

            }
        }


    }
