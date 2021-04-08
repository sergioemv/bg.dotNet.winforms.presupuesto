using System.Collections.Generic;
using DataModel.DAO;
using DataModel.Entidades;
using NUnit.Framework;

namespace DataModel.Test
{
    [TestFixture] 
   public class TransaccionDAOTest
    {
        private TransaccionDAO dao;
        private ProveedorDAO daoProveedor;
        [SetUp]
        protected void setUp()
        {
            dao = new TransaccionDAO();
            daoProveedor = new ProveedorDAO();
        }


       [Test]
       public void getTransacciones()
       {
           Proveedor prv = new Proveedor("CRISS");
           daoProveedor.Adicionar(prv);
           Transaccion trn = new Transaccion(prv);
           trn.NroFactura = "152245";
           trn.Memo = "Nueva factura";
           
           dao.Adicionar(trn);
           
           IList<Transaccion> transacciones = dao.getTransacciones();
           Assert.IsNotNull(transacciones);
           Assert.Greater(transacciones.Count, 0);
           Assert.AreEqual("Nueva factura", transacciones[transacciones.Count - 1].Memo);
           
       }
    }
}
