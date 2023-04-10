/*
 * Creado por SharpDevelop.
 * Usuario: hugoh
 * Fecha: 05/04/2023
 * Hora: 21:36
 * 
 */
using System;
using Cronometro.Modelo.Intefaces;
using Cronometro.Modelo.Intefaces.Estado;
using Cronometro.Modelo.Estado;
using System.Diagnostics;

namespace Cronometro.Modelo
{
	/// <summary>
	/// Description of CronometroModelo.
	/// </summary>
	public class CronometroModelo : ICronometroModelo
	{		
		/// <summary>
		/// Constante de transformación de milisegundos a segundos
		/// </summary>
		const int MILISEGUNDOS_SEGUNDO = 1000;
		/// <summary>
		/// Contiene la lógica de las transiciones entre estados
		/// </summary>
		readonly private IManejadorEstado estado= new ManejadorEstado(); //TODO Pasar del constructor a inyeción de dependencia.
		/// <summary>
		/// El stopwatch es un timer que proporciona medidas precisas si el hardware lo permite.
		/// </summary>
		readonly private Stopwatch stopwatch= new Stopwatch();
				
		
		public CronometroModelo()
		{
		}
		
		/// <summary>
		/// Devuelve el estado del segundero
		/// </summary>
		public double Segundos {
			get {
						return stopwatch.ElapsedMilliseconds / MILISEGUNDOS_SEGUNDO;
			} 
		}
		
		public  IManejadorEstado Estado { get{return this.estado;}}

		/// <summary>
		/// - Start: Arranca el cronómetro.
		/// </summary>
		public void Start()
		{						
				stopwatch.Start();						
				estado.Transicion(DisparadorCronometro_Start.Instance);
		}

		/// <summary>
		///  Pause: Pausa el cronómetro.
		/// </summary>
		public void Pause()
		{   				
				stopwatch.Stop();
				estado.Transicion(DisparadorCronometro_Pause.Instance);			
		}

		/// <summary>
		/// Stop: Para el cronómetro y reinicia el contador del cronómetro. 
		/// </summary>
		public void Stop()
		{		
			stopwatch.Reset();
			estado.Transicion(DisparadorCronometro_Stop.Instance);			
		}
	}
}
