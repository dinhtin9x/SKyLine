using System;
using System.Collections.Generic;
using SkyLine.DataAccess;
using SkyLine.Models;

namespace SkyLine.BusinessLogic
{
    public class MessageGroupBL
    {
        MessageGroupDA messageGroupDA;
        public MessageGroupBL()
        {
            messageGroupDA = new MessageGroupDA();
        }

        public IEnumerable<MessageGroup> GetAllByStudent(string id, SearchModel searchModel)
        {
            return messageGroupDA.GetAllByStudent(id, searchModel);
        }

        public MessageGroup GetById(int id)
        {
            return messageGroupDA.GetById(id);
        }
    }
}
