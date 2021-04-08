using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataModel.Entidades;
using Presupuesto.actions.util;
using WinPresupuesto.actions.categorias.dialogs;

namespace WinPresupuesto.actions.categorias
{
    class AdicionarAlLadoCategoriaAction:DefaultAction
    {
        public AdicionarAlLadoCategoriaAction()
        {
            name = "Adicionar Categoría";
        }

        public override void Hacer()
        {
            try
            {
                Categoria categoria = null;
                if (Parameters.ContainsKey(EActionsParameters.CATEGORIA))
                    categoria = Parameters[EActionsParameters.CATEGORIA] as Categoria;
                IList<Categoria> categorias = Parameters[EActionsParameters.CATEGORIAS] as IList<Categoria>;
                IdSet idset = Parameters[EActionsParameters.IDS] as IdSet;
                if (categorias == null || idset ==null) return;
                
                
                FCategoria catdialog = new FCategoria();
                catdialog.Text = this.name;

                Categoria newCategoria = new Categoria();
                newCategoria.Id = idset.getNextValidId();
                catdialog.ShowDialog();
                if (catdialog.DialogResult == DialogResult.OK)
                {
                    idset.registerId(newCategoria.Id);
                    if (newCategoria.Name != catdialog.txtNombre.Text)
                    {
                        newCategoria.Name = catdialog.txtNombre.Text;
                    }
                    if (newCategoria.Description != catdialog.txtDescripcion.Text)
                    {
                        newCategoria.Description = catdialog.txtDescripcion.Text;
                    }
                    //adicionar la categoria al lado
                    categorias.Add(newCategoria);
                    if (categoria != null)
                    {
                        newCategoria.Orden = categoria.Orden+newCategoria.Id.ToString();
                        newCategoria.setTipoCategoria(categoria.getTipoCategoria());
                    }
                    if (Parameters.ContainsKey(EActionsParameters.TIPO_CATEGORIA))
                        newCategoria.setTipoCategoria((ETipoCategoria) Parameters[EActionsParameters.TIPO_CATEGORIA]);
                    ((List<Categoria>) categorias).Sort();

                    if (categoria != null)
                        if (categoria.Parent != null)
                            categoria.Parent.addCategoria(newCategoria);
                    //publicar la nueva categoria 
                    Parameters.Add(EActionsParameters.NUEVA_CATEGORIA,newCategoria);
                }
            }
            catch (Exception e)
            {
                mensajes = "Ocurrio un error \n"+ e.Message;
            }
        }

      

        public override bool PuedeEjecutar()
        {
            return Parameters.ContainsKey(EActionsParameters.CATEGORIAS) && Parameters[EActionsParameters.CATEGORIAS] != null &&
                   Parameters.ContainsKey(EActionsParameters.IDS) && Parameters[EActionsParameters.IDS] != null;
        }
    }
}