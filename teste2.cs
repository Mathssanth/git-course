using System;
					
public class Program
{
    public class Pessoa{
        string nome;
        int idade;

        public void setIdade(int idade){
            this.idade = idade;
        }
        public int getIdade(){
            return idade;
        }
    }
	public static void Main()
	{
        Pessoa pessoa1 = new Pessoa();

        pessoa1.setIdade(21);

		Console.WriteLine("Hello World");
        Console.WriteLine($"Idade {pessoa1.getIdade}");
	}
}