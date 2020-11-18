using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
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
        }

        public List<object> Get<TKey>(TKey key)
        {
            List<object> result = new List<object>();
            switch (key)
            {
                case FishEntity f:
                    var fishList = _context.Fish.ToListAsync().Result;
                    foreach (var fish in fishList)
                    {
                        result.Add(fish);
                    }
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return result;
        }
    }
}
