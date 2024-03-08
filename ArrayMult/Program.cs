using System;
using System.Collections.Specialized;
using System.Reflection;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração da matriz
            float[][] matrix = new float[2][];
            matrix[0] = new float[2] {float.Parse(args[0]), float.Parse(args[1])};
            matrix[1] = new float[2] {float.Parse(args[2]), float.Parse(args[3])};

            // Declaração do vetor
            float[] vector = new float[2];
            vector[0] = float.Parse(args[4]);
            vector[1] = float.Parse(args[5]);

            int m = 0;

            for (int i = 0; i < 2; i++)
            {
                int v = 0;
                foreach (float nM in matrix[m])
                {
                    float add = nM * vector[v];
                    Console.WriteLine($"{nM} x {vector[v]} = {add}");
                    v++;

                }
                m++;
            }

        }
    }
}
