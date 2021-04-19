using System;
using System.Linq;
using System.Runtime.InteropServices;
using ACM.BL;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Object myObject = new Object();
            Product product = new Product();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
        }
        
        static int marsExploration(string s)
        {

            var t = "";
            var wrongLetterCount = 0;

            if (s.Length >=1 && s.Length <=99 && s.Length % 3 == 0)
            {
                for (int i = 0; i < s.Length; i+=3)
                {
                    t = s.Substring(i, 3);

                    if (t[0] != 'S' || t[1] != 'O' || t[2] != 'S')
                    {
                        wrongLetterCount++;
                    }
                }
            }



            return wrongLetterCount;

        }
        
        
        
        static int sockMerchant(int n, int[] ar)
        {

            int pairCount = 0;
            int matches = 0;

            var dupes = ar.GroupBy(p => p)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);


            foreach (var d in dupes )
            {
                foreach (var num in ar)
                {
                    if (d == num)
                    {
                        matches++;
                    }
                }

                if (matches % 2 == 0)
                {
                    pairCount += matches / 2;
                }
                else
                {
                    pairCount += (matches - 1) / 2;
                }

                matches = 0;
            }

            return pairCount;

        }
        
        
        public static int CalculateYears(double principal, double interest,  double tax, double desiredPrincipal)
        {
            int counter = 0;
            double yearPrice = 0;
            double total;
            double totalMinusTax;
            
            if (principal < desiredPrincipal)
            {
                 total = principal * interest ;
                 totalMinusTax = total - (total * tax);
                yearPrice = principal + totalMinusTax;
                counter++;
                
                while (yearPrice < desiredPrincipal)
                {
                    total = yearPrice * interest;
                    totalMinusTax = total - (total * tax);
                    yearPrice = yearPrice + totalMinusTax;
                    counter++;
                }
            }
            
         
            
            
            
            
            

            return counter;
        }
    }
}