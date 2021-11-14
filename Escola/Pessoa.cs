using System;
using System.Collections.Generic;

namespace Escola
{
  public abstract class Pessoa
  {
    private string matricula;
    public string Matricula
    {
      get { return matricula; }
      set { matricula = value; }
    }
    private string nome;
    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }
    private int idade;
    public int Idade
    {
      get { return idade; }
      set { idade = value; }
    }
    private char sexo;
    public char Sexo
    {
      get { return sexo; }
      set { sexo = value; }
    }
  }
}
