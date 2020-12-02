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
        anonimo.Setsalario(anonimo.Salario);
        chave = false;
      }

      catch
      {
        Console.WriteLine("Salário Invalido, tente novamente.");
        chave = true;
      }
    }
    while(chave);

    Console.Write("Valor novo do salário R$");
    anonimo.Salario = double.Parse(Console.ReadLine());

    anonimo.Setsalario(Empregado.aumentaSalario(anonimo.Getsalario()));

    Console.WriteLine("Novo Salário R${0}",anonimo.Getsalario());
    
    
  }
}