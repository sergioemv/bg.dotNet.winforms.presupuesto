using System.Collections;
using System.Collections.Generic;
using DataModel.Entidades;
using NHibernate;
using NUnit.Framework;

namespace DataModel.Test
{
    [TestFixture] 
   public class PresupuestoModelFacadeTest
    {
        private PresupuestoModelFacade facade;
        [SetUp]
        protected void setUp()
        {
            facade = new PresupuestoModelFacade();
        }


       [Test]
       public void getCategorias()
       {
           ISession session = facade.SF.OpenSession();
           Categoria categoria = new Categoria("padre");
           categoria.Description = "nada";
           Categoria categoria2 = new Categoria("hijo1");
           categoria2.Description = "testing";

           categoria.addCategoria(categoria2);
           categoria.addCategoria(new Categoria("hijo2"));
           categoria.addCategoria(new Categoria("hijo3"));
           session.Save(categoria);
           session.Flush();
           IList<Categoria> categorias = facade.getCategorias();
           Assert.IsNotNull(categorias);
           Assert.Greater(categorias.Count,0);
           session.Close();
       }
    }
}
