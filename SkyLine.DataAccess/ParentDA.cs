using System;
using System.Collections.Generic;
using SkyLine.Models;
using System.Linq;

namespace SkyLine.DataAccess
{
    public class ParentDA : DataAccessBase<Parent>
    {
        public ParentDA() :base()
        {
        }

        public override int Add(Parent b)
        {
            throw new NotImplementedException();
        }

        public int Delete(string id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Parent> GetAll()
        {
            return ctx.Parents.ToList();
        }

        public Parent GetById(string id)
        {
            return ctx.Parents.FirstOrDefault(x => x.ParentId.Equals(id));
        }

        public int Update(string id, Parent b)
        {
            throw new NotImplementedException();
        }
    }
}
