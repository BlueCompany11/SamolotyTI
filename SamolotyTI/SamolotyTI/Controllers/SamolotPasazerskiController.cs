using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace SamolotyTI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamolotPasazerskiController : ControllerBase
    {
        // GET: api/SamolotPasazerski
        [HttpGet]
        public IEnumerable<SamolotPasazerski> Get()
        {
            string fileName = "Samoloty.json";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string jsonString = System.IO.File.ReadAllText(path);
            JObject o = JObject.Parse(jsonString);
            JArray a = (JArray)o["SamolotyPasazerskie"];
            IList<SamolotPasazerski> samolotyPasazerskie = a.ToObject<IList<SamolotPasazerski>>();
            return samolotyPasazerskie;
        }

        // GET: api/SamolotPasazerski/5
        [HttpGet("{id}", Name = "GetSamolotPasazerski")]
        public SamolotPasazerski Get(int id)
        {
            string fileName = "Samoloty.json";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string jsonString = System.IO.File.ReadAllText(path);
            JObject o = JObject.Parse(jsonString);
            JArray a = (JArray)o["SamolotyPasazerskie"];
            IList<SamolotPasazerski> samolotyPasazerskie = a.ToObject<IList<SamolotPasazerski>>();
            return samolotyPasazerskie[id];
        }

        // POST: api/SamolotPasazerski
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT: api/SamolotPasazerski/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
