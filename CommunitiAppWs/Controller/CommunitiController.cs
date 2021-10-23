using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using CommunitiApp.Models;

namespace CommunitiAppWs.Controller
{
    public class CommunitiController : ApiController
    {
        [HttpPost]
        public Int64 SaveCommuniti(Communiti communiti)
        {
            return communiti.Save();
        }
        [HttpPost]
        public List<Communiti> GetList([FromBody] string filter)
        {
            return new Communiti().GetList(filter);
        }
        [HttpPost]
        public int Delete([FromBody] Int32 id)
        {
            return new Communiti() { Id=id }.Delete();
            
        }
    }
}