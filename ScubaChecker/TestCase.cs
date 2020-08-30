using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ScubaChecker
{
    [Serializable]
    public class TestCase : ITestCase
    {
        public string TestContent { get ; set; }
        public int Id { get; set; }

        public bool Run()
        {
            return true;
        }
    }
}
