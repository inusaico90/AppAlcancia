using System;
using System.Collections.Generic;
using CapaServicios.Cruds;

namespace appAlcancia.CapaDominio
{
    public static class ClsControlador
    {
        #region Atributos
        private static List<ClsMoneda> atrMonedas = new List<ClsMoneda>();
        #endregion
        #region Métodos
        #region Accesores
        public static List<ClsMoneda> DarMonedas() { return atrMonedas; }
        #endregion
        #region CRUDs Query
        #region Asociadores
        public static bool AsociarMoneda(ClsMoneda prmObjeto)
        {
            return ClsCruds.Asociar(prmObjeto, atrMonedas);
        }
        #endregion
        #region Disociadores
        private static bool DisociarMoneda(ClsMoneda prmObjeto)
        {
            return ClsCruds.Disociar(prmObjeto, atrMonedas);
        }
        #endregion
        #region Búsqueda y recuperación
        private static ClsMoneda DarMonedaCon(int prmDenominacion)
        {
            return ClsCruds.DarItemCon(prmDenominacion, atrMonedas);
        }
        #endregion
        #region Registradores
        public static bool CrudRegistrarMoneda(int prmDenominacion)
        {
            ClsMoneda varObjMoneda = new ClsMoneda(prmDenominacion);
            if (ClsCruds.Asociar(varObjMoneda, atrMonedas))
                return true;
            return false;
        }
        #endregion
        #region Actualizadores
        public static bool CrudActualizarMoneda(int prmDenominacion, int prmNuevaDenominacion)
        {
            try
            {
                DarMonedaCon(prmDenominacion).PonerDenominacion(prmNuevaDenominacion);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        #region Eliminadores
        public static bool CrudEliminarMonedaCon(int prmDenominacion)
        {
            return DisociarMoneda(DarMonedaCon(prmDenominacion));
        }
        #endregion
        #endregion
        #endregion
    }
}