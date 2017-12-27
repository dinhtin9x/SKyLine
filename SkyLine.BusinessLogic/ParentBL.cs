using System;
using System.Collections.Generic;
using SkyLine.DataAccess;
using SkyLine.Models;

namespace SkyLine.BusinessLogic
{
    public class ParentBL
    {
        ParentDA parentDA;
        public ParentBL()
        {
            parentDA = new ParentDA();
        }

        public Parent GetById(string id){
            return parentDA.GetById(id);
        }

        public IEnumerable<Parent> GetAll(){
            return parentDA.GetAll();
        }
    }
}
