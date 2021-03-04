using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using TestProject.MiniSqlParser;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Parsing()
        {
            IQuery query = Parser.Parse("SELECT * FROM Ta3ble1;");
            Assert.IsTrue(query is SelectAll);
            Assert.AreEqual("Ta3ble1", (query as SelectAll).Table());

        }
    }
}
