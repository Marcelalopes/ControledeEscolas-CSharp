using System;
using System.Collections.Generic;

namespace Escola
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("MENU");
      Console.WriteLine("1 - Cadastrar Alunos");
      Console.WriteLine("2 - Cadastrar Matérias");
      Console.WriteLine("3 - Cadastrar Professores");
      Console.WriteLine("4 - Cadastrar Salas");
      Console.WriteLine("5 - Cadastrar Escolas");
      Console.WriteLine("6 - Listar Escolas");
      Console.WriteLine("7 - Listar Professores");
      Console.WriteLine("8 - Listar Salas");
      Console.WriteLine("9 - Listar Matérias");
      Console.WriteLine("10 - Listar Alunos");
      Console.WriteLine("11 - Sair");
      Console.WriteLine("--------------------");

      Console.Write("Escolha uma opção: ");
      int op = int.Parse(Console.ReadLine());

      List<Escola> eList = new List<Escola>();
      List<Aluno> aList = new List<Aluno>();
      List<Professor> pList = new List<Professor>();
      List<Materia> mList = new List<Materia>();
      List<Sala> sList = new List<Sala>();

      do
      {
        switch (op)
        {
          case 1:
            Console.WriteLine("---Cadastro de Alunos---");
            char y = 'S';
            do
            {
              Aluno a = new Aluno();
              a.Cadastrar();
              aList.Add(a);
              Console.Write("Deseja cadastrar um novo aluno? (S/N) ");
              y = char.Parse(Console.ReadLine());
            } while (y != 'N');
            break;
          case 2:
            Console.WriteLine("---Cadastro de Matérias---");
            char b = 'S';
            do
            {
              Materia m = new Materia();
              m.Cadastrar();
              mList.Add(m);
              Console.Write("Deseja cadastrar uma nova materia? (S/N) ");
              b = char.Parse(Console.ReadLine());
            } while (b != 'N');
            break;
          case 3:
            Console.WriteLine("---Cadastro de Professores---");
            char z = 'S';
            do
            {
              Professor p = new Professor();
              p.Cadastrar();
              pList.Add(p);
              Console.Write("Deseja cadastrar um novo professsor? (S/N) ");
              z = char.Parse(Console.ReadLine());
            } while (z != 'N');
            break;
          case 4:
            Console.WriteLine("---Cadastro de Salas---");
            char c = 'S';
            do
            {
              Sala s = new Sala();
              s.Cadastrar();
              sList.Add(s);
              Console.Write("Deseja cadastrar uma nova sala? (S/N) ");
              c = char.Parse(Console.ReadLine());
            } while (c != 'N');
            break;

          case 5:
            Console.WriteLine("---Cadastro de Escolas---");
            char x = 'S';
            do
            {
              Escola e = new Escola();
              e.Cadastrar();
              eList.Add(e);
              Console.Write("Deseja cadastrar uma nova escola? (S/N) ");
              x = char.Parse(Console.ReadLine());
            } while (x != 'N');
            break;
          case 6:
            Console.WriteLine("---Lista de Escolas---");
            foreach (var i in eList)
            {
              i.Listar();
            }
            Console.ReadKey();
            break;
          case 7:
            Console.WriteLine("---Lista de Professores---");
            foreach (var i in pList)
            {
              i.Listar();
            }
            Console.ReadKey();
            break;
          case 8:
            Console.WriteLine("---Lista de Salas---");
            foreach (var i in sList)
            {
              i.Listar();
            }
            Console.ReadKey();
            break;
          case 9:
            Console.WriteLine("---Lista de Matérias---");
            foreach (var i in mList)
            {
              i.Listar();
            }
            Console.ReadKey();
            break;
          case 10:
            Console.WriteLine("---Lista de Alunos---");
            foreach (var i in aList)
            {
              i.Listar();
            }
            Console.ReadKey();
            break;
          default:
            Console.WriteLine("Opção Inválida");
            break;
        }
        Console.WriteLine("MENU");
        Console.WriteLine("1 - Cadastrar Alunos");
        Console.WriteLine("2 - Cadastrar Matérias");
        Console.WriteLine("3 - Cadastrar Professores");
        Console.WriteLine("4 - Cadastrar Salas");
        Console.WriteLine("5 - Cadastrar Escolas");
        Console.WriteLine("6 - Listar Escolas");
        Console.WriteLine("7 - Listar Professores");
        Console.WriteLine("8 - Listar Salas");
        Console.WriteLine("9 - Listar Matérias");
        Console.WriteLine("10 - Listar Alunos");
        Console.WriteLine("11 - Sair");
        Console.WriteLine("--------------------");

        Console.Write("Escolha uma opção: ");
        op = int.Parse(Console.ReadLine());
      } while (op != 11);
      Console.WriteLine("Fim do Programa");
    }
  }
}

