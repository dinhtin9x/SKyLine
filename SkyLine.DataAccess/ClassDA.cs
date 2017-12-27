using System;
using System.Collections.Generic;
using SkyLine.Models;

namespace SkyLine.DataAccess
{
    public class ClassDA : DataAccessBase<Class>
    {
        public ClassDA() :base()
        {
        }

        public override int Add(Class b)
        {
            throw new NotImplementedException();
        }

        public int Delete(string id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Class> GetAll()
        {
            throw new NotImplementedException();
        }

        public Class GetById(string id)
        {
            throw new NotImplementedException();
        }

        public int Update(string id, Class b)
        {
            throw new NotImplementedException();
        }
    }
}
