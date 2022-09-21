using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO
{
    public class AfiseazaTaloane
    {
        public AfiseazaTaloane()
        {
            Console.Clear();
            Console.WriteLine("Afiseaza taloanele de joc participante");

            for (int i = 0; i < Globals.listaTaloane.Count; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(Globals.listaTaloane[i][j] + ",");
                }
                Console.WriteLine(" ");
                Console.WriteLine("************");
            }
        }
    }
}
