namespace Rhamoncoders {
  class Bielnator {
    public static void Run() {
      // Perguntas
      Console.Clear();
      Console.WriteLine("Qual seu nome?");
      var name = Console.ReadLine();
      Console.WriteLine($"Então, {name}, em que ano nós estamos?");
      var year = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"Nossa! já estamos em {year}, mas em que ano você nasceu?");
      var birthDate = Convert.ToInt32(Console.ReadLine());

      // Verificações
      var age = year - birthDate;
      if (age <= 18) {
        Console.WriteLine($"{name}, infelizmente você não tem idade para acessar esse sistema.");
        Environment.Exit(0);
      }

      Console.WriteLine($"Muito bem, {name}, você tem {age} anos, {name}");
      Console.Write($"Muito bem, {name}, digite o tamanho do Biel: ");
      var bielSize = Convert.ToInt32(Console.ReadLine());

      if (bielSize <= 5) {
        Console.WriteLine("Esse numero é inferior ao tamanho do Biel, mais é ida e volta? tem quanto?");
        var bielSizeAgain = Convert.ToInt32(Console.ReadLine());

        if (bielSizeAgain <= 5 || bielSizeAgain >= 13) {
          Console.WriteLine($"Vish, {name}, é menor do que eu imaginava");
          Environment.Exit(0);
        }
      }

      Console.WriteLine($"Oloko, {name} então tá otimo!");
      Console.WriteLine($"Biel é super dotado, só não é mais dotado do que você {name}!");
      
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Saindo em 5 Segundos...");
      Console.ResetColor();
      Thread.Sleep(5000);
      Rhamoncoders.Menu.Run();
    }
  }
}