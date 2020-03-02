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
    public class SamolotWojskowyController : ControllerBase
    {
        // GET: api/SamolotWojskowy
        [HttpGet]
        public IEnumerable<SamolotWojskowy> Get()
        {
            string fileName = "Samoloty.json";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string jsonString = System.IO.File.ReadAllText(path);
            JObject o = JObject.Parse(jsonString);
            JArray a = (JArray)o["SamolotWojskowy"];
            IList<SamolotWojskowy> samolotyWojskowe = a.ToObject<IList<SamolotWojskowy>>();
            return samolotyWojskowe;
        }

        // GET: api/SamolotWojskowy/5
        [HttpGet("{id}", Name = "GetSamolotWojskowy")]
        public SamolotWojskowy Get(int id)
        {
            string fileName = "Samoloty.json";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string jsonString = System.IO.File.ReadAllText(path);
            JObject o = JObject.Parse(jsonString);
            JArray a = (JArray)o["SamolotWojskowy"];
            IList<SamolotWojskowy> samolotyWojskowe = a.ToObject<IList<SamolotWojskowy>>();
            return samolotyWojskowe[id];
        }

        // POST: api/SamolotWojskowy
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/SamolotWojskowy/5
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
