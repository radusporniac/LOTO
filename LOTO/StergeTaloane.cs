using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO
{
    public class StergeTaloane
    {

        public StergeTaloane()
        {
            Console.Clear();
            Console.WriteLine("Sunteti sigur ca vreti sa stergeti taloanele existente?(d/n)");

            string raspuns = Convert.ToString(Console.ReadLine());

            if (raspuns == "d")
            {
                Globals.listaTaloane = new List<List<int>>();
            }

        }

    }
}
