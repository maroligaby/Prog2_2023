using Microsoft.EntityFrameworkCore;
using PSIUWeb.Models;

namespace PSIUWeb.Data
{
    public static class SeedData
    {

        public static void EnsurePopulated(
            IApplicationBuilder app
        )
        {

            AppDbContext context =
                app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<AppDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if( !context.Pacients.Any())
            {
                context.Pacients.AddRange(

                    new Pacient
                    {
                        Name = "Mauricio",
                        BirthDate = new DateTime(1984,7,5),
                        Race = Race.Pardo,
                        Height = 180,
                        Weight = 88
                    },

                    new Pacient
                    {
                        Name = "Gaby",
                        BirthDate = new DateTime(2004, 8, 19),
                        Race = Race.Branco,
                        Height = 160,
                        Weight = 50
                    }
                );

                context.SaveChanges();
            }

        }

    }
}
