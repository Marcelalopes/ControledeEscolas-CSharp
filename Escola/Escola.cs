using System;
using System.Collections.Generic;

namespace Escola
{
  class Escola : IPessoa
  {
    private int id;
    public int IdEscola
    {
      get { return id; }
      set { id = value; }
    }

    private string nome;
    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }
    Dictionary<string, string> professores = new Dictionary<string, string>();
    Dictionary<string, string> alunos = new Dictionary<string, string>();
    List<int> salas = new List<int>();
    public void Cadastrar()
    {
      Console.Write("Id da escola: ");
      this.IdEscola = int.Parse(Console.ReadLine());
      Console.Write("Nome da escola: ");
      this.Nome = Console.ReadLine();
      Console.WriteLine("---Matricular Alunos---");
      char op = 'S';
      do
      {
        Console.WriteLine("Digite a matricula e depois o nome do aluno q deseja matricular");
        alunos.Add(Console.ReadLine(), Console.ReadLine());
        Console.Write("Deseja matricular um novo aluno? (S/N) ");
        op = char.Parse(Console.ReadLine());
      } while (op != 'N');
      op = 'S';
      Console.WriteLine("---Matricular Professores---");
      do
      {
        Console.WriteLine("Digite a matricula e depois o nome do professor que deseja matricular");
        professores.Add(Console.ReadLine(), Console.ReadLine());
        Console.Write("Deseja matricular um novo professor? (S/N) ");
        op = char.Parse(Console.ReadLine());
      } while (op != 'N');
      op = 'S';
      Console.WriteLine("---Adicionar Salas---");
      do
      {
        Console.WriteLine("Número da sala que deseja adicionar");
        salas.Add(int.Parse(Console.ReadLine()));
        Console.WriteLine("Deseja adicionar uma nova sala? (S/N) ");
        op = char.Parse(Console.ReadLine());
      } while (op != 'N');
    }
    public void Listar()
    {
      Console.WriteLine("Id: " + this.IdEscola);
      Console.WriteLine("Nome: " + this.Nome);
    }
  }
}