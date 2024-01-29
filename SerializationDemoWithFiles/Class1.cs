using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemoWithFiles
{
    [Serializable()]
    public class Customer
    {
        public int Id { get; set; }



        [NonSerialized]
        private int _amt;
        public int Amt { get { return _amt; } set { _amt = value; } }
        public string CustName { get; set; }
        public string City { get; set; }
    }
}
