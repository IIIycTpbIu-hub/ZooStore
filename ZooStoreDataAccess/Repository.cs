﻿using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<AnimalBase> GetAnimals()
        {
            return _context.Animals;
        }

        public IEnumerable<TEnimalEntity> GetAnimalByEnitiy<TEnimalEntity>() where TEnimalEntity : AnimalBase
        {
            List<TEnimalEntity> result = new List<TEnimalEntity>();

            foreach (var animal in _context.Animals)
            {
                if(animal is TEnimalEntity)
                {
                    result.Add((TEnimalEntity)animal);
                }
            }
            return result;
        }
    }
}
