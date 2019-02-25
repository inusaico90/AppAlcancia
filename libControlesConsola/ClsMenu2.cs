//Construcción lab 11/02/19
using System;
using CapaServicios.Consola;
using CapaServicios.Mensajeria.libMensajero;

namespace CapaServicios.ControlesConsola.Menu
{
    public class ClsMenu2
    {
        #region atributos
        private ClsConsola atrConsola;
        private string atrTitulo;
        private string[] atrVectorOpciones;
        private int atrOpcionElegida;
        private int atrNumeroOpcionSalir;
        #endregion
        #region Metodos
        protected string darNombreEntidad()
        {
            return "Menú";
        }
        private bool ImprimirMenu()
        {
            string varMetodoEnEjecucion;
            atrConsola.Limpiar();
            atrConsola.EscribirSaltarLinea("****" + atrTitulo + "****");
            try
            {
                for (int varIndice = 0; varIndice < atrNumeroOpcionSalir-1 ; varIndice++)
                {
                    ClsConsola.EscribirSaltarLinea(varIndice + 1 + "." + atrVectorOpciones[varIndice]);
                }
                ClsConsola.EscribirSaltarLinea(atrNumeroOpcionSalir + 1 + ".Salir");
                CapaServicios.Mensajeria.libMensajero.ClsMensajero.Mensajero(varMetodoEnEjecucion);
                return true;
            }
            catch (Exception)
            {
                //Mensajero(varMetodoEnEjecucion, Exception);
                return false;
            }
        }
        protected virtual void ProcesarOpcion(){}
        private bool IterarMenu()
        {
            string varMetodoEnEjecusion = "iterar menú";
            ClsConsola.Limpiar();
            do
            {
                if (ImprimirMenu())
                {
                    ClsConsola.Leer<int>("Ingrese una Opción del Menú: ", ref atrOpcionElegida);
                    if (!ClsConsola.EsperarTecla())
                    {
                        clsMensajero.Mensajero(false, varMetodoEnEjecusion, atrMensajeUltimoMetodo);
                        return false;
                    }
                    ProcesarOpcion();
                }
                else
                {
                    //Mensajero(false, varMetodoEnEjecusion, atrMensajeUltimoMetodo)
                    return false;
                }
            } while (atrOpcionElegida != atrNumeroOpcionSalir + 1);
            //Mensajero(varMetodoEnEjecusion);
            return true;
        }
        public ClsMenu2(string prmTitulo, string[] prmVectorOpciones)
        {
            string varMetodoEnEjecucion = "Crear nueva instancia de menú";
            bool varReportarExito = false;
            atrTitulo = prmTitulo;
            atrVectorOpciones = prmVectorOpciones;
            atrNumeroOpcionSalir = atrVectorOpciones.Length;
            atrConsola = CapaServicios.Consola.ClsConsola.DarConsola();
            if (IterarMenu())
            {
                varReportarExito = true;
            }
            Mensajero(varReportarExito, varMetodoEnEjecucion, atrMensajeUltimoMetodo);
        }
        #endregion
    }
}
