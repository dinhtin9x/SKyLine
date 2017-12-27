using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class ClassDetail
    {
        [Key]
        public string ClassID { get; set; }

        [Key]
        public string StudentID { get; set; }

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
