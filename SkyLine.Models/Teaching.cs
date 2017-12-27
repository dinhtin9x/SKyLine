using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class Teaching
    {
        [Key]
        public string ClassID { get; set; }

        [Key]
        public string TeacherID { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
