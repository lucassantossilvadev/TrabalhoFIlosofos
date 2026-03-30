using System;

class Filosofos
{
    protected static bool garfoNaMesa = true;
    protected static bool facaNaMesa = true;

    protected static void MostrarMesa()
    {
        Console.WriteLine("Mesa -> Garfo: " + (garfoNaMesa ? "disponivel" : "em uso") +
                          " | Faca: " + (facaNaMesa ? "disponivel" : "em uso"));
    }
}

class FilosofosUm : Filosofos
{
    public void Comer()
    {
        Console.WriteLine("\n-- Filosofo 1 quer comer --");
        Console.WriteLine("Filosofo 1 esta pensando...");

        MostrarMesa();


        if (garfoNaMesa == true && facaNaMesa == true)
        {

            facaNaMesa = false;
            Console.WriteLine("Filosofo 1 pegou a faca");


            garfoNaMesa = false;
            Console.WriteLine("Filosofo 1 pegou o garfo");

            Console.WriteLine("Filosofo 1 esta comendo...");


            facaNaMesa = true;
            garfoNaMesa = true;
            Console.WriteLine("Filosofo 1 devolveu os talheres");
            Console.WriteLine("Filosofo 1 voltou a pensar");
        }
        else
        {
            Console.WriteLine("Filosofo 1 nao pode comer, talheres em uso!");
        }

        MostrarMesa();
    }
}

class FilosofosDois : Filosofos
{
    public void Comer()
    {
        Console.WriteLine("\n-- Filosofo 2 quer comer --");
        Console.WriteLine("Filosofo 2 esta pensando...");

        MostrarMesa();


        if (garfoNaMesa == true && facaNaMesa == true)
        {

            facaNaMesa = false;
            Console.WriteLine("Filosofo 2 pegou a faca");


            garfoNaMesa = false;
            Console.WriteLine("Filosofo 2 pegou o garfo");

            Console.WriteLine("Filosofo 2 esta comendo...");


            facaNaMesa = true;
            garfoNaMesa = true;
            Console.WriteLine("Filosofo 2 devolveu os talheres");
            Console.WriteLine("Filosofo 2 voltou a pensar");
        }
        else
        {
            Console.WriteLine("Filosofo 2 nao pode comer, talheres em uso!");
        }

        MostrarMesa();
    }
}

class TrabalhoFilosofos
{
    static void Main(string[] args)
    {
        FilosofosUm f1 = new FilosofosUm();
        FilosofosDois f2 = new FilosofosDois();


        Console.WriteLine("==============================");
        Console.WriteLine("CASO 1: F1 comeu");
        Console.WriteLine("==============================");
        f1.Comer();


        Console.WriteLine("\n==============================");
        Console.WriteLine("CASO 2: F2 comeu");
        Console.WriteLine("==============================");
        f2.Comer();


        Console.WriteLine("\n==============================");
        Console.WriteLine("CASO 3: F2 e F1 comeram");
        Console.WriteLine("==============================");
        f2.Comer();
        f1.Comer();


        Console.WriteLine("\n==============================");
        Console.WriteLine("CASO 4: F1 e F2 comeram");
        Console.WriteLine("==============================");
        f1.Comer();
        f2.Comer();

        Console.WriteLine("\n==============================");
        Console.WriteLine("Fim do programa");
        Console.WriteLine("==============================");
    }
}
