using System;
using Newtonsoft.Json;

namespace SkyLine.Models
{
    public class StudentInfo
    {
        public string StudentId
        {
            get;
            set;
        }

        public string StudentLastName
        {
            get;
            set;
        }

        public string StudentName
        {
            get;
            set;
        }
        public byte? Gender
        {
            get;
            set;
        }
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime? BirthDate
        {
            get;
            set;
        }
        public string ParentId
        {
            get;
            set;
        }
        public string ImageLink
        {
            get;
            set;
        }
        public string ClassName
        {
            get;
            set;
        }

        public int? ClassLevel
        {
            get;
            set;
        }

    }
}
