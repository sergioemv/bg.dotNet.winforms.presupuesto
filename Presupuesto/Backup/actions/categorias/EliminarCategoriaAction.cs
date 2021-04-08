using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataModel.Entidades;

namespace WinPresupuesto.actions.categorias
{
    class EliminarCategoriaAction:DefaultAction
    {
        public EliminarCategoriaAction()
        {
            name = "Eliminar Categoría";
        }

        public override void Hacer()
        {
            try
            {
                Categoria categoria = Parameters[EActionsParameters.CATEGORIA] as Categoria;
                IList<Categoria> categoriaList = Parameters[EActionsParameters.CATEGORIAS] as IList<Categoria>;
                if (categoria == null || categoriaList==null) return;
                if (MessageBox.Show("Esta seguro de eliminar esta categoría?", name, MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) != DialogResult.Yes) return;
                categoriaList.Remove(categoria);
                if (categoria.Parent!=null)
                    categoria.Parent.removeCategoria(categoria);
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