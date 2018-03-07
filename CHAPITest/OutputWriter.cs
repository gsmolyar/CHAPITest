using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHAPITest
{
    public class OutputWriter: IOutputWriter
    {
        public virtual void WriteOutput(string resource)
        {
        }
    }

    public class ConsoleWriter : OutputWriter, IOutputWriterConsole
    {
        public override void WriteOutput(string resource)
        {
            Console.Write(resource);
            Console.ReadKey();
            return;
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
    }

    public class OracleWriter : DBWriter, IOutputWriterOracle
    {
        public override void WriteOutput(string resource)
        {
            throw new Exception("Not Implemented");
        }
    }

}

