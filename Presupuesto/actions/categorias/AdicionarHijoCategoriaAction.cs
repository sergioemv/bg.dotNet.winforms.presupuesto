using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataModel.Entidades;
using Presupuesto.actions.util;
using WinPresupuesto.actions.categorias.dialogs;

namespace WinPresupuesto.actions.categorias
{
    class AdicionarHijoCategoriaAction:DefaultAction
    {
        public AdicionarHijoCategoriaAction()
        {
            name = "Adicionar Categoría";
        }

        public override void Hacer()
        {
            try
            {
                Categoria categoria = Parameters[EActionsParameters.CATEGORIA] as Categoria;
                IList<Categoria> categorias = Parameters[EActionsParameters.CATEGORIAS] as IList<Categoria>;
                IdSet idset = Parameters[EActionsParameters.IDS] as IdSet;
                if (categorias == null || categoria == null || idset==null) return;
                
                
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
                    //adicionar la categoria hija
                    categorias.Add(newCategoria);
                    if (categoria.Children.Count > 1)
                    {
                        newCategoria.Orden = categoria.Children[0] + newCategoria.Id.ToString();
                    }

                    ((List<Categoria>) categorias).Sort();
                    categoria.addCategoria(newCategoria);
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
            return Parameters.ContainsKey(EActionsParameters.CATEGORIA) && Parameters[EActionsParameters.CATEGORIA] != null&&
                   Parameters.ContainsKey(EActionsParameters.CATEGORIAS) && Parameters[EActionsParameters.CATEGORIAS] != null&&
                   Parameters.ContainsKey(EActionsParameters.IDS) && Parameters[EActionsParameters.IDS] != null;

        }
    }
}