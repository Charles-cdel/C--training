using System;

namespace Application
{
    public class Program
    {
        static void Main (string[] args)
        { 
            AulaClasses();
        }

        private static void AulaClasses(){

            var resultado = Cadastro.Calculos.SomarNumeros(3, 5);
            Console.WriteLine(resultado);

            /*var produto = new Cadastro.Produto();
            produto.SetId(1);


            produto.Descricao = "Teclado";

            produto.ImpimirDescricao();
            Console.WriteLine(produto.GetId());*/
        }
    }
}