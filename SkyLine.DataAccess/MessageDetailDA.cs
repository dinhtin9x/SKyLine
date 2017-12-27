using System;
using System.Collections.Generic;
using SkyLine.Models;
using System.Linq;

namespace SkyLine.DataAccess
{
    public class MessageDetailDA : DataAccessBase<MessageDetail>
    {
        public MessageDetailDA() : base()
        {
        }

        public IEnumerable<object> GetByGroupID(int id)
        {
            return ctx.MessageDetail.Where(x => x.MessageGroupID == id).Select(x => new { messageID = x.MessageDetailID, personSendID = x.PersonSendID, content = x.Content }).ToList(); ;
        }

        public override int Add(MessageDetail message)
        {
            message.DelFlag = 0;
            message.CreateDate = DateTime.Now;
            message.UpdateDate = DateTime.Now;
            ctx.MessageDetail.Add(message);
            int res = ctx.SaveChanges();
            return res;
        }
    }
}
