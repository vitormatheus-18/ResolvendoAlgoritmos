using System;

class MinhaClasse {
  public static void Main (string[] args) {
   int totalEmSegundos = int.Parse(Console.ReadLine());

   int tempoEmHoras = totalEmSegundos / 3600;

   int tempoEmMinutos = (totalEmSegundos % 3600) / 60;

   int tempoEmSegundos = (totalEmSegundos % 3600) % 60;

    Console.Write($"{tempoEmHoras}:{tempoEmMinutos}:{tempoEmSegundos}");

  }
}