using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public byte? ClassifyCode { get; set; }

        public string MenberID { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
