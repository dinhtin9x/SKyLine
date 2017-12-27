using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkyLine.BusinessLogic;
using SkyLine.Models;
using Newtonsoft;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkyLine.Controllers
{
    [Route("private/v1/messages")]
    public class MessageController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [HttpGet("student/{id}")]
        public ReturnListModel<MessageGroup> GetAllByStudent(string id, SearchModel searchModel)
        {
            MessageGroupBL messageGroupBL = new MessageGroupBL();
            return new ReturnListModel<MessageGroup>(messageGroupBL.GetAllByStudent(id, searchModel));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            MessageGroupBL messageGroupBL = new MessageGroupBL();
            MessageDetailBL messageDetailBL = new MessageDetailBL();
            MessageGroup messageGroupInfo = messageGroupBL.GetById(id);
            IEnumerable<object> messageInfo = messageDetailBL.GetByGroupID(id);

            return Json(new { messageGroupID = messageGroupInfo.MessageGroupID, studentID = messageGroupInfo.StudentID, content = messageGroupInfo.Content, childMessages = messageInfo });


        }

        // POST api/values
        [HttpPost]
        public MessageResponeModel Post(MessageDetail message)
        {
            MessageDetailBL messageDetailBL = new MessageDetailBL();
            return messageDetailBL.Add(message);
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
