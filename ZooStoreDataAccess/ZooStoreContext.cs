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

        public DbSet<AnimalBase> Animals { get; set; }
    }
}
