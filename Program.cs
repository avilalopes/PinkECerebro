using System;

class minhaClasse 
{
    static void Main(string[] args) { 

        Console.WriteLine("Informe a quantidade de números na lista de Pink: ");
        int suavariavel = int.Parse(Console.ReadLine());
        int multiplo2 = 0, multiplo3 = 0, multiplo4 = 0, multiplo5 = 0;

        Console.WriteLine();
        Console.WriteLine("Informe os números na lista de Pink: ");
        string[] lista = Console.ReadLine().Split();
        int[] numeracao = Array.ConvertAll(lista, int.Parse);

            foreach (var n in numeracao)
            {
                if (n % 2 == 0)
                {
                    multiplo2++;
                }
            }
            foreach (var n in numeracao)                
            {    
                if (n % 3 == 0)
                {
                    multiplo3++;
                }
            }               
            foreach (var n in numeracao)
            {    
                if (n % 4 == 0)
                {
                    multiplo4++;
                }
            }    
            foreach (var n in numeracao)
            {    
                if (n % 5 == 0)
                {
                    multiplo5++;
                }
            }
        Console.WriteLine("{0} Multiplo(s) de 2", multiplo2);
        Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
        Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
        Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);
    }
}
