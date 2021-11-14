using System;
using System.Collections.Generic;

namespace Escola
{
  class Professor : Pessoa, IPessoa
  {
    private string nmateria;
    public string NMateria
    {
      get { return nmateria; }
      set { nmateria = value; }
    }

    public void Cadastrar()
    {
      Console.Write("Digite a matricula: ");
      this.Matricula = Console.ReadLine();
      Console.Write("Digite o nome: ");
      this.Nome = Console.ReadLine();
      Console.Write("Digite a idade: ");
      this.Idade = int.Parse(Console.ReadLine());
      Console.Write("Digite a sexo: ");
      this.Sexo = char.Parse(Console.ReadLine());
      Console.Write("Digite a matéria: ");
      this.NMateria = Console.ReadLine();
      Console.WriteLine("-----------");
    }
    public void Listar()
    {
      Console.Write(this.Matricula + " - ");
      Console.WriteLine(this.Nome);
      Console.WriteLine("----------");
    }
  }
}
