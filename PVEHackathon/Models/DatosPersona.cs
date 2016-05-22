using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVEHackathon.Models
{
    /// <summary>
    /// Datos personales de una Cuenta de Usuario.
    /// </summary>
    public class DatosPersona
    {
        #region Atributos

        /// <summary>
        /// Nombres y Apellidos de la Persona.
        /// </summary>
        public String nombres;

        /// <summary>
        /// Cedula de identidad de la persona(separada por '-')
        /// </summary>
        public String cedula;

        #endregion

        #region Constructores

        /// <summary>
        /// Inicializa los datos de una Persona vacía.
        /// </summary>
        public DatosPersona()
        {

        }

        /// <summary>
        /// Inicializa los datos de una Persona a partir de sus nombres y cédula.
        /// </summary>
        public DatosPersona(String nombres, String cedula)
        {
            this.nombres = nombres;
            this.cedula = cedula;
        }

        #endregion


        #region Metodos
        #endregion
    }
}