using System;
using System.Collections.Generic;
using SkyLine.Models;
using System.Linq;

namespace SkyLine.DataAccess
{
    public class MessageGroupDA : DataAccessBase<MessageGroup>
    {
        public MessageGroupDA() :base()
        {
        }

        public IEnumerable<MessageGroup> GetAllByStudent(string id, SearchModel searchModel)
        {
            var query = from messsageGroup in ctx.MessageGroup
                        select new { messsageGroup };

            if (!string.IsNullOrEmpty(id))
            {
                query = query.Where(x => x.messsageGroup.StudentID.Equals(id));
            }

            if (searchModel.Limit != null)
            {
                query = query.Take(searchModel.Limit.Value);
            }

            if (searchModel.Offset != null)
            {
                query = query.Skip(searchModel.Offset.Value);
            }

            return query.Select( x => x.messsageGroup).ToList();
            
        }

        public MessageGroup GetById(int id)
        {
            return ctx.MessageGroup.FirstOrDefault(x => x.MessageGroupID == id);
        }
    }
}
