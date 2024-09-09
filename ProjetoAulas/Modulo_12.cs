namespace Modulo12;

public class TrabalhandoComExceptions
{
    public void GerandoException()
    {
        while(true) // enquanto for verdadeiro teremos um loop desse evento
        {
            Console.Write("Escreva um numero");// Console.Write pega uma informação
            var numero = Console.ReadLine();// ''ReadLine Ler a informação e retorna em string
            var resultado = 500 / int.Parse(numero);// fiz a conversão de valor da variavel numero para int, ultilizando o Parse
            Console.WriteLine("Resultado:"+ resultado);// concatenando a mensagem em string com a variavel resultado.
        }

    }

    public void ResolvendoException()
    {


        while(true)     
        {
            try
            {
                Console.Write("Escreva um numero: ");
                var numero = Console.ReadLine();
                var resultado = 500 / int.Parse(numero);
                Console.WriteLine("Resultado:"+ resultado);
       
            }

            catch(DivideByZeroException exception)//usado para capturar erros aritiméticos(captura erros especificos)
            {
                Console.WriteLine("Ocorreu um erro de visisão: "+ exception.Message);
                Console.WriteLine("Stack: "+ exception.StackTrace);
            }
            catch(Exception exception)
            {
                Console.WriteLine("Ocorreu um erro: "+ exception.Message);
                Console.WriteLine("Stack: "+ exception.StackTrace);
                
            }
        }

    }
}

