using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CHAPITest
{
    public class OutputFactory
    {
        private string _outputTarget;

        public OutputFactory(string outputTarget)
        {
            _outputTarget = outputTarget;
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