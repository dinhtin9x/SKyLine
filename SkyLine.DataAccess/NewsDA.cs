using System;
using System.Collections.Generic;
using SkyLine.Models;
using System.Linq;

namespace SkyLine.DataAccess
{
    public class NewsDA : DataAccessBase<News>
    {
        public NewsDA() : base()
        {
        }

        public IEnumerable<News> GetAll(SearchModel searchModel)
        {
            var query = from news in ctx.News select news;
            
            if (searchModel.Limit != null)
            {
                query = query.Take(searchModel.Limit.Value);
            }

            if (searchModel.Offset != null)
            {
                query = query.Skip(searchModel.Offset.Value);
            }

            return query.ToList();
        }

        public News GetById(int id)
        {
            return ctx.News.FirstOrDefault(b => b.NotificationID == id);
        }
    }
}
