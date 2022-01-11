using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPlaboratorB
{
    class Program
    {
        static void p3()
        {
            // Problema nr 3 : Fie i,j,k. Să se determine restul împărţirii numărului natural ij la k
            // definim ij si k ca si variabile
            double i, j, k;
            Console.WriteLine("Introduceti valoarea lui i");
            i = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui j");
            j = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui k");
            k = double.Parse(Console.ReadLine());

            // definim r ca si calcul i^j % k

            double r = Math.Pow(i, j) % k;

            Console.WriteLine("Rezultatul operatiei este {0}", r);

            Console.ReadLine();
        }

        static void p4()
        {
            // Să se verifice dacă numărul n este perfect. (Un număr n este perfect dacă este egal cu suma divizorilor lui
            // diferiţi de n; exemplu: 6 = 1 + 2 + 3).

            // 1. declaram n
            int n;

            // 2. citim n de la tastatura

            Console.WriteLine("Introduceti valoarea lui n");

            n = int.Parse(Console.ReadLine());

            // declaram s ca suma a divizorilor
            int s = 0;
            for (int i = 1; i < n; i++) // parcurgem 1 pana la < n
                if (n % i == 0) // verificam daca i este divizor al lui n
                    s = s + i; // adunam fiecare divizor gasit
            if (s == n)
                Console.WriteLine("Numarul este perfect"); // afisam rezultatul
            else
                Console.WriteLine("Numarul nu este perfect");

            Console.ReadLine();
        }

        static bool nr_perfecte(int n)//subprogram care verifica daca n este nr perfect


        {
            //luat din p4
            if (n == 1)//n-ul trb sa fie diferit de 1
                return false;
            int s = 1;
            for (int i = 2; i <= n; i++)
                if (n % 1 == 0)
                    s = s + i;
            if (s == n)
                return true;
            return false;

        }
        static void p5()
        {
            int a, b;
            Console.Write("Introduceti numarul cel mai mic al intervalului deschis:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numarul cel mai mare al intervalului deschis: ");
            b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
                if (nr_perfecte(i) == true)
                    Console.Write("{0} ", i);
            Console.ReadLine();


        }

        static void p16()
        {
            //O carte are n foi şi r rânduri pe fiecare pagină. Câte rânduri are cartea?
            int n, r;
            Console.Write("Introduceti numarul de pagini: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul de randuri: ");
            r = int.Parse(Console.ReadLine());

            int x = n * r;
            Console.Write("Numarul total de randuri este: {0}", x);

            Console.ReadLine();

        }

        static void p24()
        {
            //  Se citeşte un număr natural.Câte cifre conţine ?
            int n;
            Console.WriteLine("Introduceti valoarea lui n: ");
            n = int.Parse(Console.ReadLine());
            int s = 0;

            // folosim o bucla si de fiecare data cand taiem din n ultima cifra numaram cu +1
            while (n != 0)
            {
                n = n / 10;
                s++;

            }
            Console.WriteLine("Numarul are {0} cifre ", s);

            Console.ReadLine();

        }

        static void Main(string[] args)
        {



            //p3();
            //p4();
            //p5();
            //p16();
            //p24();
        }
    }
}
