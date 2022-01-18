using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1001, "VRudniev", "Apple");
            invoice.Calculator("iphone10", 7);
        }
    }
}
