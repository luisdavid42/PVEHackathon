using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVEClLib
{
    /// <summary>
    /// Convocatoria a la publicacion de ideas.
    /// </summary>
    public class Evento
    {
        #region Atributos

        /// <summary>
        /// Nombre del Evento.
        /// </summary>
        public String nombre;

        /// <summary>
        /// Descripción del Evento.
        /// </summary>
        public String descripcion;

        /// <summary>
        /// Fecha en que inicia el Evento.
        /// </summary>
        public DateTime fechaInico;

        /// <summary>
        /// Fecha en que acaba el evento. Es el límite para los usuarios publicar y responder al contentenido.
        /// </summary>
        public DateTime fechaClausura;

        /// <summary>
        /// Lista de Ideas publicadas por los Estudiantes para este Evento específico.
        /// </summary>
        public List<Idea> ideas;

        /// <summary>
        /// Imagen principal del Evento.
        /// </summary>
        public String imagen;
        #endregion


        #region Constructores

        public Evento()
        {
            fechaInico = new DateTime();
            fechaClausura = new DateTime();
            ideas = new List<Idea>();
        }

        #endregion


        #region Metodos
        public List<Idea> getReporte()
        {
	        List<Idea> reporte = new List<Idea>();
            
            return reporte;
        }
        #endregion
    }
}
