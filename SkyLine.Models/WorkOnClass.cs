using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class WorkOnClass
    {
        [Key]
        public int WorkSeq { get; set; }

        public string ClassID { get; set; }

        public string PartOfDay { get; set; }

        public DateTime DateOfWork { get; set; }

        public string Content { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
