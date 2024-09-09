namespace Modulo14;

public class TrabalhandoComLinq
{
    public void Where()
    {
        /*string nomeCompleto = "Carlos Alberto Carneiro";

        Func<char,bool> filtro = c => c == 'a';

        //var resultado = nomeCompleto.Where(filtro);//Sintaxe de metodo

        //var resultado = nomeCompleto.Where(p => p =='A');

        var resultado = from c in nomeCompleto where c == 'r' select c;//Sintaxe de consulta

        foreach (var letra in resultado)
        {
            Console.WriteLine(letra);
        }*/

        var numeros = new int[] {1,3,5,7,9,43,56,12};
        var resultado = numeros.Where(p => p >= 10);

        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }

       
    }
     public void OrderBy()
    {
        var nomes = new string[] {"Carlos", "Alberto", "Carneiro"};
        //var numeros = new int[] {1,31,52,7,9,43,56,12};
        //var resultado = numeros.OrderBy(p => p);
        var resultado = nomes.OrderByDescending(p => p);
    
    

        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }

    }
    public void Take()
    {
        var numeros = new int[] {1,31,52,7,9,43,56,12};

        var resultado = numeros.Where(p => p >10).Take(4).OrderBy(p => p);

        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void Count()
    {
        var numeros = new int[] {1,31,52,7,9,43,56,12};

        var resultado = numeros.Count(p => p > 10);

        Console.WriteLine(resultado);
    }


    public void FirstAndFirstOrDefault()
    {
        var numeros = new int[] {1,31,52,7,9,43,56,12};

        //var resultado = numeros.First();
        //var resultado = numeros.First(p => p> 100);
        var resultado = numeros.FirstOrDefault(p => p> 100, -99);

        Console.WriteLine(resultado);
    }
}