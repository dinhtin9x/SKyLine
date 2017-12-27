using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SkyLine.Models
{
    public class Parent
    {
        [Key]

        public string ParentId { get; set; }

        public string ParentLastName { get; set; }

        public string ParentName { get; set; }

        public byte? Gender { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
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
