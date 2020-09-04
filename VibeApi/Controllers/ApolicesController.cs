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
        
        public IEnumerable<APOLICE> Get()
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
        public void create(int idsegurado,int idtiposeguro, string dtinivig,string dtfimvig , int status, int fn_numParcela, string fn_dataVencimento, decimal fn_valorParcela, string fn_dataPagamento, int fn_status, decimal fn_valorpgto)
        {
            APOLICE novaApolice = new APOLICE();
            novaApolice.IDSEGURADO = idsegurado;
            novaApolice.IDTIPOSEGURO = idtiposeguro;
            novaApolice.DTINIVIG = Convert.ToDateTime(dtinivig);
            novaApolice.DTFIMVIG = Convert.ToDateTime(dtfimvig);
            novaApolice.STATUSAPOLICE = status;
            novaApolice.IDAPOLICE += db.APOLICE.ToList().Count() + 1;

            FINANCEIROAPOLICE financeiroApolice = new FINANCEIROAPOLICE();
            financeiroApolice.VALORPARCELA = fn_valorParcela;
            financeiroApolice.VALORCOMISSAO = (((fn_valorParcela * Convert.ToDecimal(0.6)) / 100) * Convert.ToDecimal(0.35));
            financeiroApolice.DTVENCIMENTO = Convert.ToDateTime(fn_dataVencimento);
            financeiroApolice.DTPAGTO = Convert.ToDateTime(fn_dataPagamento);
            financeiroApolice.NUMPARCELA = fn_numParcela;
            financeiroApolice.STATUS = fn_status;
            financeiroApolice.VALORPAGTO = fn_valorpgto;
            financeiroApolice.IDFINANAPOLICE += db.FINANCEIROAPOLICE.ToList().Count() + 1;
            financeiroApolice.IDAPOLICE = novaApolice.IDAPOLICE;


            if (novaApolice != null)
            {
                try
                {
                    db.APOLICE.Add(novaApolice);
                    db.FINANCEIROAPOLICE.Add(financeiroApolice);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
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
