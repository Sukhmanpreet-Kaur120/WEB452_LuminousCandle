using Microsoft.EntityFrameworkCore;
using LuminousCandle.Models;

namespace LuminousCandle.Data
{
    public class LuminousCandleContext : DbContext
    {
        public LuminousCandleContext(DbContextOptions<LuminousCandleContext> options)
            : base(options)
        {
        }

        public DbSet<Candle> Candle { get; set; }
    }
}