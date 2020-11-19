using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ZooStore.Domain.Entities;

namespace ZooStore.DataAccess
{
    public class Repository : IRepository
    {
        ZooStoreContext _context;

        public Repository()
        {
            var options = new DbContextOptionsBuilder<ZooStoreContext>().UseInMemoryDatabase(databaseName: "ZooStore").Options;
            _context = new ZooStoreContext(options);
            RepositoryHelper helper = new RepositoryHelper(_context);
        }

        public IEnumerable<TEntity> Get<TEntity>(TEntity key)
        {
            switch (key)
            {
                case FishEntity fe:
                    return (IEnumerable<TEntity>)_context.Fish.ToListAsync<FishEntity>();
                default:
                    return null;
            }
        }

        public IEnumerable<AnimalBase> GetFish()
        {
            return _context.Fish.ToList();
        }
    }
}
