namespace WinPresupuesto.actions
{
    interface IAction
    {
        void Ejecutar();
        bool PuedeEjecutar();
        string ObtenerMensajes();
    }
}