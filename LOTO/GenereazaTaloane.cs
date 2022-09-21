using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO
{
    public class GenereazaTaloane
    {
        public GenereazaTaloane()
        {
            Console.Clear();
            Console.WriteLine("Introduceti cate taloane doriti sa generati sau 0 pentru a reveni la ecranul anterior");
            int numarTaloane = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            List<int> listaTaloaneGenerate = new List<int>();
            for (int i = 0; i < numarTaloane; i++)
            {
                listaTaloaneGenerate.Clear();

                for (int j = 0; j < 6; j++)
                {
                    int x = r.Next(1, 49);
                    while (listaTaloaneGenerate.Contains(x))
                        x = r.Next(1, 49);
                    listaTaloaneGenerate.Add(x);
                }    
                    
                Globals.listaTaloane.Add(listaTaloaneGenerate);
            }
            
        }
    }
}
