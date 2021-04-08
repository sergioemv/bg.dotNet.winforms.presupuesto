using System;
using WinPresupuesto.actions;
using WinPresupuesto.actions.categorias;
using WinPresupuesto.actions.presupuesto;

namespace WinPresupuesto.actions
{
    enum EActions
    {
        GESTIONAR_CATEGORIAS,
        EDITAR_CATEGORIA,
        ADICIONAR_CATEGORIA_AL_LADO,
        ADICIONAR_CATEGORIA_HIJA,
        ELIMINAR_CATEGORIA,
        GESTIONAR_PRESUPUESTOS,
        ADICIONAR_PRESUPUESTO
    }

    enum EActionsParameters
    {
        CATEGORIA,
        NUEVA_CATEGORIA,
        GUARDAR_EN_DB,
        CATEGORIAS,
        IDS,
        TIPO_CATEGORIA,
        CONTAINER
    }

    class Actions
    {
        public static Actions INSTANCE = new Actions();

        public IAction getAction(EActions action)
        {
            
            switch (action)
            {
                case EActions.GESTIONAR_CATEGORIAS:
                    return new GestionarCategoriasAction();
                case EActions.EDITAR_CATEGORIA:
                    return new EditarCategoriaAction();
                case EActions.ADICIONAR_CATEGORIA_AL_LADO:
                    return new AdicionarAlLadoCategoriaAction();
                case EActions.ADICIONAR_CATEGORIA_HIJA:
                    return new AdicionarHijoCategoriaAction();
                case EActions.ELIMINAR_CATEGORIA:
                    return new EliminarCategoriaAction();
                case EActions.GESTIONAR_PRESUPUESTOS:
                    return new GestionarPresupuestosAction();
                case EActions.ADICIONAR_PRESUPUESTO:
                    return new AdicionarPresupuestosAction();
                default:
                    throw new ArgumentOutOfRangeException("action");
            }
        }
    }


}