using CapaServicios.Consola;
using appAlcancia.CapaDominio;

namespace CapaServicios.ControlesConsola.Menu
{
    public class ClsMenuPrincipal : ClsMenu
    {
        public ClsMenuPrincipal(string[] prmVectorOpciones) : base(prmVectorOpciones) { }
        protected override void Procesar(int prmOpcion)
        {
            int varDenominacion = 0;
            bool varEsValidoDato = false;
            switch (prmOpcion)
            {
                case 1:
                    {
                        do
                        {
                            ClsConsola.Leer<int>("Ingrese la nueva denominación: ", ref varDenominacion, 50, 200);
                            if (ClsControlador.CrudRegistrarMoneda(varDenominacion))
                            {
                                ClsConsola.EscribirSaltarLinea("Se ha registrado la nueva moneda con éxito. ");
                                varEsValidoDato = true;
                            }
                        } while (varEsValidoDato == false);
                        break;
                    }
                case 2:
                    {
                        ClsConsola.Leer("Escriba la denominación de moneda que desea eliminar: ", ref varDenominacion, 50, 200);
                        if (ClsControlador.CrudEliminarMonedaCon(varDenominacion))
                            ClsConsola.EscribirSaltarLinea("Se ha Eliminado una moneda con éxito. ");
                        else
                            ClsConsola.EscribirSaltarLinea("No fue posible eliminar la moneda. ");
                        break;
                    }
                case 3:
                    {
                        ClsConsola.EscribirColeccion(varDenominacion, ClsControlador.DarMonedas());
                        break;
                    }
                case 4:
                    {
                        new ClsMenu1(new string[4] { "\tSub-Menu", "Opción uno", "Opción dos", "Regresar" }); break;
                    }
                case 5:
                    {
                        ClsConsola.EscribirSaltarLinea("Ha elegido la opción salir"); break;
                    }
                default:
                    {
                        ClsConsola.EscribirSaltarLinea("Ha elegido una opción no válida"); break;
                    }
            }
        }
    }
}