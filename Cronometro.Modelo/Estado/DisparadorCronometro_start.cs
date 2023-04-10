/*
 * Creado por SharpDevelop.
 * Usuario: hugoh
 * Fecha: 04/06/2023
 * Hora: 01:12
 * 
 */
using System;
using Cronometro.Modelo.Intefaces.Estado;


namespace Cronometro.Modelo.Estado
{
	/// <summary>
	/// Description of SingletonClass1.
	/// </summary>
	public sealed class DisparadorCronometro_Start: IDisparadorCronometro
	{
		private static DisparadorCronometro_Start instance = new DisparadorCronometro_Start();
		
		public static DisparadorCronometro_Start Instance {
			get {
				return instance;
			}
		}
		
		private DisparadorCronometro_Start()
		{
		}
	}
}
