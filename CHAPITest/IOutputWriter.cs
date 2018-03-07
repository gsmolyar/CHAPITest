using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAPITest
{
    public interface IOutputWriter
    {
        void WriteOutput(string Resource);
        //void CustomProcessing();
    }

    public interface IOutputWriterConsole: IOutputWriter
    {
        
    }

    public interface IOutputWriterDB : IOutputWriter
    {

    }

    public interface IOutputWriterSQLServer : IOutputWriterDB
    {

    }

    public interface IOutputWriterOracle : IOutputWriterDB
    {

    }

}
