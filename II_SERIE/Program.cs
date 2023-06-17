using System;
using System.Globalization;

class program
{

    static void Main()
    {
        int[,] matriz = new int[3, 2];
        //intentamos asignar a los elementos de la matriz 
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3;
        matriz[1, 1] = 4;
        matriz[2, 0] = 5;
        matriz[2, 1] = 6;
        //intentamos imprimir los valores de la matriz
        for (int i=0; i<3;i++)
        {
           //el segundo bucle fort tenia la misma variable "i" que el primero
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("elemento en la pocisión [{0},{1}]:{2}", i, j, matriz[i, j]);
            }
        }
        Console.ReadLine();

    }
}




