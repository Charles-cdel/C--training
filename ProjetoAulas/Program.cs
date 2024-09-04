using System;

namespace Application
{
    public class Program
    {
        static void Main (string[] args)
        { 
            //AulaClasses();
            //AulaHeranca();
            ClasseSelada();
        }

        private static void AulaClasses(){

            /*var resultado = Cadastro.Calculos.SomarNumeros(3, 5);
            Console.WriteLine(resultado);

            /var produto = new Cadastro.Produto();
            produto.SetId(1);


            produto.Descricao = "Teclado";

            produto.ImpimirDescricao();
            Console.WriteLine(produto.GetId());*/
        }

        private static void AulaPropriedadeSomenteLeitura(){

            /*var produto = new Cadastro.Produto();
            produto.Descricao = "Mouse"
            Console.WriteLine();*/

            
        }


        private static void AulaHeranca()
        {
            /*var pessoaFisica = new Cadastro.PessoaFisica();
            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Endereco Teste";
            pessoaFisica.Cidade = "Cidade Teste";
            pessoaFisica.Cep = "123456788912";
            pessoaFisica.CPF = "07562991367";

            pessoaFisica.ImpimirDados();
            pessoaFisica.ImpimirCpf();*/

            /*var funcionario = new Cadastro.Funcionario();
            funcionario.Id = 19;
            funcionario.Endereco = "Endereco Teste";
            funcionario.Cidade = "Cidade Teste";
            funcionario.Cep = "123456788912";
            funcionario.CPF = "07562991367";

            funcionario.ImpimirDados();
            funcionario.ImpimirCpf();*/
        }

        public static void ClasseSelada()
        {
            /*var configuracao = new Cadastro.Configuracao();
            configuracao.Host = "localhost";*/

            var configuracao = new Cadastro.Configuracao
            {
                Host = "localhost"
            };

            Console.WriteLine(configuracao.Host);

        }

    }
}