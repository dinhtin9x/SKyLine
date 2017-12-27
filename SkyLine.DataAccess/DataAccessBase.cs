using System;
using System.Collections.Generic;

namespace SkyLine.DataAccess
{
    public class DataAccessBase<TEntity> where TEntity : class
    {
        protected readonly AppContext ctx = new AppContext();
        public DataAccessBase()
        {
        }

        public virtual int Add(TEntity b)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();

        }
    }
}
