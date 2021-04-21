using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTADEPRODUTOS
{
    class Program
    {

        struct Dogs
        {
            public string nome;
            public int idade;
            public string cor;
            public string porte;


            public Dogs(string nome, int idade, string cor, string porte)
            {
                this.nome = nome;
                this.idade = idade;
                this.cor = cor;
                this.porte = porte;


            }

            public void ShowInfo()
            {
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Idade: {idade}");
                Console.WriteLine($"Cor: {cor}");
                Console.WriteLine($"Porte: {porte}");
            }


            static void Main(string[] args)
            {
                Dogs poodle = new Dogs("Nina", 10, "Branca", "Pequeno");
                Dogs husky = new Dogs("Totó", 2, "Branca", "Médio");
                Dogs viralata = new Dogs("Sofia", 3, "Cinza e branco", "Grande");
                Dogs viralata2 = new Dogs("Amora", 5, "Preto e Branco", "Grande");


                poodle.ShowInfo();
                Console.WriteLine("==================");
                husky.ShowInfo();
                Console.WriteLine("==================");
                viralata.ShowInfo();
                Console.WriteLine("==================");
                viralata2.ShowInfo();
    
                Console.ReadLine();

            }




        }
    }
}
