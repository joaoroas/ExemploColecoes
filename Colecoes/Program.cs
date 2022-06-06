using System;

namespace Colecoes
{
    class Program
    {


        int[] arrayNumeros = new int[7] {100, 1, 4, 0, 8, 15, 19};

       var minimo = arrayNumeros.Min();
       var maximo = arrayNumeros.Max();
       var medio = arrayNumeros.Average();
       var soma = arrayNumeros.Sum();
       

       
       
       
       
       
       
        // var numerosParesQuery = 
        //         from num in arrayNumeros
        //         where num % 2 == 0
        //         orderby num
        //         select num;



        // var numerosParesMetodo = arrayNumeros.where(x => x % 2 == 0).orderby(x => x).ToList();










        // Dictionary<string, string> estados = new Dictionary<string, string>();

        // estados.Add("SP", "São Paulo");
        // estados.Add("MG", "Minas Gerais");
        // estados.Add("BA", "Bahia");

        // foreach (KeyValuePair<string, string> item in estados)
        // {
        //     System.Console.WriteLine($"chave: {item.Key}, Valor: {item.Value}");
        // }

        // string valorProcurado = "BA"
        // System.Console.WriteLine(estados[valorProcurado]);








        // Stack<string> pilhaLivros = new Stack<string>();

        // pilhaLivros.Push(".NET");
        // pilhaLivros.Push("DDD");
        // pilhaLivros.Push("Codigo Limpo");

        // while (pilhaLivros.Count > 0)
        // {
        //     System.Console.WriteLine($"Proximo livro para leitura: {pilhaLivros.Peek()}");
        //     System.Console.WriteLine($"{pilhaLivros.Pop()} Lido com sucesso.");
        // }



        // Queue<string> fila = new Queue<string>();

        // fila.Enqueue("Leonardo");
        // fila.Enqueue("João");
        // fila.Enqueue("Ricardo");

        // while (fila.Count > 0)
        // {
        //     System.Console.WriteLine($"Vez de {fila.Peek()}");
        //     System.Console.WriteLine(${fila.Dequeue()}c"Atendido");
        // }



        // List<string> estados = new List<string> {"SP", "MG", "BA"};
        // estados.Add("SP")
        // estados.Add("MG")
        // estados.Add("BA")

        // System.Console.WriteLine($"Quantidadde de elementos na lista: {estados.Count}");

        // foreach (var item in estados)
        // {
        //     System.Console.WriteLine(item);
        // }

        
        // for (int i = 0; i < estador.Count; i++)
        // {
        //     System.Console.WriteLine($"Indice {i}, Valor: {estados[i]}");
        // }



        // static void Main(string[] args)
        // {
        //     OperacoesArray op = new OperacoesArray
        //     int[] array = new int[5]{6, 3, 8, 1, 9};
        //     int[] arrayCopia = new int[10];

        //     System.Console.WriteLine("Array original");
        //     op.ImprimirArray(array);

           
        //    // op.OrdenarBubbleSort(ref array);

        //   // op.Ordenar(array);

        //     System.Console.WriteLine("Array ordenado");
        //     op.ImprimirArray(array);








        //     in[,] matriz = int[4, 2]
        //     {
        //         {8, 8},
        //         {10, 20},
        //         {50, 100},
        //         {90, 200}
        //     };

        //     for (int i = 0; i < matriz.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < matriz.GetLength(1); j++)
        //         {
        //             System.Console.WriteLine(matriz[i, j]);
        //         }
        //     }

            

           
           
        //     int[] arrayInteiros = new int[3];

        //     arrayInteiros[0] = 10;
        //     arrayInteiros[1] = 20;
        //     arrayInteiros[2] = 30;

        //     System.Console.WriteLine("Percorrendo array pelo for");

        //     for (int i = 0; i < arrayInteiros.Length; i++)
        //     {
        //         System.Console.WriteLine(arrayInteiros[i]);
        //     }

        //     System.Console.WriteLine("Percorrendo array pelo foreach");

        //     foreach (int item in arrayInteiros)
        //     {
        //         System.Console.WriteLine(item);
        //     }
            
        // }
    }
}
