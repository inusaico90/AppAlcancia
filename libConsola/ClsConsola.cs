using System;
using CapaServicios.Validacion;
using System.Collections.Generic;
using CapaServicios.Interfaces;

namespace CapaServicios.Consola
{
    public class ClsConsola
    {
        #region Atributos
        private static ClsConsola AtrConsola;
        #endregion
        #region Métodos
        #region Accesores
        public static ClsConsola DarConsola()
        {
            if (AtrConsola == null)
            {
                AtrConsola = new ClsConsola();
            }
            return AtrConsola;
        }
        #endregion
        #region Entrada
        public static string LeerLinea()
        {
            return Console.ReadLine();
        }
        public static void Leer<Tipo>(string prmEtiqueta, ref Tipo prmDato)
        {
            bool varEsValidoDato = false;
            do
            {
                try
                {
                    Escribir(prmEtiqueta);
                    prmDato = (Tipo)Convert.ChangeType(LeerLinea(), typeof(Tipo));
                    varEsValidoDato = true;
                }
                catch (Exception e)
                {
                    Escribir("ERROR: " + e.Message + "\nReintente con un valor " + typeof(Tipo).ToString() + "\n\n");
                }
            } while (varEsValidoDato == false);
        }
        public static void Leer<Tipo>(string prmEtiqueta, ref Tipo prmDato, Tipo prmTopeInferior, Tipo prmTopeSuperior)
            where Tipo : struct, IComparable
        {
            bool varEsValidoDato = false;
            string varDato = "";
            do
            {
                Leer<string>(prmEtiqueta, ref varDato);
                if (ClsValidador.EstaDatoEntre<Tipo>(varDato, prmTopeInferior, prmTopeSuperior))
                {
                    prmDato = (Tipo)Convert.ChangeType(varDato, typeof(Tipo));
                    varEsValidoDato = true;
                }
                else
                    Escribir("Ingrese un valor entre: " + prmTopeInferior + " y " + prmTopeSuperior + "\n\n");

            } while (varEsValidoDato == false);
        }
        #endregion
        #region Salida
        /// <summary>
        /// Limpia o bora el contenido de la consola.
        /// </summary>
        /// <returns></returns>
        public static bool Limpiar()
        {
            try
            {
                Console.Clear();
                return true;
            }
            catch (Exception)
            {
                return false;
            };
        }

        /// <summary>
        /// Escribe (Sin saltar línea) en la consola el contenido de "prmDato".
        /// </summary>
        /// <returns></returns>
        public static bool Escribir<Type>(Type prmDato)
        {
            try
            {
                Console.Write(prmDato);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Está escribiendo un dato inválido. ");
                return false;
            };
        }

        /// <summary>
        /// Escribe (Sin saltar línea) en la consola el contenido de "prmDato", acompañado de una etiqueta.
        /// </summary>
        /// <returns></returns>
        public static bool Escribir<Type>(string prmEtiqueta, Type prmDato)
        {
            try
            {
                Console.Write(prmEtiqueta, prmDato);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Está escribiendo un dato invalido. ");
                return false;
            };
        }

        /// <summary>
        /// Salta a la próxima línea sin escribir nada.
        /// </summary>
        /// <returns></returns>
        public static bool EscribirSaltarLinea()
        {
            try
            {
                Console.WriteLine();
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine();
                return false;
            };
        }

        /// <summary>
        /// Escribe en la consola el contenido de "prmDato" luego salta de línea.
        /// </summary>
        /// <returns></returns>
        public static bool EscribirSaltarLinea<Type>(Type prmDato)
        {
            try
            {
                Console.WriteLine(prmDato);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Está escribiendo un dato invalido. ");
                return false;
            };
        }

        /// <summary>
        /// Escribe en la consola el contenido de "prmDato" acompañado de una etiqueta y luego salta de línea.
        /// </summary>
        /// <returns></returns>
        public static bool EscribirSaltarLinea<Type>(string prmEtiqueta, Type prmDato)
        {
            try
            {
                Console.WriteLine(prmEtiqueta, prmDato);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Está escribiendo un dato invalido. ");
                return false;
            };
        }

