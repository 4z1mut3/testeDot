using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VibeApi.Models;

namespace VibeApi.Controllers
{
    public class TipoSeguroController : ApiController
    {        
        private ProvaVibe_00Entities db = new ProvaVibe_00Entities();

        // GET: api/TipoSeguro
        [HttpGet]
        public List<TIPOSEGURO> Get()
        {
            return db.TIPOSEGURO.ToList();
        }

        // GET: api/TipoSeguro/5
        public TIPOSEGURO Get(int id)
        {
            TIPOSEGURO tiposeguro = db.TIPOSEGURO.Find(id);
            if (tiposeguro == null)
            {
                return null;
            }
            else
            {
                return tiposeguro;
            }
        }

        // POST: api/TipoSeguro
        [HttpPost]
        public void create(string ds_tiposeguro, int carencia)
        {
            TIPOSEGURO tiposeguro = new TIPOSEGURO();
            tiposeguro.CARENCIA = carencia;
            tiposeguro.DS_TIPOSEGURO = ds_tiposeguro;
            tiposeguro.IDTIPOSEGURO += db.TIPOSEGURO.ToList().Count() + 1;
            if (tiposeguro != null)
            {
                try
                {
                    db.TIPOSEGURO.Add(tiposeguro);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
        }

        // PUT: api/TipoSeguro/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TipoSeguro/5
        public void Delete(int id)
        {
        }
    }
}
