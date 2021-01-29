using System;
using ECommerce.DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccesslayer
{
    public class CommerceContext : DbContext
    {
        private readonly string _connectionString;

        public CommerceContext(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(_connectionString);
        }
    }
}