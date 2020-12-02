using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) 
  {
    Empregado anonimo = new Empregado("Nomade", "Anonimo", 1500);

    //Console.WriteLine(anonimo);

    bool chave = true;

    do
    {
      try
      {
        Console.Write("Digite o Salário: R$" );
        anonimo.Salario = double.Parse(Console.ReadLine());
        chave = false;
      }

      catch
      {
        Console.WriteLine("Salário Invalido, tente novamente.");
        chave = true;
      }
    }
    while(chave);
    
    
  }
}