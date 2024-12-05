using Microsoft.EntityFrameworkCore;
using WeatherApp.Models;

namespace WeatherApp.Data
{
    public class AppDbContext : AppDbContext
    {
        public AppDbContext(DbContext<AppDbContext> options) : base(options) { }
        public DbSet<User> Users {  get; set; }
        public Db<WeatherData> WeatherData { get; set; }
        public DbSet<Alert> Alerts { get; set; }
    }
}