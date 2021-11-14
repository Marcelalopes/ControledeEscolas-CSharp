using System;
using System.Collections.Generic;

namespace Escola
{
  class Materia : IPessoa
  {
    private string nome;
    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }

    private string hr_i;
    public string Horai
    {
      get { return hr_i; }
      set { hr_i = value; }
    }
    private string hr_f;
    public string Horaf
    {
      get { return hr_f; }
      set { hr_f = value; }
    }
    List<string> dias = new List<string>();


    public void Cadastrar()
    {
      Console.Write("Nome da matéria: ");
      this.Nome = Console.ReadLine();
      Console.Write("Horário de início: ");
      this.Horai = Console.ReadLine();
      Console.Write("Horário final: ");
      this.Horaf = Console.ReadLine();
      char op = 'S';
      do
      {
        Console.Write("Dias da semana que tem aula: ");
        dias.Add(Console.ReadLine());
        Console.Write("Deseja cadastrar mais um dia? ");
        op = char.Parse(Console.ReadLine());
      } while (op != 'N');

    }
    public void Listar()
    {
      Console.WriteLine("Matéria: " + this.Nome);
      Console.Write("Dias da semana: ");
      foreach (var i in dias)
      {
        Console.Write(i + " ");
      }
      Console.WriteLine("\n");
      Console.WriteLine("----------");
    }
  }
}
