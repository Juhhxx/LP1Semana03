using System;
using System.Reflection;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração da matriz
            float[,] matrix = new float[2,2];
            matrix[0,0] = float.Parse(args[0]);
            matrix[0,1] = float.Parse(args[1]);
            matrix[1,0] = float.Parse(args[2]);
            matrix[1,1] = float.Parse(args[3]);

            // Declaração do vetor
            float[] vector = new float[2];
            vector[0] = float.Parse(args[4]);
            vector[1] = float.Parse(args[5]);
        }
    }
}
