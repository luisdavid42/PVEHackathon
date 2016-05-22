public class Usuario
{
	#region Atributos
	String cuenta;
	String contrasena;
	
	DatosPersona datosPersona;
	UsuarioEstudiante datosEstudiante;
	TipoUsuario tipoUsuario;
	#endregion


	#Constructores
	//uno con tipoUsuario;
	#endregion


	#Metodos
	#endregion


}

public class DatosEstudiante
{
	#region Atributos
	public String Carrera;

	#endregion


	#Constructores
	#endregion


	#Metodos
	#endregion
}

Enum TipoUsuario{
	UsuarioEstudiante,
	UsuarioAdmin
}

public class DatosPersona
{
	#region Atributos

	String nombres;
	String cedula;

	#endregion


	#Constructores
	#endregion


	#Metodos
	#endregion


}