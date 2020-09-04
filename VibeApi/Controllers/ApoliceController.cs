using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VibeApi.Models;

namespace VibeApi.Controllers
{
    public class ApoliceController : ApiController
    {
        private ProvaVibe_00Entities db = new ProvaVibe_00Entities();
        // GET: api/Apolice
        public List<APOLICE> Get()
        {
            return db.APOLICE.ToList();
        }

        // GET: api/Apolice/5
        public APOLICE Get(int id)
        {
            APOLICE apolice = db.APOLICE.Find(id);
            if (apolice == null)
            {
                return null;
            }
            else
            {
                return apolice;
            }
        }

        // POST: api/Apolice
        [HttpPost]
        public void Create([FromBody]string value)
        {

        }

        // PUT: api/Apolice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apolice/5
        public void Delete(int id)
        {
        }
    }
}
