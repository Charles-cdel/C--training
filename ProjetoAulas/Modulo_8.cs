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
}