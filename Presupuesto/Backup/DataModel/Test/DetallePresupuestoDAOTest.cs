using System.Collections.Generic;
using DataModel.DAO;
using DataModel.Entidades;
using NUnit.Framework;

namespace DataModel.Test
{
    [TestFixture] 
   public class DetallePresupuestoDAOTest
    {
        private DetallePresupuestoDAO dao;
        private PresupuestoDAO daoPadre;
        private PeriodoDAO daoPeriodo;
        private CategoriaDAO daoCategoria;
        [SetUp]
        protected void setUp()
        {
            dao = new DetallePresupuestoDAO();
            daoPadre = new PresupuestoDAO();
            daoPeriodo = new PeriodoDAO();
            daoCategoria = new CategoriaDAO();
        }


       [Test]
       public void getDetallesPresupuesto()
       {
           
           Periodo per = new Periodo();
           per.Nombre = "Tercer Trimestre";
           per.Tipo = "TRIMESTRE";
           daoPeriodo.Adicionar(per);
           Categoria cat = new Categoria("INCOMODIDADES");
           daoCategoria.Adicionar(cat);
            Presupuesto presupuesto = new Presupuesto("test 1");
           presupuesto.Description = "nada";
           DetallePresupuesto detalle = new DetallePresupuesto();
           daoPadre.Adicionar(presupuesto);

           detalle.pCategoria = cat;
           detalle.pPeriodo = per;
           detalle.Valor = 6000;
           presupuesto.addDetallePresupuesto(detalle);

           dao.Adicionar(detalle);
         
           
           IList<DetallePresupuesto> detalles =  dao.getDetallePresupuesto(presupuesto);

           Assert.IsNotNull(detalles);
           Assert.Greater(detalles.Count,0);
           Assert.AreEqual(6000, detalles[detalles.Count-1].Valor);
           
       }
    }
}
