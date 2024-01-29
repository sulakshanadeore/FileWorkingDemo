using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializationDemoWithFiles;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace FileWorkingDemo
{
    internal class SerializationDemo
    {
        static void Main(string[] args)
        {
            //  BinarySerializationCustomer();
            //BinaryDeserializeCustomer();



            









            Console.ReadLine();









        }

        static void jsondeserialize()
        {

            FileStream fs = new FileStream("cust2.json", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);
            string custdata = sr.ReadToEnd();
            Console.WriteLine("String format" + custdata);
            Customer c = JsonConvert.DeserializeObject<Customer>(custdata);
            Console.WriteLine(c.Id);
            Console.WriteLine(c.CustName);
            Console.WriteLine(c.Amt);
            Console.WriteLine(c.City);
            sr.Close();
            fs.Close();

        }

        static void serizalizeJson()
        {
            //newtonsoft.json==> Nuget PAckage Manager
            FileStream fs = new FileStream("cust2.json", FileMode.Create, FileAccess.Write);
            Customer c = new Customer();
            c.Id = 101;
            c.CustName = "Godrej";
            c.City = "Bangalore";
            c.Amt = 100000;

            string s = JsonConvert.SerializeObject(c);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(s);
            sw.Flush();


            sw.Close();
            fs.Close();
        }

        static void XMLDeserilaize() {

            FileStream fs = new FileStream("cust1.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Customer));
            Customer data = (Customer)xs.Deserialize(fs);
            Console.WriteLine(data.Id);
            Console.WriteLine(data.CustName);
            Console.WriteLine(data.Amt);
            Console.WriteLine(data.City);
        }

        static void XMLSerialiseCustomer()
        {
            FileStream fs = new FileStream("cust1.xml", FileMode.Create, FileAccess.Write);
            Customer c = new Customer();
            c.Id = 101;
            c.CustName = "Godrej";
            c.City = "Bangalore";
            c.Amt = 100000;
            XmlSerializer xs = new XmlSerializer(typeof(Customer));
            xs.Serialize(fs, c);
            Console.WriteLine("done");
        }


        static void BinaryDeserializeCustomer() {
            FileStream fs = new FileStream("custdata.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Customer data = (Customer)binaryFormatter.Deserialize(fs);//Deserialize means read, from file stream
            Console.WriteLine(data.Id);
            Console.WriteLine(data.CustName);
            Console.WriteLine(data.City);
            Console.WriteLine(data.Amt);
        }


        static void BinarySerializationCustomer() 
        {
            FileStream fs = new FileStream("custdata.bin", FileMode.Create, FileAccess.Write);
            Customer c = new Customer();
            c.Id = 101;
            c.CustName = "Godrej";
            c.City = "Bangalore";
            c.Amt = 100000;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fs, c);//Serialize in binary format
            fs.Close();
            Console.WriteLine("File written object....");
        }
    }
}
