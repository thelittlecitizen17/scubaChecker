using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ScubaChecker
{
    class SerializeFactory : ISerializerFactory
    {
        public ITestsRunner<T> CreateDeserializer<T>()
        {
            ITestsRunner<T> testsRunner = new TestsRunner<T>();
            return testsRunner;
        }

        public ISerializer<T> CreateSerializer<T>()
        {
            ISerializer<T> serializer = new Serializer<T>();
            return serializer;
        }
    }
}
