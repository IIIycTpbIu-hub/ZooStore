using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZooStore.DataAccess
{
    public interface IRepository<T>
    {
        public void Add(T data);
        public List<T> Get<TKey>(TKey key);
    }
}
