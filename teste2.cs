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
    public class hero:Pessoa{
        string poder
        hero(string poder){
            this.poder=poder;
        }
        public int getPoder(){
            return poder;
        }
        public override int getIdade(){
            return idade + 2;
        }
    }
	public static void Main()
	{
        hero pessoa1 = new hero("luz");

        pessoa1.setIdade(21);

		Console.WriteLine("Hello World");
        Console.WriteLine($"Idade {pessoa1.getIdade}");
        Console.WriteLine($"Poder {pessoa1.getPoder}");
	}
}