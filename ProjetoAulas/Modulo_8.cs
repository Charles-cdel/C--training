using System.Collections;
using System.Data.Common;

namespace Cadastro
{
    public static class Calculos
    {
        public static int SomarNumeros (int a , int b){
            return a + b;
        }
    }
    public class Produto

    {
        private int Id;

        public string Descricao {get; set;}

        //public readonly int Estoque;

        public int Estoque {get;}


        public Produto()
        {
            Estoque = 1;
        }


        public void ImpimirDescricao()
        {
            Console.WriteLine(GetId()+ " - "  + Descricao);
        }

        public void SetId (int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }

    public class Pessoa
    {
        public int Id {get; set;}

        public string Endereco {get;set;}

        public string Cidade {get;set;}

        public string Cep {get;set;}

        public void ImpimirDados()
        {
            Console.WriteLine("Codigo:" + Id);

            Console.WriteLine("Endereco:" + Endereco);

            Console.WriteLine("Cidade:" + Cidade);
            
            Console.WriteLine("Cep:" + Cep);

        }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF {get;set;}

        public void ImpimirCpf()
        {
            Console.WriteLine("CPF:" + CPF);
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matrícula {get;set;}
    }

    public sealed class Configuracao
    {
        public string Host {get;set;}
    }

    public record Curso(int Id, string Descricao);

    public class CursoTeste
    {
        public int Id { get; set; }

        public string Descricao { get; set; }
    }

    /*public record Curso
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        /*
    public override bool Equals (object? obj)
    {
        if(obj == null) return false;

        if(obj is Curso curso)
        {
            return Id == curso.Id && Descricao == curso.Descricao;
        } 

        return base.Equals(obj);
    }

    public static bool operator == (Curso a , Curso b)
    {
        return a.Equals(b);


    }

    public static bool operator != (Curso a , Curso b)
    {
        return !(a == b);

        
    }

    }*/
    
    public interface INotificacao
    {
        string Descricao{get;set;}
        void Notificar();
    }
    public class NotficacaoCliente : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando Cliente");
        }
    }
    public class NotficacaoFuncionario : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
         Console.WriteLine("Notificando Funcionario");
        }
    }
}