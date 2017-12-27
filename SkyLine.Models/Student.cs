using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyLine.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StudentID { get; set; }

        public string StudentLastName { get; set; }

        public string StudentName { get; set; }

        public byte? Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public string ImageLink { get; set; }

        public string ParentId { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
