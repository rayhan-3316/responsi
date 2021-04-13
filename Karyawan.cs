using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    class Karyawan
    {
        public Karyawan(string nim,string nama,double gaji)
        {
            Nim = nim;
            Nama = nama;
            Gaji = gaji;
        }

        public string Nim { get; set; }
        public string Nama { get; set; }
        public double Gaji { get; set; }
    }
}
