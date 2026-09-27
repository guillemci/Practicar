namespace Entrevista_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Write(SubsequenciaConsecutiva(new int[]  { 1, 2, 3, 9, 6, 7, 8, 9, 10}));
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

    }
    
    //static int PrimerDuplicat(int[] numeros)
}