

namespace Factory
{
    public interface IOutputWriter
    {
        bool WriteOutput(string Resource);
        bool CustomProcessing();
    }

    public interface IOutputWriterConsole: IOutputWriter
    {
        new bool CustomProcessing();
    }

    public interface IOutputWriterDB : IOutputWriter
    {
    }

    public interface IOutputWriterSQLServer : IOutputWriterDB
    {
        new bool CustomProcessing();
    }

    public interface IOutputWriterOracle : IOutputWriterDB
    {
        new bool CustomProcessing();
    }

}
