using System;

namespace CapaServicios.Interfaces
{
    public interface IIdentificable<Tipo> where Tipo : struct, IComparable
    {
        Tipo DarOID();
    }
}