using System;

class MinhaClasse {
  public static void Main (string[] args) {
    const int quantidadeDeDiasNoAno = 365;
    const int quantidadeDeDiasNoMes = 30;
    var idadeEmDias = int.Parse(Console.ReadLine());
    var anos = idadeEmDias / quantidadeDeDiasNoAno; // Implemente aqui o calculo dos anos
    var meses = (idadeEmDias % quantidadeDeDiasNoAno) / quantidadeDeDiasNoMes; // Implemente aqui o calculo dos meses 
    var dias =  (idadeEmDias % quantidadeDeDiasNoAno) % quantidadeDeDiasNoMes; // Implemente aqui o calculo dos dias

    Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");

  }
} 