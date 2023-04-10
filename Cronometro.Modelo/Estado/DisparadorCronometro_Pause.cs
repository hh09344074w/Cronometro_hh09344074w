/*
 * Creado por SharpDevelop.
 * Usuario: hugoh
 * Fecha: 04/06/2023
 * Hora: 01:24
 * 
 */
using System;
using Cronometro.Modelo.Intefaces.Estado;

namespace Cronometro.Modelo.Estado
{
	/// <summary>
	/// Description of DisparadorCronometro_Pause.
	/// </summary>
	public sealed class DisparadorCronometro_Pause : IDisparadorCronometro
	{
		private static DisparadorCronometro_Pause instance = new DisparadorCronometro_Pause();
		
		public static DisparadorCronometro_Pause Instance {
			get {
				return instance;
			}
		}
		
		private DisparadorCronometro_Pause()
		{
		}
	}
}
