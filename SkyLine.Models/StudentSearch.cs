using System;
namespace SkyLine.Models
{
    public class StudentSearch : SearchModel
    {
        public string ParentId
        {
            get;
            set;
        }

        public int? ClassLevel
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

    }
}
