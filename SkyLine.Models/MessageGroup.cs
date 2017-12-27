using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SkyLine.Models
{
    public class MessageGroup
    {
        [Key]
        public int MessageGroupID { get; set; }

        public string StudentID { get; set; }

        public string Content { get; set; }

        [JsonIgnore]
        public byte? DelFlag { get; set; }

        [JsonIgnore]
        public string CreateUser { get; set; }

        [JsonIgnore]
        public DateTime? CreateDate { get; set; }

        [JsonIgnore]
        public string UpdateUser { get; set; }

        [JsonIgnore]
        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        [JsonIgnore]
        public byte[] RowVersion { get; set; }

    }
}
