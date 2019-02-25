using CapaServicios.ControlesConsola.Menu;

namespace appAlcancia.CapaPresentacion.Consola
{
    class Principal
    {
        static void Main(string[] args){
            string[] varVectorOpciones = new string[6]
            {"Menú","\tRegistrar moneda","\tEliminar moneda","\tImprimir lista de monedas","\tPrueba sub-menú","\tSalir"};
            new ClsMenuPrincipal(varVectorOpciones);
        }
    }
}