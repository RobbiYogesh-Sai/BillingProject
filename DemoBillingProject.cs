using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingProject
{
    public class DemoBillingProject
    {
        int p,count=0;
        String[] products=new String[10];
        int[] units=new int[10];
        int[] totalUnits=new int[10];
        public void GetDetails()
        {
            Console.Write("Enter how many products taken: ");
            p=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(count);
        }
        public void GetProductDetails()
        {
            for(int i = 1; i <= p; i++)
            {
                Console.Write($"{i}: Enter the product Name: ");
                products[i]=Convert.ToString(Console.ReadLine());
            }
        }
        public void GetEachProductCost()
        {
            for(int i = 1;i <= p; i++)
            {
                Console.WriteLine($"{i}: Enter the Each Product Cost: ");
                units[i]=Convert.ToInt32(Console.ReadLine());
            }
        }
        public void DispalyProduct()
        {
            for (int i = 1; i <= p; i++)
            {
                Console.WriteLine(products[i]);
                totalUnits[i] = units[i] + units[i + 1];
            }
            Console.WriteLine("\n");
        }
        public void TotalPrice()
        {
            Console.WriteLine("The Total Price\n");
            for (int i = 1; i <= p; i++)
            {
                Console.WriteLine($"Total: {totalUnits[i]}");
                break;
            }
        }
        public void display()
        {
            Console.WriteLine("This new created function");
        }
    }
}
//Push The Code

