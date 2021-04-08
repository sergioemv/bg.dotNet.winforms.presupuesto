using System;
using System.Collections.Generic;
using System.Text;
using DataModel.Entidades;

namespace DataModel.Entidades
{
    public interface CategoriasBean
    {
        void addCategoria(Categoria categoria);

        IList<Categoria> getCategorias();

        void removeCategoria(Categoria categoria);
    }
}
