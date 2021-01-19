using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public static void Listele(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Isim);
                Console.WriteLine(customer.SoyIsim);
                Console.WriteLine(customer.KartNumarasi);
                Console.WriteLine(customer.CV2);
                Console.WriteLine("***************");
            }
        }
    }
}
