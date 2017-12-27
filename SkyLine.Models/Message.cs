using System;
namespace SkyLine.Models
{
    public class Message
    {
        public int MessageGroupID
        {
            get;
            set;
        }
        public string StudentID
        {
            get;
            set;
        }

        public string Content
        {
            get;
            set;
        }

        public MessageDetail ChildMessages
        {
            get;
            set;
        }
    }
}
