﻿using MauiBlazorEvidence.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace MauiBlazorEvidence.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
