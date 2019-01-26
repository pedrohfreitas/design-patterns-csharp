using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente funcionarioPermanente = new FuncionarioPermanente();
            funcionarioPermanente.Nome = "João";
            funcionarioPermanente.Idade = 31;
            funcionarioPermanente.Tipo = "Permanente";

            FuncionarioPermanente cloneFuncionarioPermanente = (FuncionarioPermanente)funcionarioPermanente.Clone();
            cloneFuncionarioPermanente.Nome = "Carlos";
            cloneFuncionarioPermanente.Idade = 40;

            Console.WriteLine("Detalhamento do funcionado permanente:");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2};", funcionarioPermanente.Nome, funcionarioPermanente.Idade.ToString(), funcionarioPermanente.Tipo);

            Console.WriteLine("Detalhamento do funcionado permanente CLONE:");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2};", cloneFuncionarioPermanente.Nome, cloneFuncionarioPermanente.Idade.ToString(), cloneFuncionarioPermanente.Tipo);

            Console.ReadKey();
        }
    }
}
