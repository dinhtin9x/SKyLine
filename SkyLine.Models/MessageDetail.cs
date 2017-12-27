using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class MessageDetail
    {
        [Key]
        public int MessageDetailID { get; set; }

        public int MessageGroupID { get; set; }

        public string Content { get; set; }

        public byte? IsParentSend { get; set; }

        public string PersonSendID { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
