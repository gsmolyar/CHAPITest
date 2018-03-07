

namespace Factory
{
    public interface IOutputWriter
    {
        void WriteOutput(string Resource);
        void CustomProcessing();
    }

    public interface IOutputWriterConsole: IOutputWriter
    {
        new void CustomProcessing();
    }

    public interface IOutputWriterDB : IOutputWriter
    {
    }

    public interface IOutputWriterSQLServer : IOutputWriterDB
    {
        new void CustomProcessing();
    }

    public interface IOutputWriterOracle : IOutputWriterDB
    {
        new void CustomProcessing();
    }

}
