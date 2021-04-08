using System.Collections.Generic;
using DataModel.DAO;
using DataModel.Entidades;
using NUnit.Framework;

namespace DataModel.Test
{
    [TestFixture] 
   public class PresupuestoDAOTest
    {
        private PresupuestoDAO dao;
        [SetUp]
        protected void setUp()
        {
            dao = new PresupuestoDAO();
        }


       [Test]
       public void getPresupuestos()
       {
           
           Presupuesto presupuesto = new Presupuesto("test 1");
           presupuesto.Description = "nada";
           
           dao.Adicionar(presupuesto);
           
           IList<Presupuesto> categorias = dao.getPresupuestos();
           Assert.IsNotNull(categorias);
           Assert.Greater(categorias.Count,0);
           Assert.AreEqual("nada", categorias[categorias.Count-1].Description);
           
       }
    }
}
