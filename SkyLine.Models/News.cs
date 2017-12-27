using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class News
    {
        [Key]
        public int NotificationID { get; set; }

        public string NotificationTitle { get; set; }

        public string NotificationContent { get; set; }

        public int? LevelID { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
