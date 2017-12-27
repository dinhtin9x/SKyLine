using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class MasterCodeDetail
    {
        [Key]
        public string MasterID { get; set; }

        [Key]
        public string MasterDetailID { get; set; }

        public string MasterDetailName { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
