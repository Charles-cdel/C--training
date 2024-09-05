namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterLetrasMinusculas()
    {
        Console.Write("Digite alguma informação:");
        var linha = Console.ReadLine();//aguarda a informção escrita / executada
        Console.WriteLine(linha.ToLower());
    }

    public void ConverterLetrasMaiusculas()
    {
        Console.Write("Digite alguma informação:");
        var linha = Console.ReadLine();//aguarda a informção escrita / executada
        Console.WriteLine(linha.ToUpper());
    }

     public void Substring()
    {
        Console.Write("Digite alguma informação:");
        var linha = Console.ReadLine();//aguarda a informção escrita / executada
        Console.WriteLine(linha.Substring(0,6));
    }
      public void Range()
    {
        string nomeArquivo = "2021_05_14_Mentira.png";
        var ano = nomeArquivo[..4];//vai pegar os 4 primeiros caracteres da string
        Console.WriteLine(ano);
        var extensao = nomeArquivo[^3..];//vai pegar os ultimos 3 caracteres
        Console.WriteLine(extensao);
        var nome = nomeArquivo[11..^4];// vai pegar o caractere apartir do index 11 e apagar os ultimos 4
        Console.WriteLine(nome);
        var apenasNome = nomeArquivo[..^4];// vai pegar todos os caracteres menos os ultimmos 4
        Console.WriteLine(apenasNome);
    }

    public void Contains()
    {
        string nomeArquivo = "2021_05_14_Mentira.png";

        if(nomeArquivo.Contains("2022"))
        {
            Console.WriteLine("Palavra Encontrada");
        }
        else
        {
            Console.WriteLine("Palavra Não Encontrada");

        }

        
        //Console.WriteLine("Contem nome:"+ nomeArquivo.Contains("Mentira"));//Metodo de "pesquisa"
    }

    public void Trim()
    {
       string corte = "**2021_05_14_Mentira.png**";

       Console.WriteLine("TOTAL:" + corte.Trim('*'));
       Console.WriteLine("INICIO:" + corte.TrimStart('*'));
       Console.WriteLine("INICIO:" + corte.TrimEnd('*'));



    }

    public void StartsWithEndsWith()
    {
       string curso = "Curso Csharp";

        
       Console.WriteLine("INICIO:" + curso.StartsWith("Curso"));//verifica se contem no inicio da string
       Console.WriteLine("FINAL:" + curso.EndsWith("Csharp"));////verifica se contem no inicio da string

    }

    public void Replace()
    {
        string substituir = "Curso Csharp";
        Console.WriteLine(substituir);
        Console.WriteLine(substituir.Replace("Csharp","C#"));

    }

    public void Length()
    {
        string contar = Console.ReadLine();
        Console.WriteLine(contar);
        Console.WriteLine(contar.Length);
    }
}