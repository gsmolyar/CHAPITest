using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Web;
using Factory;
using System.Diagnostics;

namespace CHAPIService.Tests
{
    [TestClass]
    public class CHAPIService_Tests
    {
        [TestMethod]
        public void OutputTargetObtained()
        {
            CHAPIController controller = new CHAPIController();
            string outputTarget = controller.GetOutputTarget();
            Assert.IsNotNull(outputTarget);

        }

        [TestMethod]
        public void OutputWriterObtained()
        {
            OutputFactory outputFactory = new OutputFactory();
            IOutputWriter outWriter = outputFactory.CreateOutputWriter();
            Debug.Write("Test OutputWriterObtained");
            Assert.IsNotNull(outWriter);

        }

        [TestMethod]
        public void OutputWriterWriteOutputRun()
        {
            OutputFactory outputFactory = new OutputFactory();
            IOutputWriter outWriter = outputFactory.CreateOutputWriter();
            Debug.Write("Test OutputWriterOutputRun");

            Assert.IsTrue(outWriter.WriteOutput("Hello World from Testing"));

        }

        [TestMethod]
        public void OutputWriterCustomProcessingRun()
        {
            OutputFactory outputFactory = new OutputFactory();
            IOutputWriter outWriter = outputFactory.CreateOutputWriter();
            Debug.Write("Test OutputWriterObtained");

            Assert.IsTrue(outWriter.CustomProcessing());

        }

    }
}
