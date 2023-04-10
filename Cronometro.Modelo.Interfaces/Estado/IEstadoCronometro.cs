/*
 * Creado por SharpDevelop.
 * Usuario: hugoh
 * Fecha: 04/06/2023
 * Hora: 01:07
 * 
 */
using System;

namespace Cronometro.Modelo.Intefaces.Estado
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public interface IEstadoCronometro
	{				
		IEstadoCronometro Transicion(IDisparadorCronometro disparador);		
		bool PuedeHacerTransicion(IDisparadorCronometro disparador);				
	}
}
