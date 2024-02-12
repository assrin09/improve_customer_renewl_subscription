using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace improve_customer_renewl_subscription
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dayUNtilExpiration = random.Next(12);
            int discountPercentge = 0;

            
            if (dayUNtilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (dayUNtilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day! Renew now and save 20 % !");
                discountPercentge = 20;
            }
            else if (dayUNtilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {dayUNtilExpiration} days.Renew now and save 10% !");
                discountPercentge = 10;
            }
            if (dayUNtilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            if (discountPercentge > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentge}");
            }


            Console.ReadLine();
            }
        }
    }

