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

  public void Setsobrenome(string sn)
  {
    Sobrenome = sn;
  }

  public double Getsalario()
  {
    return Salario;
  }

  public void Setsalario(double s)
  {
    if(s<=0)
    {
      throw new Exception("Salário Invalido"); 
      
    }

    else
    {
      Salario = s;
    }

  }

  public Empregado(string n, string sn, double s)
  {
    Nome = n;
    Sobrenome = sn;
    Salario = s;
  }

  public Empregado()
  {
    Nome = "Nomade";
    Sobrenome = "Anonimo";
    Salario = 1000;
  }

  

}