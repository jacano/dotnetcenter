using System;
using System.Windows.Forms;

namespace PluginInterfaces
{
	public interface IPlugin
	{
		IPluginHost Host {get;set;}
		
		string Name {get;}
		string Email {get;}
		string Version {get;}
		
		UserControl MainInterface {get;}
		
		void Initialize();
        void InitializeForm();
		void Dispose();
	}
}
