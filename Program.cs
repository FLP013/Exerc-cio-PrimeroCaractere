string Digitacao;

Console.Clear();

Console.WriteLine("--- PRIMEIRO CARCTERE ---");

Console.Write("Digite algo: ");
Digitacao = Console.ReadLine()!;

Console.WriteLine(Digitacao.Trim().Substring(0,1));