using System;

class MinhaClasse {
  public static void Main (string[] args) {
    string[] disponivel = Console.ReadLine().Split(" ");
    int ca = int.Parse(disponivel[0]);
    int ba = int.Parse(disponivel[1]);
    int pa = int.Parse(disponivel[2]);
    string[] requisitado = Console.ReadLine().Split(" ");
    int cr = int.Parse(requisitado[0]);
    int br = int.Parse(requisitado[1]);
    int pr = int.Parse(requisitado[2]);
    

    int numeroPizzasFaltantes = 0;
    if (ca - cr < 0)
    {
      numeroPizzasFaltantes = (ca - cr) * -1;
    }
    
    int numeroSaladasFaltantes = 0;
    if (ba - br < 0)
    {
      numeroSaladasFaltantes = (ba - br) * -1;
    }
    
    int numeroMassasFaltantes = 0;
    if (pa - pr < 0)
    {
      numeroMassasFaltantes = (pa - pr) * -1;
    }
    
    int totalRefeicoesFaltantes = numeroMassasFaltantes + numeroSaladasFaltantes + numeroPizzasFaltantes;
    
    Console.WriteLine(totalRefeicoesFaltantes);

  }
}