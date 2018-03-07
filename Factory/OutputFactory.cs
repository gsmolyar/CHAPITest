using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
//using System.Web.Configuration;

namespace Factory
{
    public class OutputFactory
    {
        // Factory gets the Output target from config

        private string _outputTarget;

        public OutputFactory()
        {
            _outputTarget = ConfigurationManager.AppSettings["OutputTarget"];
            //_outputTarget = WebConfigurationManager.AppSettings["OutputTarget"];

        }


        // Create an object ased on configuration
        public IOutputWriter CreateOutputWriter()
        {
            IOutputWriter outWriter = null;

            switch (_outputTarget)
            {
                case "Console":
                    outWriter = new ConsoleWriter();
                    break;

                case "SQL":
                    outWriter = new SQLServerWriter();
                    break;

                case "Oracle":
                    outWriter = new OracleWriter();
                    break;

                default:
                    break;
            }

            return outWriter;
        }


    }
}