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
        public virtual bool WriteOutput(string resource)
        {
            return false;
        }

        public virtual bool CustomProcessing()
        {
            return false;
        }

    }

    public class ConsoleWriter : OutputWriter, IOutputWriterConsole
    {
        public override bool WriteOutput(string resource)
        {
            Console.Write(resource);
            Console.ReadKey();
            return true;
        }

        public override bool CustomProcessing()
        {
            Debug.Write("CustomProcessing for Console");
            return true;
        }

    }

    public class DBWriter : OutputWriter, IOutputWriterDB
    {
        public override bool WriteOutput(string resource)
        {
            return false;
        }

    }

    public class SQLServerWriter : DBWriter, IOutputWriterSQLServer
    {
        public override bool WriteOutput(string resource)
        {
            Debug.Write("WriteOutput - SQL Server");
            return false;
        }

        public override bool CustomProcessing()
        {
            Debug.Write("CustomProcessing - SQLServer");
            return true;
        }

    }

    public class OracleWriter : DBWriter, IOutputWriterOracle
    {
        public override bool WriteOutput(string resource)
        {
            Debug.Write("WriteOutput - Oracle");
            return true;
        }

        public override bool CustomProcessing()
        {
            Debug.Write("CustomProcessing - Oracle");
            return true;
        }

    }

}

