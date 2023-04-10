/*
 * Creado por SharpDevelop.
 * Usuario: hugoh
 * Fecha: 05/04/2023
 * Hora: 21:36
 * 
 */
using System;
using System.Windows.Input;

namespace Cronometro.Presentacion.Infraestructura
{
	/// <summary>
	/// Clase Delegate Command mínimo para tratar los comandos lanzados dede la interface.
	/// </summary>
    public class DelegateCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public DelegateCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Indica si puede ejecutarse el comando
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        /// <summary>
        /// Ejecuta el comando
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _execute();
        }
      
        /// <summary>
        /// integra el comnado en el ComandManager, ello permite que los CanExecute se tengan en cuenta.
        /// </summary>
        public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}     
    }
}