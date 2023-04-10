/*
 * Creado por SharpDevelop.
 * Usuario: hugoh
 * Fecha: 05/04/2023
 * Hora: 22:06
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Cronometro.Modelo.Intefaces;
using Cronometro.Modelo;
using System.Windows.Threading;
using System.ComponentModel;


namespace Cronometro.Presentacion
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class CronometroWindow : Window
	{
		  
		public CronometroWindow()
		{
			InitializeComponent();			
		}
		

		
		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
		{
			if (this.DataContext is IDisposable) {
				((IDisposable)this.DataContext).Dispose();
			}
		
			base.OnClosing(e);       
		}
		
	}
}