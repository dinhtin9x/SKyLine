using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class Class
    {
        [Key]
        public string ClassID { get; set; }

        public string ClassName { get; set; }

        public string ClassInfo { get; set; }

        public string Status { get; set; }

        public int LevelID { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
