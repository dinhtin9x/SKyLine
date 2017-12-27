using System;
using System.Collections.Generic;
using SkyLine.DataAccess;
using SkyLine.Models;

namespace SkyLine.BusinessLogic
{
    public class NewsBL
    {
        NewsDA newsDA;
        public NewsBL()
        {
            newsDA = new NewsDA();
        }

        public IEnumerable<News> GetAll(SearchModel searchModel)
        {
            return newsDA.GetAll(searchModel);
        }

        public News GetById(int id)
        {
            return newsDA.GetById(id);
        }
    }
}
