using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VibeApi.Models;

namespace VibeApi.Controllers
{
    public class seguradoController : ApiController
    {

        //private static List<SEGURADO> segurados = new List<SEGURADO>();
        private ProvaVibe_00Entities db = new ProvaVibe_00Entities();
        // GET: api/segurado
        public IEnumerable<SEGURADO> Get()
        {
            return db.SEGURADO.ToList();
        }

        // GET: api/segurado/idusuario 
        public SEGURADO Get(int id)
        {
            SEGURADO segurado = db.SEGURADO.Find(id);
            if (segurado == null)
            {
                return null;
            }
            else {
                return segurado;
            }
            
        }

        // POST: api/segurado
        [HttpPost]
        public void create(string nome,string dtnascimento, string cpf)
        {
            SEGURADO novoSegurado = new SEGURADO();
            novoSegurado.NOMESEGURADO = nome;
            novoSegurado.DTNASC = Convert.ToDateTime(dtnascimento);
            novoSegurado.CPF = cpf;
            //novoSegurado.IDSEGURADO += 1;
            if (novoSegurado != null)
            {
                
                try {
                    db.SEGURADO.Add(novoSegurado);
                    db.SaveChanges();
                }
                catch (Exception ex){
                    
                }

                
            }
        }

        // PUT: api/segurado/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/segurado/5
        public void Delete(int id)
        {
        }
    }
}
