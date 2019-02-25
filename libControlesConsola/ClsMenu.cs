using CapaServicios.Consola;

namespace CapaServicios.ControlesConsola.Menu
{
    public class ClsMenu
    {
        #region Atributos
        private int atrOpcionSalir;
        private string[] atrVectorOpciones;
        #endregion
        #region Métodos
        public ClsMenu(string[] prmVectorOpciones)
        {
            atrVectorOpciones = prmVectorOpciones;
            atrOpcionSalir = prmVectorOpciones.Length - 1;
            IterarMenu();
        }
        private void ImprimirMenu()
        {
            int varOpcion = 0;
            ClsConsola.Limpiar();
            ClsConsola.EscribirSaltarLinea("\n" + atrVectorOpciones[varOpcion]);
            for (varOpcion = 1; varOpcion < atrVectorOpciones.Length - 1; varOpcion++)
                ClsConsola.EscribirSaltarLinea(varOpcion + ". " + atrVectorOpciones[varOpcion]);
            ClsConsola.EscribirSaltarLinea(varOpcion + ". " + atrVectorOpciones[atrVectorOpciones.Length - 1]);
        }
        private void IterarMenu()
        {
            int varOpcion = 0;
            do
            {
                ImprimirMenu();
                ClsConsola.Leer("Seleccione una opción: ", ref varOpcion);
                ClsConsola.EscribirSaltarLinea("__________________________\n");
                Procesar(varOpcion);
                ClsConsola.EsperarTecla();
            } while (varOpcion != atrOpcionSalir);
        }
        protected virtual void Procesar(int prmOpcion) { }
        #endregion
    }
}