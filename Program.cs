
Menu();

static void Menu() {

    Console.Clear();
    Console.WriteLine("#######################################");
    Console.WriteLine("Olá! Bem vindo ao Contagem Regressiva.");
    Console.WriteLine("");
    Console.WriteLine("Abaixo está as instruções de como informar o tempo a ser contado.");
    Console.WriteLine("S - Segundos. Ex. 10s -> 10 segundos;");
    Console.WriteLine("M - Minuto. Ex. 1m -> 1 minuto;");
    Console.WriteLine("0s - Sair");
    Console.WriteLine("########################################");
    Console.WriteLine("");
    Console.WriteLine("Quanto tempo deseja contar?");

   string data = Console.ReadLine().ToLower();
   char type = char.Parse(data.Substring(data.Length-1, 1));
   int time = int.Parse(data.Substring(0,data.Length -1));
   int multiplier = 1;

    if (type == 'm')
        multiplier = 60;

    if (time == 0)
    System.Environment.Exit(0);

    PreStart(time * multiplier);
}

static void PreStart(int time) {

    Console.Clear();
    Console.WriteLine("Preparar...");
    Console.Beep();
    Console.WriteLine("");
    Thread.Sleep(2000);
    Console.WriteLine("Apontar...");
    Console.Beep();
    Console.WriteLine("");
    Thread.Sleep(2000);
    Console.WriteLine("Valendo!!!");
    Console.Beep();
    Thread.Sleep(400);

    Start(time);
}

static void Start(int time) {

    int currentTime = 0;

    while (currentTime != time) {

        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Console.Beep();
        Thread.Sleep(1000);
    }

    Console.Clear();

    Alarme();
    Console.WriteLine("Relógio finalizado");
    Thread.Sleep(3000);
    Menu();
}

static void Alarme () {

    Console.Beep(332, 1000);
    Console.Beep(448, 1000);
    Console.Beep(565, 1200);
    Thread.Sleep(800);

}