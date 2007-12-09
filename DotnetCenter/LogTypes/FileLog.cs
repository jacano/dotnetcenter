using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using PluginInterfaces;

namespace DotnetCenter.LogTypes
{
    public class FileLog : ILog
    {
        private StreamWriter writer = null;
        private const string LogFilename = "Log.txt";

        public FileLog()
        {
            try
            {
                //Open File
                FileStream file = File.Open(LogFilename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);

                // Check if file is too big (more than 2 MB),
                // in this case we just kill it and create a new one :)
                if (file.Length > 2 * 1024 * 1024)
                {
                    file.Close();
                    file = File.Open(LogFilename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);

                }
                // Associate writer with that, when writing to a new file,
                // make sure UTF-8 sign is written, else don't write it again!
                if (file.Length == 0)
                    writer = new StreamWriter(file,
                        System.Text.Encoding.UTF8);
                else
                    writer = new StreamWriter(file);

                // Go to end of file
                writer.BaseStream.Seek(0, SeekOrigin.End);

                // Enable auto flush (always be up to date when reading!)
                writer.AutoFlush = true;

                // Add some info about this session
                writer.WriteLine("");
                writer.WriteLine("/// Session started at: " +
                    DateTime.Now.Year + "-" +
				    DateTime.Now.Month.ToString("00") + "-" +
				    DateTime.Now.Day.ToString("00") + " " +
				    DateTime.Now.Hour.ToString("00") + ":" +
				    DateTime.Now.Minute.ToString("00"));
                writer.WriteLine("/// DotnetCenter");
                writer.WriteLine("");
            } 
            catch
            {
                // Ignore any file exceptions, if file is not
                // createable (e.g. on a CD-Rom) it doesn't matter.
            } 
        } 

        /// <summary>
        /// Writes a LogType and info/error message string to the Log file
        /// </summary>
        public void Write(string message)
        {
            // Can't continue without valid writer
            if (writer == null)
                return;

            try
            {
                //Garantizamos la exclusión mutua
                lock (this)
                {
                    DateTime ct = DateTime.Now;
                    string s = "[" + ct.Hour.ToString("00") + ":" +
                        ct.Minute.ToString("00") + ":" +
                        ct.Second.ToString("00") + "] " +
                        message;
                    writer.WriteLine(s);

#if DEBUG
                    // In debug mode write that message to the console as well!
                    System.Console.WriteLine(s);
#endif
                }
            }
            catch
            {
                // Ignore any file exceptions, if file is not
                // writable (e.g. on a CD-Rom) it doesn't matter
            } 
        } 
    }
}


