using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace CHAPIClient
{

    /// This class receives reference to the OutputWriter via Dependency Injection into the constructor at instantiation
    /// This is facilitated by Interface-based reference in the constuctor

    public class TestRunner
    {
        private IOutputWriter _outWriter;
        private string _message;

        public TestRunner(IOutputWriter outWriter, string message)
        {
            _outWriter = outWriter;
        }

        public void WriteOutput()
        {
            bool result = _outWriter.WriteOutput(_message);
        }

        public void CustomProcessing()
        {
            bool result = _outWriter.CustomProcessing();
        }

    }
}
