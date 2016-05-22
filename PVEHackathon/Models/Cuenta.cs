using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVEHackathon.Models
{
    /// <summary>
    /// Datos generales de una Cuenta de Usuario.
    /// </summary>
    public class Cuenta
    {
        #region Atributos
        /// <summary>
        /// Nombre de Usuario para autenticarse en el sistema.
        /// </summary>
	    public String nombreUsuario;

        /// <summary>
        /// Clave para autenticarse en el sistema.
        /// </summary>
        public String contrasena;

        /// <summary>
        /// Almacena los datos personales de la cuenta.
        /// </summary>
        public DatosPersona datosPersona;

        /// <summary>
        /// Almacena los datos estudiantiles de la cuenta.
        /// </summary>
        public DatosEstudiante datosEstudiante;

        /// <summary>
        /// Indica si la cuenta es o no estudiante. No serlo implica que la cuenta es admin.
        /// </summary>
        public bool esEstudiante;

        /// <summary>
        /// Imagen principal de la Cuenta.
        /// </summary>
        public String imagen;
        #endregion


        #region Constructores
        /// <summary>
        /// Inicializa una Cuenta Vacia.
        /// </summary>
        public Cuenta()
        {
            datosPersona = new DatosPersona();
        }

        /// <summary>
        /// Inicializa una cuenta a partir de su rol de estudiante.
        /// </summary>
        /// <param name="esEstudiante"></param>
        public Cuenta(bool esEstudiante)
        {
            datosPersona = new DatosPersona();
            this.esEstudiante = esEstudiante;
        }

        #endregion


        #region Metodos

        #endregion
    }
}