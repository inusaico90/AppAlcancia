using System;
using CapaServicios.Interfaces;

namespace appAlcancia.CapaDominio
{
    public class ClsMoneda : IComparable, IIdentificable<int> //Porque hay más de una moneda se restringue con IComparable e IIdentificable
    {
        #region Atributos
        private int AtrDenominacion;
        #endregion
        #region Métodos
        #region Constructores
        public ClsMoneda(int prmDenominacion)
        {
            AtrDenominacion = prmDenominacion;
        }
        #endregion
        #region Accesores
        public int DarOID() { return AtrDenominacion; }
        public int DarDenominacion() { return AtrDenominacion; }
        #endregion
        #region Mutadores
        public void PonerDenominacion(int prmValor) { AtrDenominacion = prmValor; }
        #endregion 
        #region Comparadores
        public int CompareTo(object prmObjMoneda) { return 0; }
        #endregion
        #endregion
    }
}