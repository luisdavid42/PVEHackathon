using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVEHackathon.Models
{
    /// <summary>
    /// Convocatoria a la publicacion de ideas.
    /// </summary>
    public class Eventos
    {
        #region Atributos

        /// <summary>
        /// Nombre del Evento.
        /// </summary>
        public String nombre { get; set; }

        /// <summary>
        /// Descripción del Evento.
        /// </summary>
        public String descripcion { get; set; }

        /// <summary>
        /// Fecha en que inicia el Evento.
        /// </summary>
        public DateTime fechaInico { get; set; }

        /// <summary>
        /// Fecha en que acaba el evento. Es el límite para los usuarios publicar y responder al contentenido.
        /// </summary>
        public DateTime fechaClausura { get; set; }

        /// <summary>
        /// Lista de Ideas publicadas por los Estudiantes para este Evento específico.
        /// </summary>
        public List<Ideas> ideas { get; set; }

        /// <summary>
        /// Imagen principal del Evento.
        /// </summary>
        public String imagen { get; set; }
        #endregion


        #region Constructores

        public Eventos()
        {
            fechaInico = new DateTime();
            fechaClausura = new DateTime();
            ideas = new List<Ideas>();
        }

        #endregion


        #region Metodos
        public List<Ideas> getReporte()
        {
            List<Ideas> reporte = new List<Ideas>();
            reporte = ideas;

            reporte = reporte.OrderByDescending(x => x.likes.Count).ToList();

            return reporte;
        }
        #endregion
    }
}