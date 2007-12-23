using System;
using System.Collections.Generic;
using System.Text;
using PluginInterfaces;
using System.IO;
using System.Reflection;
using Configuration;

namespace DotnetCenter
{
  	public class PluginServices : IPluginHost
	{
        public Attributes ConfigAtributes
        {
            get { return ConfigFile.GetInstance(); }
        }

        public ILog Log
        {
            get { return Center.log; }
        }
		/// <summary>
		/// Constructor of the Class
		/// </summary>
		public PluginServices()
		{
		}

     	private Types.AvailablePlugins colAvailablePlugins = new Types.AvailablePlugins();
		
		/// <summary>
		/// A Collection of all Plugins Found and Loaded by the FindPlugins() Method
		/// </summary>
		public Types.AvailablePlugins AvailablePlugins
		{
			get {return colAvailablePlugins;}
			set {colAvailablePlugins = value;}
		}

        public string SendMail(string to, string tuNombre, string subject, string body)
        {
            return Center.SendMail(to, tuNombre, subject, body);
        }
		
		/// <summary>
		/// Searches the Application's Startup Directory for Plugins
		/// </summary>
		public void FindPlugins()
		{
			FindPlugins(AppDomain.CurrentDomain.BaseDirectory);
		}
		/// <summary>
		/// Searches the passed Path for Plugins
		/// </summary>
		/// <param name="Path">Directory to search for Plugins in</param>
		public void FindPlugins(string Path)
		{
			//First empty the collection, we're reloading them all
			colAvailablePlugins.Clear();
		
			//Go through all the files in the plugin directory
			foreach (string fileOn in Directory.GetFiles(Path))
			{
				FileInfo file = new FileInfo(fileOn);
				
				//Preliminary check, must be .dll
				if (file.Extension.Equals(".dll"))
				{	
					//Add the 'plugin'
					this.AddPlugin(fileOn);				
				}
			}
		}
		
		/// <summary>
		/// Unloads and Closes all AvailablePlugins
		/// </summary>
		public void ClosePlugins()
		{
			foreach (Types.AvailablePlugin pluginOn in colAvailablePlugins)
			{
				//Close all plugin instances
				//We call the plugins Dispose sub first incase it has to do 
				//Its own cleanup stuff
				pluginOn.Instance.Dispose(); 
				
				//After we give the plugin a chance to tidy up, get rid of it
				pluginOn.Instance = null;
			}
			
			//Finally, clear our collection of available plugins
			colAvailablePlugins.Clear();
		}
		
		private void AddPlugin(string FileName)
		{
			//Create a new assembly from the plugin file we're adding..
			Assembly pluginAssembly = Assembly.LoadFrom(FileName);
			
			//Next we'll loop through all the Types found in the assembly
			foreach (Type pluginType in pluginAssembly.GetTypes())
			{
				if (pluginType.IsPublic) //Only look at public types
				{
					if (!pluginType.IsAbstract)  //Only look at non-abstract types
					{
						//Gets a type object of the interface we need the plugins to match
						Type typeInterface = pluginType.GetInterface("PluginInterfaces.IPlugin", true);
						
						//Make sure the interface we want to use actually exists
						if (typeInterface != null)
						{
							//Create a new available plugin since the type implements the IPlugin interface
							Types.AvailablePlugin newPlugin = new Types.AvailablePlugin();
							
							//Set the filename where we found it
							newPlugin.AssemblyPath = FileName;
							
							//Create a new instance and store the instance in the collection for later use
							//We could change this later on to not load an instance.. we have 2 options
							//1- Make one instance, and use it whenever we need it.. it's always there
							//2- Don't make an instance, and instead make an instance whenever we use it, then close it
							//For now we'll just make an instance of all the plugins
                            try
                            {
                                newPlugin.Instance = (IPlugin)Activator.CreateInstance(pluginAssembly.GetType(pluginType.ToString()));
                            }
                            catch (Exception ex)
                            {
                                Center.log.Write("Error al cargar la dll: " + FileName);
                            }
							
							//Set the Plugin's host to this class which inherited IPluginHost
							newPlugin.Instance.Host = this;

							//Call the initialization sub of the plugin
							newPlugin.Instance.Initialize();
							
							//Add the new plugin to our collection here
							this.colAvailablePlugins.Add(newPlugin);
							
							//cleanup a bit
							newPlugin = null;
						}	
						
						typeInterface = null; //Mr. Clean			
					}				
				}			
			}
			
			pluginAssembly = null; //more cleanup
		}

	}
}

