using System.Collections.ObjectModel;

namespace DeleteList.Model
{
    public class Lista
    {
        public string Nome { get; set; }
        public string Idade { get; set; }

        public Lista(string nome, string idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }

    
    
}
