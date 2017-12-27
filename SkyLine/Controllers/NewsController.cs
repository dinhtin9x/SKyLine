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
    [Route("private/v1/news")]
    public class NewsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public ReturnListModel<News> Get(SearchModel searchModel)
        {
            //ReturnListModel<News> returnList = new ReturnListModel<News>();
            NewsBL newBL = new NewsBL();
            //returnList.Items = newBL.GetAll(searchModel);
            //returnList.Total = returnList.Items == null ? 0 : returnList.Items.Count();
            return new ReturnListModel<News>(newBL.GetAll(searchModel));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public News Get(int id)
        {
            NewsBL newBL = new NewsBL();
            return newBL.GetById(id);
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
