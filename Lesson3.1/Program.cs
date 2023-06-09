using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Main1());
            Console.WriteLine(Main2());
            Console.WriteLine(Main3());
            Console.WriteLine(Main4());
            Console.WriteLine(Main5());
            Console.WriteLine(Main6());
            Console.WriteLine(Main7());
            Console.WriteLine(Main8());
            Console.WriteLine(Main9());
            Console.WriteLine(Main10());
            Console.WriteLine(Main11());
            Console.WriteLine(Main12());
            Console.WriteLine(Main13());
            Console.WriteLine(Main14());
            Console.WriteLine(Main15());
            Console.WriteLine(Main16());
            Console.ReadKey();
        }
        static int Main1() 
        {
            int s = 0;
            int n;
            Console.Write("n = ");
            
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n;i++)
            {
                if (n % i == 0) s += i;
            }
            return s;
        }
        static int Main2() 
        {
            int s = 1;
            int n;
            Console.Write("n = ");
            
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n;i++)
            {
                if (n % i == 0) s *= i;
            }
            return s;
        }
        static int Main3() 
        {
            int s = 0;
            int n;
            Console.Write("n = ");
            
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n;i++)
            {
                if (n % i == 2) s += i;
            }
            return s;
        }
        static int Main4() 
        {
            int s = 1;
            int n;
            Console.Write("n = ");
            
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n;i++)
            {
                if (n % i == 3) s *= i;
            }
            return s;
        }
        static int Main5()
        {
            int s = 0;
            for(int i=10;i<100;i++)
            {
                if(i%3==0)
                {
                    s += i;
                }
            }
            return s;
        }
        static long Main6() 
        {
            long s = 1;
            for (long i = 10; i < 100; i++)
            {
                if (i % 15 == 0)
                {
                    s *= i;
                }
            }

            return s;
        }
        static int Main7()
        {
            int s = 0;
            for (int i = 100; i < 1000; i++)
            {
                if (i % 5 != 0)
                {
                    s += i;
                }
            }
            return s;
        }
        static long Main8()
        {
            long s = 1;
            for (int i = 100; i < 1000; i++)
            {
                if (i % 2 != 0 && i % 3 != 0) 
                {
                    s *= i;
                }
            }
            return s;
        }
        static ulong Main9()
        {
            ulong s = 1;
            for (ulong i = 100; i < 1000; i++)
            {
                if (i % 3 == 1 && i % 4 == 2) 
                {
                    s *= i;
                }
            }
            return s;
        }
        static int Main10()
        {
            int s=0;
            for (int i = 100; i < 1000; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    s = i;
                    break;
                }
            }
            return s;
        }
        static int Main11()
        {
            int s=0;
            for (int i = 1000; i < 10000; i++)
            {
                if (Math.Sqrt(i*26) % 1 == 0)
                {
                    s = i;
                    break;
                }
            }
            return s;
        }
        static int Main12()
        {
            int s=0;
            for (int i = 1000; i < 10000; i++)
            {
                if (Math.Sqrt(i*14) % 1 == 0)
                {
                    s = i;
                    
                }
            }
            return s;
        }
        static int Main13()
        {
            int s=0;
            for (int i = 1000; i < 10000; i++)
            {
                if (Math.Sqrt(i*18) % 1 == 0)
                {
                    s = i;
                    
                }
            }
            return s;
        }
        static int Main14()
        {
            int s = 0,n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 100;i<1000;i++)
            {
                if(Math.Sqrt(i)>n)
                {
                    s=i;
                    break;
                }
            }
            return s;
        }
        static string Main15() 
        {
            bool t = false;
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n%3==0)
            {
                n /= 3;
            }
            if (n==1) t=true;

            return Convert.ToString(t);
        }
        static int Main16() 
        {
            int n,s = 0;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n%4==0) 
            {
                n /= 4;
            }
            if (n == 1) s = 1;
            return s;
        }
        
    }

}
