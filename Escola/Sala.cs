using System;
using System.Collections.Generic;

namespace Escola
{
  class Sala : IPessoa
  {
    private int num;
    public int Numero
    {
      get { return num; }
      set { num = value; }
    }
    private string matricula_professor;
    public string MAtricula
    {
      get { return matricula_professor; }
      set { matricula_professor = value; }
    }
    List<string> alunos = new List<string>();

    public void Cadastrar()
    {
      Console.Write("Número da sala: ");
      this.Numero = int.Parse(Console.ReadLine());
      Console.Write("Qual professor da aula nessa sala? Digite a matricula: ");
      this.MAtricula = Console.ReadLine();
      Console.Write("Alunos dessa sala: ");
      char op = 'S';
      do
      {
        Console.Write("Digite a matricula do aluno: ");
        alunos.Add(Console.ReadLine());
        Console.Write("Deseja cadastrar mais um aluno?(S/N) ");
        op = char.Parse(Console.ReadLine());
      } while (op != 'N');
    }
    public void Listar()
    {
      Console.WriteLine("Nº da sala: " + this.Numero);
    }
  }
}
