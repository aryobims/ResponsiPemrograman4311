using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4311
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek 
            Karyawan Karyawan1 = new Karyawan ("3404102002900007", "Paiman", 5000000);
            Karyawan Karyawan2 = new Karyawan("34041030040010007", "Judhit", 4000000);

            //menampilkan data
            Console.WriteLine("Aryo Bimo/21.11.4311/21-IF-07");
            Console.WriteLine("Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 "); Karyawan1.tampilkanData();
            Console.Write("2 "); Karyawan2.tampilkanData();
            Console.WriteLine();

            //pemanggilan method
            Karyawan1.kenaikan();
            Karyawan2.kenaikan();

            Console.WriteLine();
            Console.WriteLine("Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 "); Karyawan1.tampilkanData();
            Console.Write("2 "); Karyawan2.tampilkanData();

            Console.ReadKey();
        }
    }
}
