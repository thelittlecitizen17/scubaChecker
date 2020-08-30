using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ScubaChecker
{
    public class TestCaseIniti
    {
        public TestCaseIniti()
        {

        }
        public void Init()
        {
            TestCase test1 = new TestCase();
            TestCase test2 = new TestCase();
            test1.Id = 32455678;
            test1.TestContent = "This is serialization and desarialization test! ";
            test2.Id = 32455678;
            test2.TestContent = "This is serialization and desarialization test! ";

            TestCase[] arr  =  { test1, test2 }; 

            SerializeFactory serializeFactory = new SerializeFactory();
            var serializator = serializeFactory.CreateSerializer<TestCase>();
            var x = serializator.Serialize(arr);

            var deserializator = serializeFactory.CreateDeserializer<TestCase>();
            var y=deserializator.Deserialize(x);
        }
        
    }
}
