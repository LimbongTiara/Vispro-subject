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
            Console.Write("Menu Utama\na. Pendidikan\nb. Karir\nc. Wisata Favorite\nd. Musik\ne. Film Favorite\nMasukkan Pilihan anda: ");
            pilihan = Console.ReadLine();

            if (pilihan == "a" || pilihan == "A")
            {
                string pendidikan;
                Console.WriteLine("Pendidikan\nA. Matematika\nB. Bahasa Inggris\nC. Sains\nD. Informatika\nE. Seni");
                Console.Write("Masukkan pilihan anda: ");
                pendidikan = Console.ReadLine();
                if (pendidikan == "A" || pendidikan == "a")
                {
                    Console.Write("Pilihan anda Matematika");
                }
                else if (pendidikan == "B")
                {
                    Console.Write("Pilihan anda Bahasa Inggris");
                }
                else if (pendidikan == "C")
                {
                    Console.Write("Pilihan anda Sains");
                }
                else if (pendidikan == "D")
                {
                    Console.Write("Pilihan anda Informatika");
                }
                else if (pendidikan == "E")
                {
                    Console.Write("Pilihan anda Seni");
                }
                else
                {
                    Console.Write("Anda salah input pilihan");
                }
            }
            else if (pilihan == "b")
            {
                string karier;
                Console.Write("Karier\nA. Programmer\nB. Desainer\nC. Guru\nD. Dokter\n E. Pengusaha");
                Console.Write("Masukkan pilihan anda: ");
                karier = Console.ReadLine();

                if (karier == "A")
                {
                    Console.Write("Pilihan anda Programmer");
                }
                else if (karier == "B")
                {
                    Console.Write("Pilihan anda Desainer");
                }
                else if (karier == "C")
                {
                    Console.Write("Pilihan anda Guru");
                }
                else if (karier == "D")
                {
                    Console.Write("Pilihan anda Dokter");
                }
                else if (karier == "E")
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
                Console.Write("Wisata Favorite\nA. Pantai\nB. Gunung\nC. Kota\nD. Desa\nE. Zoo");
                Console.Write("Masukkan pilihan anda: ");
                wisata = Console.ReadLine();
                if (wisata == "A")
                {
                    Console.Write("Pilihan tempat wisata anda Pantai");
                }
                else if (wisata == "B")
                {
                    Console.Write("Pilihan tempat wisata anda Gunung");
                }
                else if (wisata == "C")
                {
                    Console.Write("Pilihan tempat wisata anda Kota");
                }
                else if (wisata == "D")
                {
                    Console.Write("Pilihan tempat wisata anda Desa");
                }
                else if (wisata == "E")
                {
                    Console.Write("Pilihan tempat wisata anda Zoo");
                }
                else
                {
                    Console.Write("Anda salah input pilihan");
                }
            }
            else if (pilihan == "d")
            {
                string musik;
                Console.Write("Musik\nA. Pop\nB. Rock\nC. Jazz\nD. J-Pop\nE. K-Pop");
                Console.Write("Masukkan pilihan anda: ");
                musik = Console.ReadLine();
                if (musik == "A")
                {
                    Console.Write("Pilihan anda adalah Musik Pop");
                }
                else if (musik == "B")
                {
                    Console.Write("Pilihan anda adalah Musik Rock");
                }
                else if (musik == "C")
                {
                    Console.Write("Pilihan anda adalah Musik Jazz");
                }
                else if (musik == "D")
                {
                    Console.Write("Pilihan anda adalah Musik J-Pop");
                }
                else if (musik == "E")
                {
                    Console.Write("Pilihan anda adalah Musik K-Pop");
                }
                else
                {
                    Console.Write("Anda salah input pilihan");
                }
            }
            else if (pilihan == "e")
            {
                string film;
                Console.Write("Film Favorite\nA. Action\nB. Komedi\nC. Drama\nD. Horror\nE. Animasi");
                Console.Write("Masukkan pilihan anda: ");
                film = Console.ReadLine();
                if (film == "A")
                {
                    Console.Write("Pilihan anda adalah Film Action");
                }
                else if (film == "B")
                {
                    Console.Write("Pilihan anda adalah Film Komedi");
                }
                else if (film == "C")
                {
                    Console.Write("Pilihan anda adalah Film Drama");
                }
                else if (film == "D")
                {
                    Console.Write("Pilihan anda adalah Film Horror");
                }
                else if (film == "E")
                {
                    Console.Write("Pilihan anda adalah Film Animasi");
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