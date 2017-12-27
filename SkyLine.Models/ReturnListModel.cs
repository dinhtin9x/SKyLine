using System;
using System.Collections.Generic;
using System.Linq;

namespace SkyLine.Models
{
    public class ReturnListModel<T>
    {
        public ReturnListModel(IEnumerable<T> list){
            Items = list;
            Total = list == null ? 0 : list.Count();
        }
        public int Total
        {
            get;
            set;
        }
        public IEnumerable<T> Items
        {
            get;
        set;
        }
    }
}
