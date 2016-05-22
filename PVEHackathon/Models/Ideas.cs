using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVEHackathon.Models
{
    public class Ideas
    {
        /// <summary>
        /// Resumen llamativo de la idea.
        /// </summary>  
        public String titulo { get; set; }

        /// <summary>
        /// Estudiante autor de la Idea. Denotado por su matrícula.
        /// </summary>
        public String autor { get; set; }

        /// <summary>
        /// Texto desarrollado(larguisimo) acerca de la problemática a trabajar.
        /// </summary>
        public String problema { get; set; }

        /// <summary>
        /// Texto considerablemente aún más desarrollado de la solución al problema.
        /// </summary>
        public String solucion { get; set; }

        /// <summary>
        /// Conjunto de los miembros del equipo. Denotado por la matrícula de cada estudiante.
        /// </summary>
        public HashSet<String> equipo { get; set; }

        /// <summary>
        /// Conjunto de ofertas de apoyo que otros estudiantes envían al autor de la Idea. Denotado por la matrícula de cada estudiante.
        /// </summary>
        public HashSet<String> solicitudes { get; set; }

        /// <summary>
        /// Conjunto de estudiantes que están de acuerdo con la Idea. Denotado por la matrícula de cada uno.
        /// </summary>
        public HashSet<String> likes { get; set; }

        /// <summary>
        /// Lista de opiniones externalizadas por otros estudiantes respecto a la Idea.
        /// </summary>
        public List<String> comentarios { get; set; }

        /// <summary>
        /// Imagen principal de la Idea.
        /// </summary>
        public String imagen { get; set; }

        /// <summary>
        /// Indica si la idea fue seleccionada finalmente.
        /// </summary>
        public bool fueSeleccionada;

        /// <summary>
        /// Inicializa una Idea vacía.
        /// </summary>
        public Ideas()
        {
            equipo = new HashSet<String>();
            solicitudes = new HashSet<String>();
            likes = new HashSet<String>();
            comentarios = new List<String>();
            fueSeleccionada = false;
            
        }

        /// <summary>
        /// Retorna la cantidad de Likes que ha obtenido la Idea durante el periodo establecido.
        /// </summary>
        /// <returns></returns>
        public int cantLikes()
        {
            return likes.Count;
        }

        /// <summary>
        /// Marca la Idea como Seleccionada de forma final.
        /// </summary>
        public void seleccionar()
        {
            fueSeleccionada = true;
        }
        
        /// <summary>
        /// Agrega un like a la idea.
        /// </summary>
        /// <param name="estudiante">Matricula del estudiante que "likeó" la idea.</param>
        public void agregarLike(String estudiante)
        {
            likes.Add(estudiante);
        }

    }
}