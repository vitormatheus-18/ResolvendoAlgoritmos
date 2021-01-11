using System;

class MinhaClasse {
  public static void Main (string[] args) {
    var minutosRestantes = int.Parse(Console.ReadLine());
    string[] entrada = Console.ReadLine().Split(" ");
    int minutosParaFazerPresenteA = int.Parse(entrada[0]);
    int minutosParaFazerPresenteB = int.Parse(entrada[1]);
    

    int tempoTotalDeFabricacao = minutosParaFazerPresenteA + minutosParaFazerPresenteB;
    
    if (tempoTotalDeFabricacao > minutosRestantes)
      Console.WriteLine("Deixa para amanha!");
    else
      Console.WriteLine("Farei hoje!");

  }
}