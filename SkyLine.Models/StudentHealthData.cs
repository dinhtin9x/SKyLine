using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class StudentHealthData
    {
        [Key]
        public int Month { get; set; }

        [Key]
        public string StudentID { get; set; }

        public float? Height { get; set; }

        public float? Weight { get; set; }

        public DateTime? MeasurementDate { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
