namespace Rhamoncoders
{
  class Menu
  {
    public static void Run()
    {
      // Messages
      Console.Clear();
      Console.WriteLine();
      Console.WriteLine("  BEM VINDO ao RHAMON CODERS!");
      Console.WriteLine("  Basicamente esse Aplicativo é um conjunto de outros aplicativos...");
      Console.WriteLine();
      Console.WriteLine("  Escolha qual aplicativo deseja executar...");
      Console.WriteLine("  Digite CRTL + C para sair!");
      Console.WriteLine();
      Console.WriteLine("  1 - Bielnator");
      Console.WriteLine("  2 - Nota de escola");
      Console.WriteLine();
      Console.Write("  >>> ");
      var selectedApplication = Console.ReadLine();

      // Logic
      switch (selectedApplication)
      {
        case "1":
          {
            Rhamoncoders.Bielnator.Run();
            break;
          };
        case "2":
          {
            Rhamoncoders.School.Run();
            break;
          }
        default:
          {
            Console.WriteLine("Aplicativo invalido");
            break;
          }
      }
    }
  }
}