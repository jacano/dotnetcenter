using System;
using System.Collections.Generic;
using System.Text;

namespace PluginInterfaces
{
    public interface IPluginHost
    {
       Atributes ConfigAtributes { get; }
       ILog Log { get;}

       string SendMail(string to, string tuNombre, string subject, string body);
    }

    public sealed class Atributes
    {
        public string CuentaEmail;
        public string PasswordEmail;
        public int PortServerEmail;
        public string HostServerEmail;
        public bool EnableSslServerEmail;
        public int NumeroPrestamosPorSocio;
    }
}
