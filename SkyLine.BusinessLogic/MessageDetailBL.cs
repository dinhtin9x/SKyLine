using System;
using System.Collections.Generic;
using SkyLine.DataAccess;
using SkyLine.Models;
using SkyLine.Constant;

namespace SkyLine.BusinessLogic
{
    public class MessageDetailBL
    {
        MessageDetailDA messageDetailDA;
        public MessageDetailBL()
        {
            messageDetailDA = new MessageDetailDA();
        }

        public IEnumerable<object> GetByGroupID(int id)
        {
            return messageDetailDA.GetByGroupID(id);
        }

        public MessageResponeModel Add(MessageDetail message)
        {
            MessageResponeModel returnModel = new MessageResponeModel();
            if (message.MessageGroupID == 0)
            {
                returnModel.MessageID = "002";
                returnModel.Message = MessageList.GetMessage("002", new string[] { "group id" });
                return returnModel;
            }

            if (string.IsNullOrEmpty(message.Content))
            {
                returnModel.MessageID = "002";
                returnModel.Message = MessageList.GetMessage("002", new string[] { "nội dung" });
                return returnModel;
            }
            int result = messageDetailDA.Add(message);
            if (result == 1)
            {
                returnModel.MessageID = "003";
                returnModel.Message = MessageList.GetMessage("003", new string[] { });
            }else
            {
                returnModel.MessageID = "002";
                returnModel.Message = MessageList.GetMessage("002", new string[] { });
            }
            return returnModel;
        }
    }
}
