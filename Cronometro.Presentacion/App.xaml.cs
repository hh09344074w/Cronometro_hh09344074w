using System;
using System.Windows;
using System.Data;
using System.Xml;
using System.Configuration;


namespace Cronometro.Presentacion
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		
		protected override void OnStartup(StartupEventArgs e)
		{    	
    		base.OnStartup(e);
    		//this MainViewModel from your ViewModel project
    		MainWindow = new CronometroWindow();    		
		} 
	}
	
	
}