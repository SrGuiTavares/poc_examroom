﻿using CarDealer.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Infra.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
