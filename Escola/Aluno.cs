using System;
using System.Collections.Generic;

namespace Escola
{
  class Aluno : Pessoa, IPessoa
  {
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
      Console.WriteLine("--------");
    }
    public void Listar()
    {
      Console.Write(this.Matricula + " - ");
      Console.WriteLine(this.Nome);
      Console.WriteLine("----------");
    }
  }
}
