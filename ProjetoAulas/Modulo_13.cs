namespace Modulo13;

public class TrabalhandoComArquivos
{
    public void CriandoArquivos()
    {
        var escrever = new StreamWriter ("Cadastro.txt", true);// instancia e parametros do meu arquivo
        Console.Write("Informe um Nome: ");
        var nome = Console.ReadLine();
        escrever.WriteLine("ID...: " + Random.Shared.Next(1, 100));//gera um numero aleatorio de 1 a 1000
        escrever.WriteLine("Nome: " + nome);
        escrever.WriteLine("-------------------");
        escrever.Close();
    }

     public void LendoArquivos()
    {
       //var conteudo = File.ReadAllText("Cadastro.txt");//ler todo o conteudo do arquivo
       //Console.WriteLine(conteudo);

       var ler = new StreamReader("Cadastro.txt");// ler linha por linha

       while(!ler.EndOfStream)
       {
        var linha = ler.ReadLine();
        Console.WriteLine(linha);
       }

       ler.Close();
    }

    public void ExcluindoArquivo()
    {
        if(File.Exists("Cadastro.txt"))
        {
            File.Delete("Cadastro.txt");
        }
    }
}