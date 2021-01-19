using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Isim = "Bora";
            customer1.SoyIsim = "Kıroğlu";
            customer1.KartNumarasi = "4477 5556 8889 0011"; // Numara rastgele
            customer1.CV2 = 614; // string de yapabiliriz ama bir tane int olmasını istedim

            Customer customer2 = new Customer();
            customer2.Isim = "Uğur";
            customer2.SoyIsim = "Kıroğlu";
            customer2.KartNumarasi = "0048 8868 3234 6564"; 
            customer2.CV2 = 146;

            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager Manager = new CustomerManager();
            
            Manager.Listele(customers[]);

            
            }
        }
    }
