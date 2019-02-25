using System;
using System.Collections.Generic;
using CapaServicios.Interfaces;

namespace CapaServicios.Cruds
{
    public static class ClsCruds
    {
        #region Atributos
        #endregion
        #region Métodos
        public static bool Asociar<Tipo>(Tipo prmItem, List<Tipo> prmColeccion) where Tipo : class
        {
            try
            {
                if (prmItem != null)
                {
                    prmColeccion.Add(prmItem);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        //implementar otro asociar
        public static bool Disociar<Tipo>(Tipo prmItem, List<Tipo> prmColeccion) where Tipo : class
        {
            try
            {
                if (prmItem != null)
                {
                    prmColeccion.Remove(prmItem);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static TipoColeccion DarItemCon<Tipo, TipoColeccion>(Tipo prmOID, List<TipoColeccion> prmColeccion)
            where Tipo : struct, IComparable
            where TipoColeccion : class, IIdentificable<Tipo>
        {
            foreach (TipoColeccion varItem in prmColeccion)
            {
                if (varItem.DarOID().CompareTo(prmOID) == 0)
                    return varItem;
            }
            return default(TipoColeccion);
        }
        #endregion
    }
}
