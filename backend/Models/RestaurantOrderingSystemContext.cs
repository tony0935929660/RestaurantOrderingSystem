using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

public partial class RestaurantOrderingSystemContext : DbContext
{
    public RestaurantOrderingSystemContext()
    {
    }

    public RestaurantOrderingSystemContext(DbContextOptions<RestaurantOrderingSystemContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
