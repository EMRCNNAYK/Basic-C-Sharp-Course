﻿namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";
            foreach (var student in students) 
            {
            Console.WriteLine(student);
            }

            string[] students2 = new[] { "Engin", "Derin", "Salih" };
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            string[] students3 = { "Engin", "Derin", "Salih" };
            foreach (var student in students3)
            {
                Console.WriteLine(student);
            }

            string[] students4 = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students4)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                { "İstanbul","Kocaeli","Tekirdağ"},
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Mersin"},
                { "Rize","Trabzon","Samsun"},
                { "İzmir","Muğla","Manisa"},
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("**************");
            }


            Console.ReadLine();
        }
    }
}