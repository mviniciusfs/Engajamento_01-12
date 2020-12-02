using System;

class Empregado
{
  public string Nome;
  public string Sobrenome;
  public double Salario;

  public string Getnome()
  {
    return Nome;
  }

  public string Getsobrenome()
  {
    return Sobrenome;
  }

  public double Getsalario()
  {
    return Salario;
  }

  public Dados(string n, string sn, double s)
  {
    Nome = n;
    Sobrenome = sn;
    Salario = s;
  }

}