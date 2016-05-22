using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVEHackathon.Models
{
    /// <summary>
    /// Datos estudiantiles de una Cuenta de Usuario.
    /// </summary>
    public class DatosEstudiante
    {
        #region Atributos
        /// <summary>
        /// Código de la carrera del Estudiante.
        /// </summary>
        public String carrera;

        /// <summary>
        /// Mensaje que notifica al estudiante de algo que le concierne.
        /// </summary>
        public List<String> notificaciones;

        /// <summary>
        /// Solicitud disyuntiva de un estudiante pidiendo apoyo a otro con algo.
        /// </summary>
        public List<String> solicitudes;
        #endregion


        #region Constructores

        /// <summary>
        /// Inicializa los Datos de un Estudiante vacío.
        /// </summary>
        public DatosEstudiante()
        {
            notificaciones = new List<String>();
            solicitudes = new List<String>();
        }

        /// <summary>
        /// Inicializa los Datos de un Estudiante a partir de su carrera.
        /// </summary>
        public DatosEstudiante(String carrera)
        {
            notificaciones = new List<String>();
            solicitudes = new List<String>();
            this.carrera = carrera;
        }
        #endregion


        #region Metodos

        /// <summary>
        /// Agrega una notificación a la lista del Estudiante.
        /// </summary>
        /// <param name="mensaje">El mensaje a presentar</param>
        public void AgregarNotificacion(String mensaje)
        {
            notificaciones.Add("mensaje");
        }

        /// <summary>
        /// Agrega una solicitud a la lista del Estudiante.
        /// </summary>
        /// <param name="mensaje">El mensaje a presentar</param>
        public void AgregarSolicitud(String mensaje)
        {
            solicitudes.Add("mensaje");
        }

        /// <summary>
        /// Elimina el mensaje de la lista.
        /// </summary>
        /// <param name="pos">Posición del mensaje en la lista.</param>
        public void EliminarNotificacion(int pos)
        {
            notificaciones.RemoveAt(pos);
        }

        /// <summary>
        /// Elimina el mensaje de la lista.
        /// </summary>
        /// <param name="pos">Posición del mensaje en la lista.</param>
        public void EliminarSolicitud(int pos)
        {
            solicitudes.RemoveAt(pos);
        }
        #endregion
    }
}