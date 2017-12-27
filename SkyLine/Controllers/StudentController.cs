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
    [Route("private/v1/students")]
    public class StudentController : Controller
    {
        // GET: student/
        //[HttpGet]
        //public IEnumerable<Student> Get()
        //{
        //    StudentBL studentBL = new StudentBL();
        //    return studentBL.GetAll();
        //}

        // GET: student/
        [HttpGet]
        public ReturnListModel<StudentInfo> Get(StudentSearch searchModel)
        {
            //ReturnListModel<StudentInfo> returnList = new ReturnListModel<StudentInfo>();
            StudentBL studentBL = new StudentBL();
            //returnList.Items = studentBL.GetAll(searchModel);
            //returnList.Total = returnList.Items == null ? 0 : returnList.Items.Count();

            return new ReturnListModel<StudentInfo>(studentBL.GetAll(searchModel));
        }

        // GET student/id
        [HttpGet("{id}")]
        public Student Get(string id)
        {
            StudentBL studentBL = new StudentBL();
            return studentBL.GetById(id);
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
