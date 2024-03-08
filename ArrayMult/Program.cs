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
            float[] totals = new float[2];

            for (int i = 0; i < 2; i++)
            {
                float[] add = new float[2];
                int v = 0;
                foreach (float nM in matrix[m])
                {
                    float mult = nM * vector[v];
                    // Console.WriteLine($"{nM} x {vector[v]} = {mult}");
                    add[v] = mult;
                    v++;
                }
                
                float total = 0;
                foreach (float n in add)
                {
                    total += n;
                }
                // Console.WriteLine($"{add[0]} + {add[1]} = {total}");
                totals[i] = total;

                m++;
            }

            foreach (float t in totals)
            {
                Console.WriteLine(t);
            }

        }
    }
}
