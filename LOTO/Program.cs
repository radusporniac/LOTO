using LOTO;


int optiune = 0;
int numarTaloane;


while (optiune != 6)
{

    Start s = new Start();
    
    Console.WriteLine("Optiunea dumneavoastra: ");
    optiune = Convert.ToInt32(Console.ReadLine());

    if (optiune == 1)
    {
        InregistrareTalon inregistrareTalon = new InregistrareTalon();
    }
    if (optiune == 2)
    {
        GenereazaTaloane genereazaTaloane = new GenereazaTaloane();
    }
    if (optiune == 3)
    { 
        AfiseazaTaloane afiseazaTaloane = new AfiseazaTaloane();
    }
    if(optiune == 4)
    {
        Extragere extragere = new Extragere();
    }
    if(optiune == 5)
    {
        StergeTaloane stergeTaloane = new StergeTaloane();
    }
   



}