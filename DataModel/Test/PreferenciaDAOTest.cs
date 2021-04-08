using System.Collections.Generic;
using DataModel.DAO;
using DataModel.Entidades;
using NUnit.Framework;

namespace DataModel.Test
{
    [TestFixture] 
   public class PreferenciaDAOTest
    {
        private PreferenciaDAO dao;
        [SetUp]
        protected void setUp()
        {
            dao = new PreferenciaDAO();
        }


       [Test]
       public void getPreferencias()
       {
           
           Preferencia pref = new Preferencia("DEFAULT DATABASE","One DB");

           dao.Adicionar(pref);

           Dictionary<string,Preferencia> dict = dao.getPreferenciasDict();
           Assert.IsNotNull(dict);
           
           Assert.AreEqual("One DB",dict["DEFAULT DATABASE"].Value);
           
       }
    }
}
