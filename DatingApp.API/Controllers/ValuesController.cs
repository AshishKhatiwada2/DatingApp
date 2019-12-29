using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       
        public ValuesController(DataContext context)
        {
            _Context = context;
        }

        public DataContext _Context { get; }

        [HttpGet ("{id}")]
        public async Task<IActionResult> Get(int ID)
        {
        //    List<value> listv= new List<value>();
        //     value v1= new value();
        //     value v2= new value();
        //     v1.id=3;
        //     v1.Name="ashish";
        //     v2.id=2;
        //     v2.Name="santosh";
        //     listv.Add(v1);
        //     listv.Add(v2);

            var onevalue=await _Context.Values.FirstOrDefaultAsync(x=>x.id ==ID);
            // return new  string[] {"value1","value2"};
            return Ok(onevalue);
        }
         [HttpGet]
        public async Task< IActionResult> Get()
        {
        //    List<value> listv= new List<value>();
        //     value v1= new value();
        //     value v2= new value();
        //     v1.id=3;
        //     v1.Name="ashish";
        //     v2.id=2;
        //     v2.Name="santosh";
        //     listv.Add(v1);
        //     listv.Add(v2);
            var listValue=await _Context.Values.ToListAsync();

            // return new  string[] {"value1","value2"};
            return Ok(listValue);
            
        }

        [HttpPost]
        public void HttpPost([FromBody] string value)
        {

        }
    }
}