using System;
namespace AssemblyCSharp.Assets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = new int[4];

            for (int i = 0; i < keys.Length; i++)
            {
                keys[i] = Convert.ToInt32(Console.In.ReadLine());
            }
            for (int i = 0; i < keys.Length; i++)
            {
                Console.Write(keys[i] + "");
            }
        }
    }
}
