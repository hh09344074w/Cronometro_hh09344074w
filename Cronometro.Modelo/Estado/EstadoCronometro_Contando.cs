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
	public sealed class EstadoCronometro_Contando : IEstadoCronometro
	{
		private static EstadoCronometro_Contando instance = new EstadoCronometro_Contando();
		
		public static EstadoCronometro_Contando Instance {
			get {
				return instance;
			}
		}
			
	
		
		public IEstadoCronometro Transicion(IDisparadorCronometro disparador)
		{
			if ( disparador ==  DisparadorCronometro_Stop.Instance)
			{
				return EstadoCronometro_Inicial.Instance;
			}			
			else if ( disparador ==  DisparadorCronometro_Pause.Instance)
			{
				return EstadoCronometro_Pausado.Instance;
			}			
			else
			{
				throw new NotSupportedException();
				
			}			
		}
		
		
		public bool PuedeHacerTransicion(IDisparadorCronometro disparador)
		{
			if ( disparador ==  DisparadorCronometro_Start.Instance)
			{
				return false;
			}			
			else 	{
				return true;
			}	
		}		
		 
	}
}
