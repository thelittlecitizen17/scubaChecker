using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ScubaChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCaseIniti testCase = new TestCaseIniti();
            testCase.Init();

        }
    }
}
