using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ScubaChecker
{
    class TestsRunner<T> : ITestsRunner<T>
    {
        public T[] Deserialize(Stream stream)
        {
            T[] array = null;
            XmlSerializer serializer = new XmlSerializer(typeof(T[]));
            XmlReader xmlReader = XmlReader.Create(new StreamReader(stream));

            try
            {
                array = (T[])serializer.Deserialize(xmlReader);
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                xmlReader.Close();
            }

            return array;
        }
    }
}
