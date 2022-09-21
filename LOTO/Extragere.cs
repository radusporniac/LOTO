using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO
{
    public class Extragere
    {
        private IEnumerable<int> commonList;

        public Extragere()
        {
            Console.Clear();
            Console.WriteLine("Demarati extragerea numerelor castigatoare?(d/n)");

            string raspuns = Convert.ToString(Console.ReadLine());

            if (raspuns == "d")
            {
                Console.WriteLine("Incepe extragerea numerelor castigatoare");
                Random r = new Random();

                for (int i = 0; i < 6; i++)
                {
                    int nr = r.Next(1, 49);
                    Globals.nrExtrase.Add(nr);
                    Console.Write(nr + ",");
                }

                Console.WriteLine(" ");

                List<int> taloane6 = new List<int>();
                List<int> taloane5 = new List<int>();
                List<int> taloane4 = new List<int>();

                for (int i = 0; i < Globals.listaTaloane.Count; i++)
                {
                    commonList = Globals.listaTaloane[i].Intersect(Globals.nrExtrase);
                    int x = commonList.Count();
                    if (x == 6) { taloane6.Add(i); }
                    if (x == 5) { taloane5.Add(i); }
                    if (x == 4) { taloane4.Add(i); }
                }

                Console.WriteLine(taloane6.Count() + "taloane au nimerit 6 cifre");

                Console.WriteLine(taloane5.Count() + "taloane au nimerit 5 cifre");

                Console.WriteLine(taloane4.Count() + "taloane au nimerit 4 cifre");


                Console.WriteLine("Doriti sa vedeti rezultatele pentru toate taloanele?(d/n)");

                raspuns = Convert.ToString(Console.ReadLine());

                if (raspuns == "d")
                {

                    for (int i = 0; i < Globals.listaTaloane.Count; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (Globals.nrExtrase.Contains(Globals.listaTaloane[i][j]))
                                Console.Write("G" + Globals.listaTaloane[i][j] + ",");
                            else
                                Console.Write(Globals.listaTaloane[i][j] + ",");
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("************");
                    }

                }

            }

        }
    }




}

