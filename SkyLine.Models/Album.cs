using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }

        public string StudentID { get; set; }

        public string Title { get; set; }

        public byte? DelFlag { get; set; }

        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
