using System;
using CB.DOMAIN;
using Microsoft.EntityFrameworkCore;

namespace CB.PERSISTENCE;

public class AppDbContext(DbContextOptions options): DbContext(options)
{
    public required DbSet<Activity> Activities { get; set; }
}