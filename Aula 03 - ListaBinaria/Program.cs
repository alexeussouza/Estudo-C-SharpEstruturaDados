using System;
class principal{

    static void Main(string[] args)
    {
        System.Console.WriteLine("Lista Binaria");
        int[] lista = new int[10];

        for (int i = 0; i < lista.Length; i++)
        {
            lista[i] = 2 * i;
        }

        for (int i = 0; i < lista.Length; i++)
        {
           System.Console.WriteLine(lista[i]);
        }
        
        System.Console.WriteLine("Digite um valor");
        int valor = Int32.Parse(System.Console.ReadLine());
    

       //Lista Binaria
       int inicio =0;
       int final = lista.Length -1;
       bool achou = false;
       while(inicio <= final){
            int meio = (int) (inicio + final) / 2;

            if(lista[meio] == valor){
                achou = true;
                break;
            }else if(lista[meio] < valor){
                inicio = meio +1;
            }else if(lista[meio] > valor){
                final = meio -1;
            }  
       }
       if(achou)
            System.Console.WriteLine("Achou!");
        else    
            System.Console.WriteLine("Não acho!");
    }
}