using System;
using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class Image
    {
        [Key]
        public int ImageID { get; set; }

        public int AlbumID { get; set; }

        public string ImageLink { get; set; }

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
