using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4311
{
    public class Karyawan
    {
        private string nik;
        private string nama;
        private int gajibulanan;

        public string Nik
        {
            get { return nik; }
            set { nik = value; }
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public int GajiBulanan
        {
            get { return gajibulanan; }
            set { gajibulanan = value; }
        }

        public Karyawan(string nik, string nama, int gajiBulanan)
        {
            this.nik = nik;
            this.nama = nama;
            this.gajibulanan = gajiBulanan < 0 ? 0 : gajiBulanan;
        }

        public void tampilkanData()
        {
            Console.WriteLine("{0} {1}      {2}", nik, nama, gajibulanan);
        }

        public void kenaikan()
        {
            int kenaikan;

            kenaikan = gajibulanan * 110;
            gajibulanan = kenaikan / 100;

            Console.WriteLine("woooow naik gaji 10%");
        }
    }
}