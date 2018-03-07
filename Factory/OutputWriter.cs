using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;


// Target-specific output via inheritance
// Specialized target-specific custom processing via specific interface method implementation

namespace Factory
{

    public abstract class OutputWriter: IOutputWriter
    {
        public virtual void WriteOutput(string resource)
        {
        }

        public virtual void CustomProcessing()
        {
        }

    }

    public class ConsoleWriter : OutputWriter, IOutputWriterConsole
    {
        public override void WriteOutput(string resource)
        {
            Console.Write(resource);
            Console.ReadKey();
        }

        public override void CustomProcessing()
        {
            Debug.Write("Message from CustomProcessingConsole");
        }

    }

    public class DBWriter : OutputWriter, IOutputWriterDB
    {
        public override void WriteOutput(string resource)
        {
            throw new Exception("Not Implemented");
        }

    }

    public class SQLServerWriter : DBWriter, IOutputWriterSQLServer
    {
        public override void WriteOutput(string resource)
        {
            throw new Exception("Not Implemented");
        }

        public override void CustomProcessing()
        {
            Debug.Write("This is CustomProcessing for DB - SQLServer");
        }

    }

    public class OracleWriter : DBWriter, IOutputWriterOracle
    {
        public override void WriteOutput(string resource)
        {
            throw new Exception("Not Implemented");
        }

        public override void CustomProcessing()
        {
            Debug.Write("This is CustomProcessing for DB - Oracle");
        }

    }

}

