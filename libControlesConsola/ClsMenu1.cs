using CapaServicios.Consola;


namespace CapaServicios.ControlesConsola.Menu
{
    public class ClsMenu1 : ClsMenu
    {
        public ClsMenu1(string[] prmVectorOpciones) : base(prmVectorOpciones) { }
        protected override void Procesar(int prmOpcion)
        {
            switch (prmOpcion)
            {
                case 1: new ClsMenu1_1(new string[4] { "\tSubMenu 1_1", "Opción 1 ", "Opción 2", "Atrás" }); break;
                case 2: ClsConsola.EscribirSaltarLinea("Ha elegido la opción 2 del submenu"); break;
                case 3: ClsConsola.EscribirSaltarLinea("Ha elegido la opción ATRAS"); break;
                default: ClsConsola.EscribirSaltarLinea("Ha elegido una opción no válida"); break;
            }
        }
    }
}