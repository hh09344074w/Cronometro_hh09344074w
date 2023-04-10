/*
 * Creado por SharpDevelop.
 * Usuario: hugoh
 * Fecha: 04/06/2023
 * Hora: 01:23
 * 
 */
using System;
using Cronometro.Modelo.Intefaces.Estado;


namespace Cronometro.Modelo.Estado
{
	/// <summary>
	/// Description of DisparadorCronometro_Stop.
	/// </summary>
	public sealed class DisparadorCronometro_Stop : IDisparadorCronometro
	{
		private static DisparadorCronometro_Stop instance = new DisparadorCronometro_Stop();
		
		public static DisparadorCronometro_Stop Instance {
			get {
				return instance;
			}
		}
		
		private DisparadorCronometro_Stop()
		{
		}
	}
}
