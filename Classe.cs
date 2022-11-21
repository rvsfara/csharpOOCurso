namespace Classe{
class Usuario
    {
        public string Nome {get; set;}
        public string Email {get; set;}
        public int Idade {get; set;}
        public Animal animal {get; set;}
        
    }
    public class Animal
    {
        public string Nome { get; set;}
        public int Idade {get; set;}
        public string Especie {get; set;}
    }
}