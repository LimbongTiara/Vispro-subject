using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pilihan;
            Console.Write("Menu Utama\na. Pendidikan\nb. Karir\nc. Wisata Favorite\nd. Musik\n Film Favorite\nMasukkan Pilihan anda: ");
            pilihan = Console.ReadLine();

            if (pilihan == "a" || pilihan == "A")
            {
                string pendidikan;
                Console.WriteLine("Menu Pendidikan\nA. Matematika\nB. Sains\nC. Seni\nD. Informatika\nE. Bahasa Inggris");
                Console.Write("Masukkan pilihan anda: ");
                pendidikan = Console.ReadLine();
                if (pendidikan == "A" || pendidikan == "a")
                {
                    Console.Write("Pilihan anda Matematika");

                }
                else if (pendidikan == "B")
                {
                    Console.Write("Pilihan anda Sains");
                }
                else if (pendidikan == "C")
                {
                    Console.Write("Pilihan anda Seni");
                }
                else if (pendidikan == "D")
                {
                    Console.Write("Pilihan anda Informatika");
                }
                else if (pendidikan == "E")
                {
                    Console.Write("Pilihan anda Bahasa Inggris");
                }
                else
                {
                    Console.Write("Anda salah input pilihan");
                }
            }
            else if (pilihan == "b")
            {
                string karir;
                Console.Write("Karir\nA. Programmer\nB. Desainer\nC. Guru\nD. Dokter\nE. Pengusaha");
                Console.Write("Masukkan pilihan anda: ");
                karir = Console.ReadLine();

                if (karir == "A")
                {
                    Console.Write("Pilihan anda Programmer");
                }
                else if (karir == "B")
                {
                    Console.Write("Pilihan anda Desainer");
                }
                else if (karir == "C")
                {
                    Console.Write("Pilihan anda Guru");
                }
                else if (karir == "D")
                {
                    Console.Write("Pilihan anda Dokter");
                }
                else if (karir == "E")
                {
                    Console.Write("Pilihan anda Pengusaha");
                }
                else
                {
                    Console.Write("Anda salah input pilihan");
                }

            }
            else if (pilihan == "c")
            {
                string wisata;
                Console.Write("Tempat Wisata Favorite\nA. Pantai\nB. Gunung\nC. Kota\nD. Desa\nE. Taman Hiburan");
                Console.Write("Masukkan pilihan anda: ");
                wisata = Console.ReadLine();
                if (wisata == "A")
                {
                    Console.Write("Pilihan anda cemilan Pisang Goreng");
                }
                else if (wisata == "B")
                {
                    Console.Write("Pilihan anda cemilan Bakwan");
                }
                else if (wisata == "C")
                {
                    Console.Write("Pilihan anda cemilan Tahu isi");
                }
                }
                else if (wisata == "D")
                {
                    Console.Write("Pilihan anda cemilan Tahu isi");
                }
                else
                {
                    Console.Write("Anda salah input pilihan");
                }
            }
            else
            {
                Console.Write("Anda salah input pilihan");
            }


            Console.Read();
        }
    }
}