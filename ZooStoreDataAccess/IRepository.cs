using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZooStore.DataAccess
{
    public interface IRepository
    {
        public List<object> Get<TKey>(TKey key);
    }
}
