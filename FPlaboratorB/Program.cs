using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPlaboratorB
{
    class Program
    {


        static void p1()
        {
            //Sa se scrie un program care converteste temperatura din grade celsius in grade fahrenheit si
            //invers utilizand instructiunea switch.

            string input;
;
            Console.WriteLine("1- *F in *C");
            Console.WriteLine("2- *C in *F");
            input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    Console.WriteLine("Introduceti valoarea in *F pe care doriti sa o transformati in *C");
                    double F, C;
                    F = double.Parse(Console.ReadLine());
                    C = (F - 32) / 1.8;
                    Console.WriteLine("{0} *F= {1} *C", F, C);
                    break;

                case "2":
                    Console.WriteLine("Introduceti valoarea in *C pe care doriti sa o transformati in *F");
                   
                    C = double.Parse(Console.ReadLine());
                    F = C * 1.8 + 32;
                    Console.WriteLine("{0} *F= {1} *C", F, C);
                    break;

                    

            }
            Console.ReadLine();





        }
        static void p2()
        /*Să se scrie un program care efectuează mai multe operații la cererea utilizatorului, adică:
        adunare, scădere, înmulțire, împărțire, radical, modulul. (Ulilizați operatorul switch pentru
        selectarea funcției calculatorului.). După selectarea opțiunii dorite, programul trebuie să
        ceară utilizatorului introducerea datelor necesare, respectiv, în cazul adunării, scăderii,
         înmulțirii și împărțirii, două numere, iar în cazul radicalului și modulului, un singur număr.*/
        
        {
            string input;
            ;
            Console.WriteLine("1- pentru adunare");
            Console.WriteLine("2- pentru scadere");
            Console.WriteLine("3- pentru inmultire");
            Console.WriteLine("4- pentru impartire");
            Console.WriteLine("5- pentru radical");
            Console.WriteLine("6- pentru modul");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Introduceti valorile pentru adunare");
                    double x, y, r;
                    x = double.Parse(Console.ReadLine());
                    y = double.Parse(Console.ReadLine());
                    r = x + y;
                    Console.Write("{0}+{1}={2}", x, y,r);
                    break;

                case "2":
                    Console.Write("Introduceti valorile pentru scadere");
                    
                    x = double.Parse(Console.ReadLine());
                    y = double.Parse(Console.ReadLine());
                    r = x - y;
                    Console.Write("{0}-{1}={2}", x, y, r);
                    break;
                case "3":
                    Console.Write("Introduceti valorile pentru adunare");
                    x = double.Parse(Console.ReadLine());
                    y = double.Parse(Console.ReadLine());
                    r = x * y;
                    Console.WriteLine("{0}*{1}={2}", x, y, r);
                    break;
                case "4":
                    Console.Write("Introduceti valorile pentru adunare");
                    x = double.Parse(Console.ReadLine());
                    y = double.Parse(Console.ReadLine());
                    r = x /y;
                    Console.WriteLine("{0}/{1}={2}", x, y, r);
                    break;
                case "5":
                    Console.WriteLine("Introduceti valoarea: ");
                    x = double.Parse(Console.ReadLine());
                    r = Math.Sqrt(x);
                    Console.WriteLine("Radical din {0} este {1}",x,r);
                    break;
                case "6":
                    Console.WriteLine("Introduceti valoarea: ");
                    x = double.Parse(Console.ReadLine());
                    r = Math.Abs(x);
                    Console.WriteLine("Modul din {0} este {1}", x, r);
                    break;
                default:
                    Console.WriteLine("Ati introdus o valoare gresita");
                    break;
            }
            Console.ReadLine();

        }

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


            //p1();
            //p2();
            //p3();
            //p4();
            //p5();
            //p16();
            //p24();
        }
    }
}
