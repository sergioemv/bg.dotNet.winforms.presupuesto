using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using DataModel;
using DataModel.DAO;
using DataModel.Entidades;
using Presupuesto.actions.util;
using WinPresupuesto.actions.categorias.dialogs;

namespace WinPresupuesto.actions.categorias
{
    class GestionarCategoriasAction:DefaultAction
    {
        private IdSet idSet;
        private IList categoriasCambiadas;
        public GestionarCategoriasAction()
        {
            name = "Gestionar Categorías";
            idSet = new IdSet();
        }

        public override void Hacer()
        {
            try
            {
                FCategorias cat = new FCategorias();
                cat.categoriasTree.Nodes.Clear();
                CategoriaDAO dao = new CategoriaDAO();
                IList<Categoria> categorias;
                categorias = dao.getCategorias();
                
                if (categorias==null) return;
                List<Categoria> categoriasClone = new List<Categoria>();
                categoriasClone.AddRange(categorias);
                idSet.clear();
                foreach (Categoria categoria in categorias)
                {
                    categoria.Changed += new ChangedEventHandler(CambioCategoria);
                    idSet.registerId(categoria.Id);
                }
                cat.pIdSet = idSet;
                cat.Categorias = categorias;
                cat.fillTree();
                cat.categoriasTree.ExpandAll();
                cat.ShowDialog();
                if (cat.DialogResult == DialogResult.OK)
                {
                    foreach (Categoria categoria in categoriasClone)
                    {
                        if (!categorias.Contains(categoria))
                            dao.Eliminar(categoria);
                    }
                    foreach (Categoria categoria in categorias)
                    {
                        if (!categoriasClone.Contains(categoria))
                            dao.Adicionar(categoria);
                    }
                    if (categoriasCambiadas != null)
                        foreach (Categoria categoria in categoriasCambiadas)
                        {
                            if (categoriasClone.Contains(categoria)&&(categorias.Contains(categoria)))
                                dao.Actualizar(categoria);
                        }

                   
                    //guardar las nuevas categorias
                 
                }
            }
            catch (Exception e)
            {
                mensajes = "No se pudieron editar las categorías \n"+ e.Message;
            }
        }

        private void CambioCategoria(object sender, EventArgs e)
        {
            if (categoriasCambiadas == null)
                categoriasCambiadas = new ArrayList();
            categoriasCambiadas.Add(sender);
        }


        public override bool PuedeEjecutar()
        {
            return true;
        }
    }
}