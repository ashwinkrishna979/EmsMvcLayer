using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UploadFile : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<String>> GetEmployee()  // Getting Employee
        {
            var list = new List<string>();
            list.Add("Rohit");
            list.Add("Ashvin");
            list.Add("Aman");
            list.Add("Devendra");
            return Ok(list);
        }

    }
}
