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
    public void Comer(string primeiroTalher)
    {
        Console.WriteLine("\n-- Filosofo 1 quer comer --");
        Console.WriteLine("Filosofo 1 esta pensando...");
        MostrarMesa();

        if (garfoNaMesa == true && facaNaMesa == true)
        {

            if (primeiroTalher == "faca")
            {
                facaNaMesa = false;
                Console.WriteLine("Filosofo 1 pegou a faca primeiro");
                garfoNaMesa = false;
                Console.WriteLine("Filosofo 1 pegou o garfo em seguida");
            }
            else
            {
                garfoNaMesa = false;
                Console.WriteLine("Filosofo 1 pegou o garfo primeiro");
                facaNaMesa = false;
                Console.WriteLine("Filosofo 1 pegou a faca em seguida");
            }

            Console.WriteLine("Filosofo 1 esta comendo...");

            facaNaMesa = true;
            garfoNaMesa = true;
            Console.WriteLine("Filosofo 1 devolveu os talheres");
            Console.WriteLine("Filosofo 1 voltou a pensar");
            Console.WriteLine("\n>>> O Filosofo 1 comeu! <<<");
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
    public void Comer(string primeiroTalher)
    {
        Console.WriteLine("\n-- Filosofo 2 quer comer --");
        Console.WriteLine("Filosofo 2 esta pensando...");
        MostrarMesa();

        if (garfoNaMesa == true && facaNaMesa == true)
        {
            // Pega o talher escolhido primeiro
            if (primeiroTalher == "faca")
            {
                facaNaMesa = false;
                Console.WriteLine("Filosofo 2 pegou a faca primeiro");
                garfoNaMesa = false;
                Console.WriteLine("Filosofo 2 pegou o garfo em seguida");
            }
            else
            {
                garfoNaMesa = false;
                Console.WriteLine("Filosofo 2 pegou o garfo primeiro");
                facaNaMesa = false;
                Console.WriteLine("Filosofo 2 pegou a faca em seguida");
            }

            Console.WriteLine("Filosofo 2 esta comendo...");

            facaNaMesa = true;
            garfoNaMesa = true;
            Console.WriteLine("Filosofo 2 devolveu os talheres");
            Console.WriteLine("Filosofo 2 voltou a pensar");
            Console.WriteLine("\n>>> O Filosofo 2 comeu! <<<");
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

        while (true)
        {

            Console.WriteLine("\n==============================");
            Console.WriteLine("   PROBLEMA DOS FILOSOFOS");
            Console.WriteLine("==============================");
            Console.WriteLine("Quem vai comer primeiro?");
            Console.WriteLine("1 - Filosofo 1");
            Console.WriteLine("2 - Filosofo 2");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("==============================");
            Console.Write("Escolha: ");
            string escolhaFilosofo = Console.ReadLine();

            if (escolhaFilosofo == "0")
            {
                Console.WriteLine("\nEncerrando o programa. Ate logo!");
                break;
            }

            if (escolhaFilosofo != "1" && escolhaFilosofo != "2")
            {
                Console.WriteLine("Opcao invalida! Tente novamente.");
                continue;
            }

            Console.WriteLine("\nQual talher pegar primeiro?");
            Console.WriteLine("1 - Faca");
            Console.WriteLine("2 - Garfo");
            Console.Write("Escolha: ");
            string escolhaTalher = Console.ReadLine();

            if (escolhaTalher != "1" && escolhaTalher != "2")
            {
                Console.WriteLine("Opcao invalida! Tente novamente.");
                continue;
            }

            string primeiroTalher = (escolhaTalher == "1") ? "faca" : "garfo";


            if (escolhaFilosofo == "1")
            {
                Console.WriteLine("\n--- Vez do Filosofo 1 ---");
                f1.Comer(primeiroTalher);

                Console.WriteLine("\n--- Agora a vez do Filosofo 2 ---");
                f2.Comer(primeiroTalher);
            }
            else
            {
                Console.WriteLine("\n--- Vez do Filosofo 2 ---");
                f2.Comer(primeiroTalher);

                Console.WriteLine("\n--- Agora a vez do Filosofo 1 ---");
                f1.Comer(primeiroTalher);
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}