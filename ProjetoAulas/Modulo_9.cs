namespace Conversores
{
    public class Conversor
    {
        public void ConvertAndParse()
        {
            //int numero = int.Parse ("1");
            //int numero = Convert.ToInt32("1");
            //bool verdadeiro = bool.Parse("true");
            //Console.WriteLine(verdadeiro);
        
        }

        public void TryParse()
        {
            var numero = "12345678";

            if(int.TryParse(numero, out int numeroConvertido))
            {
                Console.WriteLine("Numero foi convertido com sucesso!");
            }

        Console.WriteLine(numeroConvertido);
        }
        

    }
    
}    




