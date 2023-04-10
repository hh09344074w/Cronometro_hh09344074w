/*
 * Creado por SharpDevelop.
 * Usuario: hugoh
 * Fecha: 04/05/2023
 * Hora: 23:26
 * 
 */
using System;
using Cronometro.Modelo.Intefaces;
using Cronometro.Modelo;
using System.Windows;
using System.Windows.Threading;
using Cronometro.Presentacion.Infraestructura;
using System.ComponentModel;
using Cronometro.Modelo.Estado;

namespace Cronometro.Presentacion
{
	/// <summary>
	/// Description of CronometroViewModel.
	/// </summary>
	public class CronometroViewModel: INotifyPropertyChanged, IDisposable
	{
		private const int TASA_MUESTREO = 10;
		//TODO llevar a configuración
		private ICronometroModelo cronometroModelo;
		private DispatcherTimer timer = new DispatcherTimer();
		
		public CronometroViewModel()
		{			
			timer.Interval = TimeSpan.FromMilliseconds(TASA_MUESTREO);
			timer.Tick += RefreshContentEvent;
			timer.Start();
			cronometroModelo = new CronometroModelo(); //TODO Cambiar el constructor por un inyector de dependencia.
			StartCommand = new DelegateCommand(cronometroModelo.Start, cronometroModelo.Estado.PuedeHacerTransicionStart);
			PauseCommand = new DelegateCommand(cronometroModelo.Pause, cronometroModelo.Estado.PuedeHacerTransicionPause);
			StopCommand = new DelegateCommand(cronometroModelo.Stop, cronometroModelo.Estado.PuedeHacerTransicionStop);
			
		}
		
		/// <summary>
		/// Tratamiento del evento del Timer
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RefreshContentEvent(object sender, EventArgs e)
		{   
			//Se indica a la interface que se debe muestrear el modelo.			
			if(PropertyChanged!= null)
			{
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Medida"));			
			}
		}

		/// <summary>
		/// Property bindada a la interface gráfica, expone los segundos pasados según el modelo
		/// </summary>
		public string Medida {
			get { return TimeSpan.FromSeconds(cronometroModelo.Segundos).ToString(@"hh\:mm\:ss"); } //TODO Llevar la cadena de formato a configuración
		}
		
		
		#region Delegates
		//Propiedades con los comandos disponibles
		public DelegateCommand StartCommand { get; private set; }
		public DelegateCommand PauseCommand { get; private set; }
		public DelegateCommand StopCommand { get; private set; }
  		#endregion Delegates
	
		
		#region INotifyPropertyChanged
		//Implementación de INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;	
	   
		private void NotifyPropertyChanged(String propertyName)
		{  
			PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion INotifyPropertyChanged
		
		public void Dispose(){
			this.timer.Stop();
			this.timer=null;
		}
	}
}
