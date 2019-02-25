
namespace CapaServicios.Mensajeria.libMensajero
{
    public class ClsMensajero
    {
        #region Atributos
        protected string AtrMensajeUltimoMetodo;
        #endregion
        #region Metodos
        protected virtual string DarNombreEntidad()
        {
            return null;
        }
        public string DarMensajeUltimoMetodo()
        {
            return AtrMensajeUltimoMetodo;
        }
        public void PonerMensajeUltimoMetodo(string prmMensaje)
        {
            AtrMensajeUltimoMetodo = prmMensaje;
        }
        void Mensajero(string prmMetodoEnEjecucion)
        {
            AtrMensajeUltimoMetodo = "\n" + "-El método <" + prmMetodoEnEjecucion + "> de <" + DarNombreEntidad() + "> ha finalizado correctamente. \n";
        }
        void Mensajero(string prmMetodoEnEjecucion, string prmDescripcion)
        {
            AtrMensajeUltimoMetodo = "\n" + "-El método <" + prmMetodoEnEjecucion + "> de <" + DarNombreEntidad() + "> ha tenido el siguiente problema: " + prmDescripcion + "\n";
        }
        void Mensajero(bool prmReportarExito, string prmMetodoEnEjecucion, string prmDescripcion)
        {
            if (prmReportarExito)
            {
                AtrMensajeUltimoMetodo = "\n" + "-El método <" + prmMetodoEnEjecucion + "> de <" + DarNombreEntidad() + "> ha finalizado correctamente." + prmDescripcion + "\n";
            }
            else
            {
                AtrMensajeUltimoMetodo = "\n" + "-El método <" + prmMetodoEnEjecucion + "> de <" + DarNombreEntidad() + "> ha tenido el siguiente problema: " + prmDescripcion + "\n";
            }
        }
        #endregion
    }
}
