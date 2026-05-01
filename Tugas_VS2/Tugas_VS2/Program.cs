using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulang;
            do
            {
                Console.Write("Program yang Anda ingin jalankan:\n1. Segitiga Pascal\n2. Deret Fibonacci\nMasukan Pilihan Anda: ");
                string pilihan = Console.ReadLine();

                Console.Write("Masukan jumlah angka yang akan ditampilkan: ");
                int n = int.Parse(Console.ReadLine());

                if (pilihan == "1")
                {
                    for (int i = 0; i < n; i++)
                    {
                        int nilai = 1;
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write(nilai + " ");
                            nilai = nilai * (i - j) / (j + 1);
                        }
                        Console.WriteLine();
                    }
                }
                else if (pilihan == "2")
                {
                    int a = 0, b = 1;
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(a + " ");
                        int c = a + b;
                        a = b;
                        b = c;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Anda salah input pilihan");
                }

                Console.Write("Apakah Anda ingin mengulang (Y/N)?: ");
                ulang = Console.ReadLine();

            } while (ulang == "Y" || ulang == "y");

            Console.WriteLine("Program selesai.");
        }
    }
}