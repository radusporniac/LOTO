

namespace LOTO
{
    public class InregistrareTalon
    {

        public InregistrareTalon()
        {
            int x1, x2, x3, x4, x5, x6;

            bool existNull = false;

            List<int> list = new List<int>();

            Console.Clear();
            Console.WriteLine("Introduceti 6 numere intre 1 si 49 sau 0 pentru a reveni la ecranul anterior");

            Console.WriteLine("Primul numar: ");

            x1 = Convert.ToInt32(Console.ReadLine());
            while ((x1 < 0 || x1 > 49))
            {
                Console.WriteLine("Numerele trebuie sa fie in intervalul [0,49] si diferite");
                x1 = Convert.ToInt32(Console.ReadLine());
            }
            if (x1 == 0) { existNull = true; return; }

            list.Add(x1);

            Console.WriteLine("Al doilea numar: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            if (x2 >= 0 && x2 <= 49 && list.Contains(x2))
                x2 = 50;
            while ((x2 < 0 || x2 > 49))
            {
                Console.WriteLine("Numerele trebuie sa fie in intervalul [0,49] si diferite");
                x2 = Convert.ToInt32(Console.ReadLine());
                if (x2 >= 0 && x2 <= 49 && list.Contains(x2))
                    x2 = 50;
            }
            if (x2 == 0) { existNull = true; return; }

            list.Add(x2);

            Console.WriteLine("Al treilea numar: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            if (x3 >= 0 && x3 <= 49 && list.Contains(x3))
                x3 = 50;
            while ((x3 < 0 || x3 > 49))
            {
                Console.WriteLine("Numerele trebuie sa fie in intervalul [0,49] si diferite");
                x3 = Convert.ToInt32(Console.ReadLine());
                if (x3 >= 0 && x3 <= 49 && list.Contains(x3))
                    x3 = 50;
            }
            if (x3 == 0) { existNull = true; return; }

            list.Add(x3);

            Console.WriteLine("Al patrulea numar: ");
            x4 = Convert.ToInt32(Console.ReadLine());
            if (x4 >= 0 && x4 <= 49 && list.Contains(x4))
                x4 = 50;
            while ((x4 < 0 || x4 > 49))
            {
                Console.WriteLine("Numerele trebuie sa fie in intervalul [0,49] si diferite");
                x4 = Convert.ToInt32(Console.ReadLine());
                if (x4 >= 0 && x4 <= 49 && list.Contains(x4))
                    x4 = 50;
            }
            if (x4 == 0) { existNull = true; return; }

            list.Add(x4);

            Console.WriteLine("Al cincilea numar");
            x5 = Convert.ToInt32(Console.ReadLine());
            if (x5 >= 0 && x5 <= 49 && list.Contains(x5))
                x5 = 50;
            while ((x5 < 0 || x5 > 49))
            {
                Console.WriteLine("Numerele trebuie sa fie in intervalul [0,49] si diferite");
                x5 = Convert.ToInt32(Console.ReadLine());
                if (x5 >= 0 && x5 <= 49 && list.Contains(x5))
                    x5 = 50;
            }
            if (x5 == 0) { existNull = true; return; }

            list.Add(x5);

            Console.WriteLine("Al saselea numar: ");
            x6 = Convert.ToInt32(Console.ReadLine());
            if (x6 >= 0 && x6 <= 49 && list.Contains(x6))
                x6 = 50;
            while ((x6 < 0 || x6 > 49))
            {
                Console.WriteLine("Numerele trebuie sa fie in intervalul [0,49] si diferite");
                x6 = Convert.ToInt32(Console.ReadLine());
                if (x6 >= 0 && x6 <= 49 && list.Contains(x6))
                    x6 = 50;
            }
            if (x6 == 0) { existNull = true; return; }

            list.Add(x6);
            if (existNull == false)
            { Globals.listaTaloane.Add(list); }

        }
    }
}
