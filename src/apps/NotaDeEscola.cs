namespace Rhamoncoders {
  class School {
    public static void Run() {
      Console.WriteLine("Qual o seu nome?");
      var name = Console.ReadLine();
      
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Saindo em 5 Segundos...");
      Console.ResetColor();
      Thread.Sleep(5000);
      Rhamoncoders.Menu.Run();
    }
  }
}