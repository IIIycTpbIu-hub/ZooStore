using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZooStore.DataAccess
{
    public interface IRepository
    {
        IEnumerable<TEntity> Get<TEntity>(TEntity key);
    }
}
