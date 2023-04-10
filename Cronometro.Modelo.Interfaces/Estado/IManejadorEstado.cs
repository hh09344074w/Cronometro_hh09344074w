/*
 * Creado por SharpDevelop.
 * Usuario: hugoh
 * Fecha: 10/04/2023
 * Hora: 2:48
 * 
 */
using System;

namespace Cronometro.Modelo.Intefaces.Estado
{
	/// <summary>
	/// Description of ImanejadorEstado.
	/// </summary>
	public interface IManejadorEstado
	{
		
		/// <summary>
		/// Estado actual
		/// </summary>
		IEstadoCronometro Estado { get ;}
		
		//permite lanzar un disparador sobre la maquina
		IEstadoCronometro Transicion(IDisparadorCronometro disparador);
		
	
		/// <summary>
		/// Permite interrogar NotSupportedException una transición		
		/// </summary>
		/// <param name="disparador">transición</param>
		/// <returns>permitida o no</returns>
		 bool PuedeHacerTransicion(IDisparadorCronometro disparador);
		
		/// <summary>
		/// Indica si esta permitido disparar la transicion Start
		/// </summary>
		/// <returns>permitida o no</returns>
		 bool PuedeHacerTransicionStart();
		
		/// <summary>
		///  Indica si esta permitido disparar la transicion Stop
		/// </summary>
		/// <returns>permitida o no</returns>
		 bool PuedeHacerTransicionStop();
		
		/// <summary>
		///  Indica si esta permitido disparar la transicion pause
		/// </summary>
		/// <returns>permitida o no</returns>
		 bool PuedeHacerTransicionPause();
	}
}
