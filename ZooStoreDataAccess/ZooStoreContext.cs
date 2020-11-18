using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ZooStore.Domain.Entities;

namespace ZooStore.DataAccess
{
    public class ZooStoreContext : DbContext
    {
        public ZooStoreContext(DbContextOptions<ZooStoreContext> options) : base(options)
        {

        }

        public DbSet<FishEntity> Fish { get; set; }
        public DbSet<ParrotEntity> Parrots { get; set; }
        public DbSet<SnakeEntity> Snakes { get; set; }
    }
}
