using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LuminousCandle.Data;
using System;
using System.Linq;

namespace LuminousCandle.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LuminousCandleContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LuminousCandleContext>>()))
            {
                // Look for any movies.
                if (context.Candle.Any())
                {
                    return;   // DB has been seeded
                }

                context.Candle.AddRange(
                    new Candle
                    {
                        Name = "Summer Sunset",
                        DeliveryDate = DateTime.Parse("2023-10-15"),
                        Wax = "Coconut Breeze",
                        Fragrance = "Tropical Coconut",
                        Rating = 5
                    },

                    new Candle
                    {
                    Name = "Holiday Cheer",
                        DeliveryDate = DateTime.Parse("2023-4-16"),
                        Wax = "Spiced Apple",
                        Fragrance = "Warm Apple Pie",
                        Rating = 4
                    },

                    new Candle
                    {
                    Name = "Holiday Cheer",
                        DeliveryDate = DateTime.Parse("2023-8-12"),
                        Wax = "Spiced Apple",
                        Fragrance = "Warm Apple Pie",
                        Rating = 5
                    },

                    new Candle
                     {
                          Name = "Eucalyptus Zen",
                          DeliveryDate = DateTime.Parse("2023-2-1"),
                          Wax = "Eucalyptus Mint",
                          Fragrance = "Soothing Eucalyptus",
                          Rating = 3
                    },

                    new Candle
                        {
                            Name = "Vanilla Delight",
                            DeliveryDate = DateTime.Parse("2023-2-28"),
                            Wax = "Vanilla Bean",
                            Fragrance = "Sweet Vanilla",
                            Rating = 5
                    },

                     new Candle
                     {
                         Name = "Cozy Cabin",
                         DeliveryDate = DateTime.Parse("2023-10-16"),
                         Wax = "Cedarwood",
                         Fragrance = "Rustic Cedar",
                         Rating = 5
                     },

                    new Candle
                    {
                        Name = "Lemon Zest",
                        DeliveryDate = DateTime.Parse("2023-10-12"),
                        Wax = "Citrus Burst",
                        Fragrance = "Zingy Lemon",
                        Rating = 5
                    },

                    new Candle
                    {
                        Name = "Cinnamon Spice",
                        DeliveryDate = DateTime.Parse("2023-1-25"),
                        Wax = "Cinnamon Twist",
                        Fragrance = "Warm Cinnamon",
                        Rating = 4
                    },

                    new Candle
                    {
                        Name = "Oceanside Retreat",
                        DeliveryDate = DateTime.Parse("2023-6-10"),
                        Wax = "Ocean Breeze",
                        Fragrance = "Salty Sea Breeze",
                        Rating = 4
                    },

                      new Candle
                      {
                          Name = "Cherry Blossom",
                          DeliveryDate = DateTime.Parse("2023-7-27"),
                          Wax = "Cherry Blossom",
                          Fragrance = "Delicate Cherry Blossoms",
                          Rating = 4
                      }

                );
                context.SaveChanges();
            }
        }
    }
}
