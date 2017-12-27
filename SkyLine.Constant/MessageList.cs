using System;
using System.Collections.Generic;
using System.Linq;
namespace SkyLine.Constant
{
    public static class MessageList
    {
        private static Dictionary<string, string> messageList = new Dictionary<string, string>()
        {
            { "001", "Đăng ký thông tin không thành công!" }
            , { "002", "Xin hãy nhập {0}!"  }
            , { "003", "Đăng ký thông tin thành công!"  }
        };

        public static string GetMessage(string id, string[] param)
        {
            var messageFilter = messageList.FirstOrDefault(x => x.Key.Equals(id));
            switch (param.Count())
            {
                case 1:
                    return string.Format(messageFilter.Value, param[0]);
                case 2:
                    return string.Format(messageFilter.Value, param[0], param[1]);
                case 3:
                    return string.Format(messageFilter.Value, param[0], param[1], param[2]);
                case 4:
                    return string.Format(messageFilter.Value, param[0], param[1], param[2], param[3]);
                default:
                    return messageFilter.Value;
            }
        }
    }
}
