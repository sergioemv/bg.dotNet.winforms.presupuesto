using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using DataModel;
using DataModel.Entidades;
using WinPresupuesto.actions.categorias.dialogs;

namespace WinPresupuesto.actions.categorias
{
    class EditarCategoriaAction:DefaultAction
    {
        public EditarCategoriaAction()
        {
            name = "Editar Categoría";
        }

        public override void Hacer()
        {
            try
            {
                FCategoria catdialog = new FCategoria();
                Categoria categoria = Parameters[EActionsParameters.CATEGORIA] as Categoria;
             


                if (categoria == null) return;
                
                
                catdialog.txtNombre.Text = categoria.Name;
                catdialog.txtDescripcion.Text = categoria.Description;
                catdialog.ShowDialog();
                if (catdialog.DialogResult == DialogResult.OK)
                {
                    
                    if (categoria.Name != catdialog.txtNombre.Text)
                    {
                        
                        categoria.Name = catdialog.txtNombre.Text;
                    }
                    if (categoria.Description != catdialog.txtDescripcion.Text)
                    {
                        categoria.Description = catdialog.txtDescripcion.Text;
                    }
                }
            }
            catch (Exception e)
            {
                mensajes = "Ocurrio un error \n"+ e.Message;
            }
        }

      

        public override bool PuedeEjecutar()
        {
            return Parameters.ContainsKey(EActionsParameters.CATEGORIA) && Parameters[EActionsParameters.CATEGORIA]!=null
                   && Parameters.ContainsKey(EActionsParameters.CATEGORIAS) && Parameters[EActionsParameters.CATEGORIAS] != null;

        }
    }
}