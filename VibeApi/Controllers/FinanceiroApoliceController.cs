using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VibeApi.Models;

namespace VibeApi.Controllers
{

    public class FinanceiroApoliceController : ApiController
    {
        private ProvaVibe_00Entities db = new ProvaVibe_00Entities();

        // GET: api/FinanceiroApolice
        [HttpGet]
        public List<FINANCEIROAPOLICE> Get()
        {
            return db.FINANCEIROAPOLICE.ToList();
        }

        // GET: api/FinanceiroApolice/5
        [HttpGet]
        public FINANCEIROAPOLICE Get(int id)
        {
            FINANCEIROAPOLICE financeiroApolice = db.FINANCEIROAPOLICE.Find(id);
            if (financeiroApolice == null)
            {
                return null;
            }
            else
            {
                return financeiroApolice;
            }
            
        }

        // POST: api/FinanceiroApolice
        [HttpPost]
        public void Create(int numParcela, string dataVencimento, decimal valorParcela, string dataPagamento,int status,decimal valorpgto, int idapolice)
        {
            FINANCEIROAPOLICE financeiroApolice = new FINANCEIROAPOLICE();

            financeiroApolice.VALORPARCELA = valorParcela;
            financeiroApolice.VALORCOMISSAO = (((valorParcela * Convert.ToDecimal(0.6))/100) * Convert.ToDecimal(0.35));
            financeiroApolice.DTVENCIMENTO = Convert.ToDateTime(dataVencimento);
            financeiroApolice.DTPAGTO = Convert.ToDateTime(dataPagamento);
            financeiroApolice.NUMPARCELA = numParcela;
            financeiroApolice.STATUS = status;
            financeiroApolice.VALORPAGTO = valorpgto;
            financeiroApolice.IDFINANAPOLICE += db.FINANCEIROAPOLICE.ToList().Count() + 1;
            financeiroApolice.IDAPOLICE = idapolice;
            if (financeiroApolice != null)
            {
                try
                {
                    db.FINANCEIROAPOLICE.Add(financeiroApolice);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
        }

        // PUT: api/FinanceiroApolice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FinanceiroApolice/5
        public void Delete(int id)
        {
        }
    }
}
