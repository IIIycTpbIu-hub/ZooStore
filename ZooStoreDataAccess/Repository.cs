using System;
using System.Collections;
using System.Collections.Generic;

namespace ZooStore.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Dictionary<Type, List<T>> Data;

        public void Add(T data)
        {
            Type t = data.GetType();
            List<T> list;
            if (!Data.ContainsKey(t))
            {
                list = new List<T>();
                list.Add(data);
                Data.Add(t, list);
            }
            else
            {
                list = Data[t];
                list.Add(data);
            }
        }

        public List<T> Get<TKey>(TKey key)
        {
            return Data[key.GetType()];
        }
    }
}
