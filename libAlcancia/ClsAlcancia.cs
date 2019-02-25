using System.Collections.Generic;

namespace appAlcancia.CapaDominio
{
    class ClsAlcancia
    {
        #region atributos
        #region Construcción
        private List<ClsMoneda> clsMonedas = new List<ClsMoneda>();
        private int atrCapacidadMinima = 1;
        private int atrCapacidadMaxima = int.MaxValue;
        private int atrSaldoTotal=-1;
        #endregion
        #region Transacciones
        private int atrCapacidadMonedas = -1;
        private int atrCantidadMonedas = -1;
        private List<int> atrSaldoPorDenominacion = new List<int>();
        private List<int> atrMonedasPorDenominacion = new List<int>();
        #endregion
        #region configuración
        private List<int> atrDenominacionPermitida = new List<int>();
        #endregion
        #endregion
        #region Metodos
        #region constructores
        public ClsAlcancia(){}
        public ClsAlcancia(int prmCapacidadMonedas)
        {
            if ((atrCapacidadMinima <= prmCapacidadMonedas) && (atrCapacidadMaxima >= prmCapacidadMonedas))
                atrCantidadMonedas = prmCapacidadMonedas;
            else
                atrCapacidadMonedas = atrCapacidadMinima;
        }
        #endregion
        #region 
        public void Consignar(ClsMoneda prmObjMoneda)
        {

        }
        public void retirar(int prmdenominacion)
        {

        }
        #endregion
        #endregion
    }
}
