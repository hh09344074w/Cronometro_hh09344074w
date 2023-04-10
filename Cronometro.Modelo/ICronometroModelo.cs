/*
 * Created by SharpDevelop.
 * User: hugoh
 * Date: 05/04/2023
 * Time: 21:18
 */
using System;

namespace Cronometro.Modelo.Intefaces
{
	/// <summary>
	/// Description of ICronometroModelo.
	/// </summary>
	public interface ICronometroModelo
	{
		/// <summary>
		/// Devuelve el estado del segundero
		/// </summary>
		double Segundos { get; }

		/// <summary>
		/// - Start: Arranca el cronómetro.
		/// </summary>
        void Start();

        /// <summary>
        ///  Pause: Pausa el cronómetro.
        /// </summary>
        void Pause();

        /// <summary>
        /// Stop: Para el cronómetro y reinicia el contador del cronómetro. 
        /// </summary>
        void Stop();    
	}
}
