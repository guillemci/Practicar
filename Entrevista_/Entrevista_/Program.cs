namespace Entrevista_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(SubsequenciaConsecutiva(new int[]  { 1,2,3,4,2,3,1,5,7,9,10}));
        Console.WriteLine(PrimerDuplicat(new int[] {2,7,8,9,2,7}));
    }

    static int NumeroMesRepetit(int[] numeros)
    {
        int mestrovat = numeros[0];
        int countMesTrovat = 0;
        int count = 0;
        
        for (int i = 0; i < numeros.Length; i++)
        {
            count++;
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[i] == numeros[j])
                    count++;
            }
            
            if (count > countMesTrovat)
            {
                mestrovat = numeros[i];
                countMesTrovat = count;
            }

            count = 0;
        }
        
        return mestrovat;
    }

    static int SegonaMajoria(int[] numeros)
    {
        int mesGran = numeros[0];
        int segonMesGran = numeros[0];
        
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > mesGran)
                mesGran = numeros[i];
            
            if (numeros[i] < mesGran && numeros[i] > segonMesGran)
                segonMesGran = numeros[i];
        }
        
        return segonMesGran;
    }


    static int SubsequenciaConsecutiva(int[] numeros)
    {
        int countMesLlarga = 1;
        int count = 1;

        for (int i = 0; i < numeros.Length - 1; i++)
        {
            if (numeros[i] < numeros[i + 1])
            {
                count++;
                if (count > countMesLlarga)
                    countMesLlarga = count;
            }
            else
                count = 1;
        }
        return countMesLlarga;
    }

    static int PrimerDuplicat(int[] numeros)
    {
        int numero = -1;
        bool trovat = false;
        int i = 0;
        int j = 1;
        while (!trovat && i < numeros.Length)
        {
            while (!trovat && j < numeros.Length)
            {
                if (numeros[i] == numeros[j])
                {
                    trovat = true;
                    numero = numeros[i];
                }
                else
                    j++;
            }
            i++;
            j = i + 1;
        }
        return numero;
    }
    
    //fer el problema de canvi
    
    //Feu un programa que permeti la introducció d’una sèrie de números fins que un d’aquests números sigui major que la suma dels dos números anteriors.
    //Al finalitzar, ha de dir el número d'introduccions i valors dels números que han complert la condició de finalització del programa. 
    
    //fer problema emplenar una matiru

    public static int rotacioArray()
    {
        
    }
}