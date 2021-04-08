using System.Collections;
using System.Collections.Generic;
using DataModel.DAO;
using DataModel.Entidades;
using NHibernate;
using NUnit.Framework;

namespace DataModel.Test
{
    [TestFixture] 
   public class CategoriaDAOTest
    {
        private CategoriaDAO dao;
        [SetUp]
        protected void setUp()
        {
            dao = new CategoriaDAO();
        }


       [Test]
       public void getCategorias()
       {
           
           Categoria categoria = new Categoria("padre");
           categoria.Description = "nada";
           Categoria categoria2 = new Categoria("hijo1");
           categoria2.Description = "testing";

           categoria.addCategoria(categoria2);
           categoria.addCategoria(new Categoria("hijo2"));
           categoria.addCategoria(new Categoria("hijo3"));
           dao.Adicionar(categoria);
           
           IList<Categoria> categorias = dao.getCategorias();
           Assert.IsNotNull(categorias);
           Assert.Greater(categorias.Count,0);
           
       }
    }
}
