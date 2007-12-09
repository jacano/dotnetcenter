using System;
using System.Collections.Generic;
using System.Text;
using PluginInterfaces;
using DotnetCenter.LogTypes;

namespace DotnetCenter
{
    public class LogFactory
    {
        private static LogFactory handle;

        /// <summary>
        /// Constructor privado (Singleton)
        /// </summary>
        private LogFactory() { }

        /// <summary>
        /// Obtiene la única instancia de la factoría
        /// </summary>
        /// <returns></returns>
        public static LogFactory GetInstance()
        {
            if (handle == null)
                handle = new LogFactory();

            return handle;
        }

        /// <summary>
        /// Crea un tipo de log u otro
        /// </summary>
        /// <param name="FactoryType"></param>
        /// <returns></returns>
        public ILog CreateLog(string FactoryType)
        {
            ILog log = null;

            switch (FactoryType)
            {
                case "File":
                    log = new FileLog();
                    break;
            }

            return log;
        }
    }
}
