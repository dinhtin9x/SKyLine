using System;
using Newtonsoft.Json.Converters;

namespace SkyLine.Models
{
    public class CustomDateTimeConverter: IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            base.DateTimeFormat = "dd/MM/yyyy";
        }
    }
}
