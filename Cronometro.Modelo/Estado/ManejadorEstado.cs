/*
 * Creado por SharpDevelop.
 * Usuario: hugoh
 * Fecha: 04/06/2023
 * Hora: 01:46
 * 
 */
using System;
using Cronometro.Modelo.Intefaces.Estado;

namespace Cronometro.Modelo.Estado
{
	/// <summary>
	/// Description of ManejadorEstado.
	/// </summary>
	public class ManejadorEstado: IManejadorEstado
	{		
		private IEstadoCronometro estado;
	
		public ManejadorEstado()
		{
			//Se inicializa l maquina de estados al estado inicial.
			this.estado = EstadoCronometro_Inicial.Instance;
		}
		
		/// <summary>
		/// Estado actual
		/// </summary>
		public IEstadoCronometro Estado { get {return this.estado;} }
		
		//permite lanzar un disparador sobre la maquina
		public IEstadoCronometro Transicion(IDisparadorCronometro disparador)
		{
			if(estado.PuedeHacerTransicion(disparador))
			{
				estado=estado.Transicion(disparador);
			}	   
			return estado;
		}
		
	
		/// <summary>
		/// Permite interrogar NotSupportedException una transición		
		/// </summary>
		/// <param name="disparador">transición</param>
		/// <returns>permitida o no</returns>
		public bool PuedeHacerTransicion(IDisparadorCronometro disparador)
		{
			return estado.PuedeHacerTransicion(disparador);
		}
		
		/// <summary>
		/// Indica si esta permitido disparar la transicion Start
		/// </summary>
		/// <returns>permitida o no</returns>
		public bool PuedeHacerTransicionStart()
		{
			return estado.PuedeHacerTransicion(DisparadorCronometro_Start.Instance);
		}
		
		/// <summary>
		///  Indica si esta permitido disparar la transicion Stop
		/// </summary>
		/// <returns>permitida o no</returns>
		public bool PuedeHacerTransicionStop()
		{
			return estado.PuedeHacerTransicion(DisparadorCronometro_Stop.Instance);
		}
		
		/// <summary>
		///  Indica si esta permitido disparar la transicion pause
		/// </summary>
		/// <returns>permitida o no</returns>
		public bool PuedeHacerTransicionPause()
		{
			return estado.PuedeHacerTransicion(DisparadorCronometro_Pause.Instance);
		}
	}
}
