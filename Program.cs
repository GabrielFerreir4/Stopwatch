namespace stopwatch;
class Program
{
    static void Main(string[] args)
    {
        Menu();
        //Start(6); //vai contar até 6 porque é o parametro referente a time
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("S = Segundo => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 1m = 1 minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();  //ToLower deixa todas letras minúsculas
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;
        if (type == 'm')
            multiplier = 60;
        if (time == 0)
            System.Environment.Exit(0);

        PreStart(time * multiplier);
    }


    static void PreStart(int time)
    {
        Console.Clear();
        System.Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        System.Console.WriteLine("Set...");
        Thread.Sleep(1000);
        System.Console.WriteLine("Go!...");
        Thread.Sleep(2500);
        Start(time);
    }
    static void Start(int time)
    {
        int currentTime = 0;
        while (currentTime != time)
        {
            Console.Clear();
            currentTime++; // cada vez que executar o loop aumenta 1 numero no currentTime 
            Console.WriteLine(currentTime);
            Thread.Sleep(1000); // o while vai demorar 1 segundo antes de ir pro proximo loop
        }
        Console.Clear();
        Console.WriteLine("Stopwatch finalizado");
        Thread.Sleep(2500);
        Menu();
    }
}
