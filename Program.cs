using System;

public class Algoritmo
{
    // 1. Generar numeros con semilla fija (42)
    public int[] GenerarNumeros(int cantidad)
    {
        int[] arreglo = new int[cantidad];
        Random random = new Random(42);

        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = random.Next(0, 100000);
        }

        return arreglo;
    }

    // 2. Implementacion de Bubble Sort
    public void BubbleSort(int[] arreglo)
    {
        int n = arreglo.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    int temporal = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temporal;
                }
            }
        }
    }

    // 3. Validacion: verifica si esta ordenado
    public bool EstaOrdenado(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length - 1; i++)
        {
            if (arreglo[i] > arreglo[i + 1])
            {
                return false;
            }
        }

        return true;
    }
}
