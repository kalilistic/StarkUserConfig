using System;
using System.IO;
using NUnit.Framework;

namespace StarkUserConfig.Test
{
    [TestFixture]
    public class ConfigSerializerTest
    {
        private const string TestFile = "Test.xml";
        private const string TestObjectName = "John";
        private string _testFilePath = "";

        [SetUp]
        public void TestInitialize()
        {
            _testFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TestFile);
        }

        [TearDown]
        public void TestCleanup()
        {
            try
            {
                File.Delete(_testFilePath);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        [Test]
        public void WriteXml_ReadXml_SavesFile()
        {
            var objectIn = new TestObject {Name = TestObjectName};
            ConfigSerializer.WriteXml(_testFilePath, objectIn);

            TestObject objectOut = ConfigSerializer.ReadXml(_testFilePath, objectIn);
            Assert.AreEqual(TestObjectName, objectOut.Name);
        }

        [Test]
        public void WriteXml_BadPath_NoError()
        {
            var objectIn = new TestObject {Name = TestObjectName};
            ConfigSerializer.WriteXml(null, objectIn);
        }

        [Test]
        public void WriteXml_NoFile_NoError()
        {
            ConfigSerializer.ReadXml(_testFilePath, new TestObject());
        }
    }
}