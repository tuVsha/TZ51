using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Games.BL;
using Microsoft.EntityFrameworkCore;

namespace Games.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=TZapricode; Trusted_Connection=True");
        }

        public static void GenerateData(ApplicationDbContext context)
        {
            using (context)
            {
                var dev1 = new Developer() { Name = "L.S. Play with" };
                var dev2 = new Developer() { Name = "Urban Games" };
                var dev3 = new Developer() { Name = "CarX Tech" };
                if (!context.Developers.Any())
                {
                    context.Developers.AddRange(new List<Developer>() { dev1, dev2, dev3 });
                    context.SaveChanges();
                }
                var genre1 = new Genre() { Name = "Adventure" };
                var genre2 = new Genre() { Name = "Role-play" };
                var genre3 = new Genre() { Name = "Simulator" };
                var genre4 = new Genre() { Name = "Sports" };
                var genre5 = new Genre() { Name = "Horror" };
                var genre6 = new Genre() { Name = "Strategy" };
                var genre7 = new Genre() { Name = "Action" };
                var game2 = new Game() { Name = "Brave history", DeveloperId = 1, Genres = new List<Genre>() { genre1, genre2, genre5, genre7 } };
                var game1 = new Game() { Name = "Cool Races", DeveloperId = 3, Genres = new List<Genre>() { genre3, genre4, genre7 } };
                var game3 = new Game() { Name = "Sword and fire", DeveloperId = 1, Genres = new List<Genre>() { genre1, genre2, genre3, genre6 } };
                var game4 = new Game() { Name = "Bas Simulator", DeveloperId = 2, Genres = new List<Genre>() { genre2, genre3 } };
                var game5 = new Game() { Name = "Scary Lisa", DeveloperId = 1, Genres = new List<Genre>() { genre5, genre7 } };
                var game6 = new Game() { Name = "Fallen house", DeveloperId = 1, Genres = new List<Genre>() { genre5 } };
                var game7 = new Game() { Name = "City to live", DeveloperId = 2, Genres = new List<Genre>() { genre3, genre7 } };
                var game8 = new Game() { Name = "Deliveryman", DeveloperId = 2, Genres = new List<Genre>() { genre2, genre3, genre4, genre7 } };
                if (!context.Games.Any() && !context.Genres.Any())
                {
                    context.Genres.AddRange(new List<Genre>() { genre1, genre2, genre3, genre4, genre5, genre6, genre7 });
                    context.Games.AddRange(new List<Game>() { game1, game2, game3, game4, game5, game6, game7, game8 });
                    context.SaveChanges();
                }
            }
        }
    }
}
