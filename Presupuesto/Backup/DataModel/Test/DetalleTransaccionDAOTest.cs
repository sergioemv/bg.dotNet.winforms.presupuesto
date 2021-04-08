using System.Collections.Generic;
using DataModel.DAO;
using DataModel.Entidades;
using NUnit.Framework;

namespace DataModel.Test
{
    [TestFixture] 
   public class DetalleTransaccionDAOTest
    {
        private DetalleTransaccionDAO dao;
        private TransaccionDAO daoPadre;
        private ProveedorDAO daoProveedor;
        private CategoriaDAO daoCategoria;
        [SetUp]
        protected void setUp()
        {
            dao = new DetalleTransaccionDAO();
            daoPadre = new TransaccionDAO();
            daoProveedor = new ProveedorDAO();
            daoCategoria = new CategoriaDAO();
        }


       [Test]
       public void getDetallesTransaccion()
       {
           
           Categoria cat = new Categoria("MARKETING OTROS");
           daoCategoria.Adicionar(cat);
           Proveedor prov = new Proveedor("PLASTICOS JUANCHO");
           daoProveedor.Adicionar(prov);
            Transaccion trn = new Transaccion(prov);
           //daoPadre.Adicionar(trn);
           DetalleTransaccion dtrn = new DetalleTransaccion(cat);
           dtrn.MontoFacturado = 1000;
           dtrn.MontoPagado = 500;
           trn.addDetalleTransaccion(dtrn);
           daoPadre.Adicionar(trn);

           IList<DetalleTransaccion> detalles = dao.getDetalleTransaccion(trn);
           Assert.IsNotNull(detalles);
           Assert.Greater(detalles.Count,0);
           Assert.AreEqual(1000, detalles[detalles.Count-1].MontoFacturado);
           
       }
    }
}
