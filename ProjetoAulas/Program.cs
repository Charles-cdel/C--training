using System;
using System.Data.Common;

namespace Application
{
    public class Program
    {
        static void Main (string[] args)
        { 
            //AulaClasses();
            //AulaHeranca();
            //ClasseSelada();
            //AulaRecord();
            //AulaInterface();
            //Conversores();
            //TrabalhandoComStrings();
            //TrabalhandoComDatas();
            TrabalhandoComExcecoes();
        }

        private static void TrabalhandoComExcecoes()
        {
            var trabalhandoComExcecoes = new Modulo12.TrabalhandoComExceptions();
            //trabalhandoComExcecoes.GerandoException();
            trabalhandoComExcecoes.ResolvendoException();
        }
        private static void TrabalhandoComDatas()
        {
            var trabalhandoComDatas = new Modulo11.TrabalhandoComDatas();
            //trabalhandoComDatas.Data();
            //trabalhandoComDatas.SubtraindoDatas();
            //trabalhandoComDatas.AddDiaMesAno();
            //trabalhandoComDatas.AddHoraMinSegundos();
            //trabalhandoComDatas.Resource();
            //trabalhandoComDatas.SomenteData();
            trabalhandoComDatas.SomenteHora();
        }

        private static void TrabalhandoComStrings()
        {
            var trabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
            //trabalhandoComStrings.ConverterLetrasMinusculas();
            //trabalhandoComStrings.ConverterLetrasMaiusculas();
            //trabalhandoComStrings.Substring();
            //trabalhandoComStrings.Range();
            //trabalhandoComStrings.Contains();
            //trabalhandoComStrings.Trim();
            //trabalhandoComStrings.StartsWithEndsWith();
            //trabalhandoComStrings.Replace();
            //trabalhandoComStrings.Length();
        }

        private static void Conversores()
        {
            var conversores = new Conversores.Conversor();
            //conversores.ConvertAndParse();
            conversores.TryParse();
        }

        private static void AulaInterface()
        {
            var notificacaoCliente = new Cadastro.NotficacaoCliente();
            notificacaoCliente.Notificar();

            Cadastro.INotificacao notificacao = new Cadastro.NotficacaoFuncionario();
            notificacao.Notificar();
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
            configuracao.Host = "localhost";

            var configuracao = new Cadastro.Configuracao
            {
                Host = "localhost"
            };

            Console.WriteLine(configuracao.Host);

        }

        private static void AulaRecord()
        {
            /*var curso1 = new Cadastro.Curso{Id = 1, Descricao = "Curso"};

            var curso2 = new Cadastro.Curso{Id = 1, Descricao = "Curso"};

            Console.WriteLine(curso1.Equals(curso2));
            Console.WriteLine(curso1 == curso2);

            var curso1 = new Cadastro.Curso(1 , "Curso");
            var curso2 = curso1 with {Descricao = "Saudades"};

            /*var curso1 = new Cadastro.CursoTeste {Id = 1, Descricao = "Curso"};
            var curso2 = new Cadastro.CursoTeste ();
            curso2.Id = curso1.Id;
            curso2.Descricao = "Saudades";

            

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);



        }*/

    }
}   
}