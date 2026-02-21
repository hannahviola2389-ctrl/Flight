using Microsoft.EntityFrameworkCore;

namespace Flight.Models
{
    public class FlightContext : DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> options)
            : base(options)
        { }

        public DbSet<FlightList> FlightList { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightList>().HasData(
                new FlightList
                {
                    FlightListId = 1,
                    FlightNumber = "AA101",
                    From = "New York",
                    To = "Chicago",
                    Date = "2026-03-10",
                    Price = 350
                },
                new FlightList
                {
                    FlightListId = 2,
                    FlightNumber = "DL202",
                    From = "Dallas",
                    To = "Los Angeles",
                    Date = "2026-03-12",
                    Price = 420
                },
                new FlightList
                {
                    FlightListId = 3,
                    FlightNumber = "UA303",
                    From = "Houston",
                    To = "Miami",
                    Date = "2026-03-15",
                    Price = 280
                },
                new FlightList
                {
                    FlightListId = 4,
                    FlightNumber = "SW404",
                    From = "Chicago",
                    To = "New York",
                    Date = "2026-03-18",
                    Price = 300
                },
                new FlightList
                {
                    FlightListId = 5,
                    FlightNumber = "JB505",
                    From = "Los Angeles",
                    To = "Dallas",
                    Date = "2026-03-20",
                    Price = 390
                }
            );
        }
    }
}
