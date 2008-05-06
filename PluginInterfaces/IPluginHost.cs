using System;
using System.Collections.Generic;
using System.Text;
using Configuration;

namespace PluginInterfaces
{
    public interface IPluginHost
    {
       Attributes ConfigAtributes { get; }
       ILog Log { get;}
    }
}
