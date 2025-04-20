using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SeedDbData
{
    internal class Program()
    {

        static void Main(string[] args)
        {

            var options = new DbContextOptionsBuilder<SeedDataDbContext>()
                .UseSqlServer("").Options;

            using var context = new SeedDataDbContext(options);

            Console.WriteLine("Press 1 to seed data");
            Console.WriteLine("Press 3 to restor database and data");
            string key = Console.ReadLine();
            if (key == "1")
            {
                SeedDatabase(context);
            }
            else if (key == "3")
            {
                RestoreDataInDatabase(context);
            }

        }
        private static void SeedDatabase(SeedDataDbContext context)
        {
            if (!context.Nations.Any())
            {
                var nations = SeedData.GetSeedNations();
                context.Nations.AddRange(nations);
                context.SaveChanges();
            }
            if (!context.HockeyPlayers.Any())
            {
                var players = SeedData.GetSeededHockeyPlayers();
                context.HockeyPlayers.AddRange(players);
                context.SaveChanges();
               
            }
            
            Console.WriteLine("Database seeded successfully!");
        }

        private static void RestoreDataInDatabase(SeedDataDbContext context)
        {
            context.Database.ExecuteSqlRaw("" +
                "DROP TABLE IF EXISTS HockeyPlayers\r\n" +
                "DROP TABLE IF EXISTS Nations\r\n\r\n" +
                "CREATE TABLE Nations (\r\n\t" +
                "Id INT IDENTITY(1,1) Not Null,\r\n\t" +
                "Nationality NVARCHAR(100) NOT NULL,\r\n\t" +
                "PRIMARY KEY (Id),\r\n);\r\n" +
                "CREATE TABLE HockeyPlayers(\r\n\t" +
                "Id INT IDENTITY(1,1) NOT NULL,\r\n\t" +
                "FullName NVARCHAR(100) NOT NULL,\r\n\t" +
                "HightInCm INT NOT NULL,\r\n\tWeightInKg INT NOT NULL,\r\n\t" +
                "Club NVARCHAR(100) NOT NULL,\r\n\t" +
                "Position NVARCHAR(50) NOT NULL,\r\n\t" +
                "Age INT NOT NULL,\r\n\t" +
                "NationId INT NOT NULL,\r\n\t" +
                "PRIMARY KEY (Id),\r\n\t" +
                "FOREIGN KEY (NationId) REFERENCES Nations(Id)\r\n);\r\n\r\n\r\n" +
                "CREATE INDEX IX_HockeyPlayers_FullName ON HockeyPlayers(FullName);");
            SeedDatabase(context);
        }
    }
}
