using System.Collections.Generic;
using DataModel.DAO;
using DataModel.Entidades;
using NUnit.Framework;

namespace DataModel.Test
{
    [TestFixture] 
   public class ProveedorDAOTest
    {
        private ProveedorDAO dao;
        [SetUp]
        protected void setUp()
        {
            dao = new ProveedorDAO();
        }


       [Test]
       public void getProveedores()
       {
           
           
           dao.Adicionar(new Proveedor("Uno"));
           dao.Adicionar(new Proveedor("Dos"));
           dao.Adicionar(new Proveedor("Tres"));
           dao.Adicionar(new Proveedor("Cuatro"));

           IList<Proveedor> proveedores = dao.getProveedores();
           Assert.IsNotNull(proveedores);
           
           Assert.Greater(proveedores.Count,3);
           
       }
    }
}
