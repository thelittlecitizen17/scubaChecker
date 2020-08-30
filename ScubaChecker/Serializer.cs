using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ScubaChecker
{
    class Serializer<T> : ISerializer<T>
    {

        public Stream Serialize(T[] testsToSerialize)
        {
            XmlDocument doc = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(testsToSerialize.GetType());
            MemoryStream stream = new MemoryStream();

            try
            {
                serializer.Serialize(stream, testsToSerialize);
                stream.Position = 0;
                return stream;

            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
               
                
            }
        }
    }
}
