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
	public sealed class EstadoCronometro_Pausado : IEstadoCronometro
	{
		private static EstadoCronometro_Pausado instance = new EstadoCronometro_Pausado();
		
		public static EstadoCronometro_Pausado Instance {
			get {
				return instance;
			}
		}
		
		public IEstadoCronometro Transicion(IDisparadorCronometro disparador)
		{
			if ( disparador ==  DisparadorCronometro_Start.Instance)
			{
				return EstadoCronometro_Contando.Instance;
			}			
			else if ( disparador ==  DisparadorCronometro_Stop.Instance)
			{
				return EstadoCronometro_Inicial.Instance;
			}			
			else
			{
				throw new NotSupportedException();
				
			}			
		}
		
		
		public bool PuedeHacerTransicion(IDisparadorCronometro disparador)
		{
			if ( disparador ==  DisparadorCronometro_Start.Instance || disparador ==  DisparadorCronometro_Stop.Instance)
			{
				return true;
			}				
			else 	{
				return false;
			}	
		}			 
	}
}
