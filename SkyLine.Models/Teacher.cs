using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class Teacher
    {
        [Key]
        public string TeacherID { get; set; }

        public string TeacherLastName { get; set; }

        public string TeacherName { get; set; }

        public byte? Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public string PhoneNumber1 { get; set; }

        public string PhoneNumber2 { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Province { get; set; }

        public string ImageLink { get; set; }

        public byte? IsNotification { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
