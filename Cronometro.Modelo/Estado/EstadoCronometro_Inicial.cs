/*
 * Creado por SharpDevelop.
 * Usuario: hugoh
 * Fecha: 04/06/2023
 * Hora: 01:07
 * 
 */
using System;
using Cronometro.Modelo.Intefaces.Estado;

namespace Cronometro.Modelo.Estado
{
	/// <summary>
	/// Estado Inicial
	/// </summary>
	public sealed class EstadoCronometro_Inicial : IEstadoCronometro
	{
		private static EstadoCronometro_Inicial instance = new EstadoCronometro_Inicial();
		
		public static EstadoCronometro_Inicial Instance {
			get {
				return instance;
			}
		}
		
		public IEstadoCronometro Transicion(IDisparadorCronometro disparador)
		{
			if (disparador == DisparadorCronometro_Start.Instance) {
				return EstadoCronometro_Contando.Instance;
			} else {
				throw new NotSupportedException();
				
			}			
		}
		
		
		public bool PuedeHacerTransicion(IDisparadorCronometro disparador)
		{
			if (disparador == DisparadorCronometro_Start.Instance) {
				return true;
			} else {
				return false;
			}	
		}
		 
	}
}
