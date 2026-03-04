using System;
using Aula03RH.Models;

namespace Aula03RH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario   func =  new Funcionario();
            func.Id = 10;
            func.Nome = "Neymar";
            func.Cpf = "12345678910";
            func.DataAdmissao = DateTime.Parse("01/01/2010");
            func.Salario = 1000.00M;
            func.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.CLT;

            string mensagem = func.ExibirPeriodoExperiencia();
            Console.WriteLine(mensagem);
        }
    }
}
