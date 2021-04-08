using System.Collections.Generic;
using DataModel.DAO;
using DataModel.Entidades;
using NUnit.Framework;

namespace DataModel.Test
{
    [TestFixture] 
   public class PeriodoDAOTest
    {
        private PeriodoDAO dao;
        [SetUp]
        protected void setUp()
        {
            dao = new PeriodoDAO();
        }


       [Test]
       public void getPeriodos()
       {
           
           Periodo per = new Periodo();
           per.Nombre = "Primer Trimestre";
           per.Tipo = "TRIMESTRE";
           per.Orden = 1;
           dao.Adicionar(per);

           IList<Periodo> periodos = dao.getPeriodos();
           Assert.IsNotNull(periodos);
           
           Assert.Greater(periodos.Count,0);
           
       }

       [Test]
       public void getTipoPeriodos()
       {

           Periodo per = new Periodo();
           per.Nombre = "Primer Trimestre";
           per.Tipo = "TRIMESTRE";
           per.Orden = 1;
           dao.Adicionar(per);

           IList<string> periodos = dao.getTiposPeriodo();
           Assert.IsNotNull(periodos);

           Assert.AreEqual(periodos.Count,2);

       }
    }
}
