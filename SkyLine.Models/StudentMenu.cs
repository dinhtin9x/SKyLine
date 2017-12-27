using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class StudentMenu
    {
        [Key]
        public int MenuID { get; set; }

        public string MealID { get; set; }

        public DateTime Date { get; set; }

        public string ClassID { get; set; }

        public string Meal { get; set; }

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
