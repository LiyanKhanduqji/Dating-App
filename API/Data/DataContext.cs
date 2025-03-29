using System;
using API.Entities;
using Microsoft.EntityFrameworkCore; // this means that dbcontext class is located in EntityFrameworkCore namespace

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users {get; set;}
}
