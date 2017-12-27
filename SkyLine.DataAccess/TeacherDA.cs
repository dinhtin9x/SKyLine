using System;
using System.Collections.Generic;
using SkyLine.Models;

namespace SkyLine.DataAccess
{
    public class TeacherDA : DataAccessBase<Teacher>
    {
        public TeacherDA() :base()
        {
        }

        public override int Add(Teacher b)
        {
            throw new NotImplementedException();
        }

        public int Delete(string id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Teacher> GetAll()
        {
            throw new NotImplementedException();
        }

        public Teacher GetById(string id)
        {
            throw new NotImplementedException();
        }

        public int Update(string id, Teacher b)
        {
            throw new NotImplementedException();
        }
    }
}
