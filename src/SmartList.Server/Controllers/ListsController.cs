using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SmartList.Models;

namespace SmartList.Server.Controllers
{
    public class ListController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<CheckableList> Get()
        {
            return new List<CheckableList>
            {
                GetSampleList() //.ToDescription()
            };
        }

        private static CheckableList GetSampleList()
        {
            return new CheckableList
            {
                Id = Guid.NewGuid(),
                Name = "List 1",
                CreateDate = DateTime.Today.AddDays(-3),
                LastModifiedDate = DateTime.Today.AddMinutes(-3)
            };
        }

        // GET api/<controller>/5
        public CheckableList Get(int id)
        {
            return GetSampleList();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}