using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class MasterCode
    {
        [Key]
        public string MasterID { get; set; }

        public string MasterName { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
