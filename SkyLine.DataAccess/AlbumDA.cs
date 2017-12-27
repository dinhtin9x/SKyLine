using System;
using System.Collections.Generic;
using SkyLine.Models;

namespace SkyLine.DataAccess
{
    public class AlbumDA : DataAccessBase<Album>
    {
        public AlbumDA() : base()
        {
        }

        public new int Add(Album b)
        {
            throw new NotImplementedException();
        }

        public int Delete(string id)
        {
            throw new NotImplementedException();
        }

        public new IEnumerable<Album> GetAll()
        {
            throw new NotImplementedException();
        }

        public Album GetById(string id)
        {
            throw new NotImplementedException();
        }

        public int Update(string id, Album b)
        {
            throw new NotImplementedException();
        }
    }
}
