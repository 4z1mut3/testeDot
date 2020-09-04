using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VibeApi.Models;

namespace VibeApi.Controllers
{
    public class ApolicesController : ApiController
    {

        private ProvaVibe_00Entities db = new ProvaVibe_00Entities();

        // GET: api/Apolices
        [HttpGet]
        public List<APOLICE> Get()
        {

            return db.APOLICE.ToList();
        }

        // GET: api/Apolices/5
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

        // POST: api/Apolices
        [HttpPost]
        public void create(int idsegurado)
        {
            APOLICE novaApolice = new APOLICE();

            //novaApolice.IDSEGURADO

        }

        // PUT: api/Apolices/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apolices/5
        public void Delete(int id)
        {
        }
    }
}
