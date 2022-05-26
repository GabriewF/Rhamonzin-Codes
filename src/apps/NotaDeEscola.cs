namespace Rhamoncoders {
  class School {
    public static void Run() {
      Console.Clear();
      Console.WriteLine("Qual o seu nome?");
      var name = Console.ReadLine();

      Console.WriteLine($"{name}, digite até que numero você quer que conte automaticamente");
      var number = Convert.ToInt64(Console.ReadLine());

      for (var i = 1; i < number; i++) {
        Console.WriteLine(i);
      }

      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Saindo em 5 Segundos...");
      Console.ResetColor();
      Thread.Sleep(5000);
      Rhamoncoders.Menu.Run();
    }
  }
}