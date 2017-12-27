using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class HealthDiary
    {
        [Key]
        public int DiarySeq { get; set; }

        public string StudentID { get; set; }

        public string SickName { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public string Symptom { get; set; }

        public string Note { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
