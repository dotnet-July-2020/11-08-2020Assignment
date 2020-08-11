using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using ClassCalculator;

namespace SerializationAssignment
{
  [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            FileStream fs = new FileStream("Calculator.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter sw = new BinaryFormatter();
            sw.Serialize(fs, obj);
            Console.WriteLine("Text File Created");
            Console.Read();
        }
    }
}
