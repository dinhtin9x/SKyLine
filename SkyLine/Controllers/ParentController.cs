using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkyLine.BusinessLogic;
using SkyLine.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkyLine.Controllers
{
    [Route("private/v1/profile")]
    public class ParentController : Controller
    {
        // GET: api/values
        [HttpGet]
        public ReturnListModel<Parent> Get()
        {
            ParentBL parentBL = new ParentBL();
            return new ReturnListModel<Parent>(parentBL.GetAll());

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Parent Get(string id)
        {
            return new ParentBL().GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
