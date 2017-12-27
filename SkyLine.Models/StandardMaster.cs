using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class StandardMaster
    {
        [Key]
        public int Month { get; set; }

        public double? SubstandardHeight { get; set; }

        public float? OverStandardHeight { get; set; }

        public float? SubstandardWeight { get; set; }

        public float? OverStandardWeight { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
