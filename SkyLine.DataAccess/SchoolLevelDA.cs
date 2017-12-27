using System;
using System.Collections.Generic;
using SkyLine.Models;

namespace SkyLine.DataAccess
{
    public class SchoolLevelDA : DataAccessBase<SchoolLevel>
    {
        public SchoolLevelDA() : base()
        {
        }

        public override int Add(SchoolLevel b)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<SchoolLevel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Class GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, SchoolLevel b)
        {
            throw new NotImplementedException();
        }
    }
}
