using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> produtos = new List<string>(); // ou =("pepsi", "guaraná");
            produtos.Add("pepsi");
            produtos.Add("guaraná");
            
            string resposta;
            Console.WriteLine("Bem-Vindo ao quenti-store");
            while (true)
            {
                Console.WriteLine("Digite - 1 para cadastrar ou 2 - para liberar:");
                resposta = (Console.ReadLine());
                if (resposta == "1")
                {
                    Console.WriteLine("Qual o produtor deseja cadastrar");
                    string produto = (Console.ReadLine());
                    if (produtos.Contains(produto.ToLower()))
                    {
                        Console.WriteLine("ESSE PRODUTO JA ESTÁ NA LISTA...");

                    }
                    else
                    {
                        produtos.Add(produto.ToLower());
                        Console.WriteLine("Produto Adicionado!!");
                        
                    }

                }
                else
                {
                    string texto = "";
                    int contador = 0;
                    while (contador < produtos.Count)
                    {
                        string primeiraLetraMaiuscula = texto.Substring(0, 1).ToUpper() + texto.Substring(1);
                        texto += produtos[contador] + ", ";
                        contador++;
                    }
                    string texto2 = texto.Substring(0, texto.Length - 2);
                    Console.WriteLine(texto2);

                }
            }
            
            
        }
    }
}
