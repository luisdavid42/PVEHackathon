using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVEClLib
{
    /// <summary>
    /// Idea emprendedora de un estudiante.
    /// </summary>
    public class Idea
    {
        #region Atributos
        /// <summary>
        /// Resumen llamativo de la idea.
        /// </summary>
	    public String titulo;

        /// <summary>
        /// Estudiante autor de la Idea. Denotado por su matrícula.
        /// </summary>
        public String autor;

        /// <summary>
        /// Texto desarrollado(larguisimo) acerca de la problemática a trabajar.
        /// </summary>
        public String problema;

        /// <summary>
        /// Texto considerablemente aún más desarrollado de la solución al problema.
        /// </summary>
        public String solucion;

        /// <summary>
        /// Conjunto de los miembros del equipo. Denotado por la matrícula de cada estudiante.
        /// </summary>
        public HashSet<String> equipo;

        /// <summary>
        /// Conjunto de ofertas de apoyo que otros estudiantes envían al autor de la Idea. Denotado por la matrícula de cada estudiante.
        /// </summary>
        public HashSet<String> solicitudes;

        /// <summary>
        /// Conjunto de estudiantes que están de acuerdo con la Idea. Denotado por la matrícula de cada uno.
        /// </summary>
        public HashSet<String> likes;

        /// <summary>
        /// Lista de opiniones externalizadas por otros estudiantes respecto a la Idea.
        /// </summary>
        public List<String> comentarios;

        /// <summary>
        /// Imagen principal de la Idea.
        /// </summary>
        public String imagen;

        /// <summary>
        /// Indica si la imagen está seleccionada finalmente.
        /// </summary>
        public bool seleccionada;

	    #endregion


	    #region Constructores

        /// <summary>
        /// Inicializa una Idea vacía.
        /// </summary>
        public Idea()
        {
            
        }
	    #endregion


        #region Metodos

        /// <summary>
        /// Retorna la cantidad de Likes que ha obtenido la Idea durante el periodo establecido.
        /// </summary>
        /// <returns></returns>
        public int cantLikes()
        {
            return likes.Count;
        }

	    #endregion
    }
}