        /// <summary>
        /// Escribe en la consola el contenido de un vector.
        /// </summary>
        /// <returns></returns>
        public static bool EscribirVector<Type>(string prmEtiqueta, Type[] prmVector)
        {
            try
            {
                Console.WriteLine(prmEtiqueta);
                for (int varIterador = 0; varIterador < prmVector.Length; varIterador++)
                {
                    Console.WriteLine(prmVector[varIterador]);
                }

                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un error inesperado. ");
                return false;
            };
        }

        /// <summary>
        /// Escribe en la consola el contenido de un vector, hata el tope de ítems indicado.
        /// </summary>
        /// <returns></returns>
        public static bool EscribirVector<Type>(string prmEtiqueta, Type[] prmVector, int prmTopeItems)
        {
            try
            {
                Console.WriteLine(prmEtiqueta);
                for (int varIterador = 0; varIterador < prmTopeItems; varIterador++)
                {
                    Console.WriteLine(prmVector[varIterador]);
                }
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un error inesperado. ");
                return false;
            };
        }

        /// <summary>
        /// Escribe en la consola el contenido de un vector bi-dimencional, agregando una etiqueta. 
        /// </summary>
        /// <returns></returns>
        public static bool EscribirMatriz<Type>(string prmEtiqueta, Type[,] prmMatriz)
        {
            try
            {
                Console.WriteLine(prmEtiqueta);
                for (int varIteradorColumna = 0; varIteradorColumna < prmMatriz.GetLength(1); varIteradorColumna++)
                {
                    for (int varIteradorFila = 0; varIteradorFila < prmMatriz.GetLength(0); varIteradorFila++)
                    {
                        Console.WriteLine(prmMatriz[varIteradorFila, varIteradorColumna]);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un error inesperado. ");
                return false;
            };
        }

        /// <summary>
        /// Escribe en la consola el contenido de un vector bi-dimencional, agregando un encabezado para cada columna.
        /// <returns></returns>
        public static bool EscribirMatriz<Type>(string[] prmVectorEncabezados, Type[,] prmMatriz, bool prmAlinearDerecha)
        {
            try
            {
                if (prmAlinearDerecha)
                {
                    for (int varIteradorColumna = 0; varIteradorColumna < prmMatriz.GetLength(1); varIteradorColumna++)
                    {
                        Console.WriteLine(prmVectorEncabezados[varIteradorColumna]);
                        for (int varIteradorFila = 0; varIteradorFila < prmMatriz.GetLength(0); varIteradorFila++)
                        {
                            Console.WriteLine("\t" + prmMatriz[varIteradorFila, varIteradorColumna]);
                        }
                    }
                }
                else
                {
                    for (int varIteradorColumna = 0; varIteradorColumna < prmMatriz.GetLength(1); varIteradorColumna++)
                    {
                        for (int varIteradorFila = 0; varIteradorFila < prmMatriz.GetLength(0); varIteradorFila++)
                        {
                            Console.WriteLine(prmMatriz[varIteradorFila, varIteradorColumna]);
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un error inesperado. ");
                return false;
            };
        }

        /// <summary>
        /// Escribe en la consola el contenido de una coleccion.
        /// <returns></returns>
        public static bool EscribirColeccion<TIdentificable, TColeccion> (TIdentificable prmTipo, List<TColeccion> prmColeccion)
            where TColeccion : IIdentificable<TIdentificable>
            where TIdentificable : struct, IComparable
        {
            try
            {
                int varContador = 1;
                foreach (TColeccion varItem in prmColeccion)
                {
                    Escribir(varContador + ". ");
                    EscribirSaltarLinea(varItem.DarOID());
                    varContador++;
                }
                return true;
            }
            catch (Exception)
            {
                EscribirSaltarLinea("Hubo un error inesperado. ");
                return false;
            }
        }
        #endregion
        #region Métodos de control
        /// <summary>
        /// Espera a que se presione una tecla (mostrando un mensaje) antes de continuar.
        /// </summary>
        /// <returns></returns>
        public static bool EsperarTecla()
        {
            try
            {
                Escribir("Presione una tecla para continuar...");
                Console.ReadKey();
                Escribir("\n\n");
                return true;
            }
            catch (Exception)
            {
                return false;
            };
        }
        #endregion
        #endregion
    }
}