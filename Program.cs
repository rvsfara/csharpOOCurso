using Classe;
namespace CSharpOO
{
    class Program
    {
        public static void Main(string[] args){
            Usuario usuario = new Usuario();
            Animal animal = new Animal();
            usuario.Nome = "Rafael Vieira dos Santos";
            usuario.Email = "rvsfara@gmail.com";
            usuario.Idade = 31;

            animal.Nome = "Choco";
            animal.Especie = "Cachorro";
            animal.Idade = 5;

            usuario.animal = animal;

            Console.WriteLine("Iniciando o Programa");
            Console.WriteLine("Nome: " + usuario.Nome);
            Console.WriteLine("Email: " + usuario.Email);
            Console.WriteLine("Idade: " + usuario.Idade);

            Console.WriteLine("Pet é um: " + usuario.animal.Especie);
            Console.WriteLine("Nome do pet: " + usuario.animal.Nome);
            Console.WriteLine("Idade do pet: " + usuario.animal.Idade);
            Console.WriteLine("Fim do Programa");
        }
    }
    
}