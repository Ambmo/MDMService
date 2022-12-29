using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.DataContext;

public partial class VotingCloudDbContext : DbContext
{
    public VotingCloudDbContext()
    {
    }

    public VotingCloudDbContext(DbContextOptions<VotingCloudDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
