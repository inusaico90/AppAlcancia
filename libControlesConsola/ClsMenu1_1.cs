using CapaServicios.Consola;

namespace CapaServicios.ControlesConsola.Menu
{
    class ClsMenu1_1 : ClsMenu
    {
        public ClsMenu1_1(string[] prmVectorOpciones) : base(prmVectorOpciones) { }
        protected override void Procesar(int prmOpcion)
        {
            switch (prmOpcion)
            {
                case 1: ClsConsola.EscribirSaltarLinea("Escogió la opción 1 del sub-menu 1_1"); break;
                case 2: ClsConsola.EscribirSaltarLinea("Escogió la opción 2 del sub-menu 1_1"); break;
                case 3: ClsConsola.EscribirSaltarLinea("Escogió la opción salir sub-menu 1_1"); break;
                default: ClsConsola.EscribirSaltarLinea("Escogió una opción no válida."); break;
            }
        }
    }
}
