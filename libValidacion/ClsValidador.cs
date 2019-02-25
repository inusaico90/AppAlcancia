using System;

namespace CapaServicios.Validacion
{ 
    public static class ClsValidador
    {
        public static bool EstaDatoEntre<Tipo>(string prmDato, Tipo prmTopeInferior, Tipo prmTopeSuperior) where Tipo : IComparable
        {
            try
            {
                Tipo varDato = (Tipo)Convert.ChangeType(prmDato, typeof(Tipo));
                bool varEsDatoMayorOIgualQueTopeInferior = varDato.CompareTo(prmTopeInferior) >= 0 || varDato.CompareTo(prmTopeInferior) == 1;
                bool varEsDatoMenorOIgualQueTopeSuperior = varDato.CompareTo(prmTopeSuperior) <= 0 || varDato.CompareTo(prmTopeSuperior) == -1;
                if (varEsDatoMayorOIgualQueTopeInferior && varEsDatoMenorOIgualQueTopeSuperior)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
